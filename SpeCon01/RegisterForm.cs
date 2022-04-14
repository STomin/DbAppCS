using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeCon01
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            userNameField.Text = "Имя";  
            userNameField.ForeColor = Color.Gray;

            passFieldReg.Text = "Пароль";
            passFieldReg.ForeColor = Color.Gray;
            passFieldReg.UseSystemPasswordChar = false;

            passFieldRep.Text = "Пароль повторно";
            passFieldRep.ForeColor = Color.Gray;
            passFieldRep.UseSystemPasswordChar = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        Point lastPoint;
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)   
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (userNameField.Text == "Имя")
            {
                userNameField.Text = "";   
                userNameField.ForeColor = Color.Black;
            }
        }
        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Имя"; 
                userNameField.ForeColor = Color.Gray;
            }

        }

        private void passFieldReg_Enter(object sender, EventArgs e)
        {
            if (passFieldReg.Text == "Пароль")
            {
                passFieldReg.UseSystemPasswordChar = true;
                passFieldReg.Text = "";
                passFieldReg.ForeColor = Color.Black;
            }
        }

        private void passFieldReg_Leave(object sender, EventArgs e)
        {
            if (passFieldReg.Text == "")
            {
                passFieldReg.UseSystemPasswordChar = false;
                passFieldReg.Text = "Пароль"; 
                passFieldReg.ForeColor = Color.Gray;
            }
        }

        private void passFieldRep_Enter(object sender, EventArgs e)
        {
            if (passFieldRep.Text == "Пароль повторно")
            {
                passFieldRep.UseSystemPasswordChar = true;
                passFieldRep.Text = "";
                passFieldRep.ForeColor = Color.Black;
            }
        }

        private void passFieldRep_Leave(object sender, EventArgs e)
        {
            if (passFieldRep.Text == "")
            {
                passFieldRep.UseSystemPasswordChar = false;
                passFieldRep.Text = "Пароль повторно";
                passFieldRep.ForeColor = Color.Gray;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (userNameField.Text == "Имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }

            if (passFieldReg.Text == "Пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (checkUser())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`) VALUES (@login, @pass)", db.getConnection());    

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passFieldReg.Text;

            if (passFieldRep.Text == passFieldReg.Text)
            {
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Пользователь зарегистрирован");
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else
                    MessageBox.Show("Ошибка регистрации");


                db.closeConnection();
            }
            else
                MessageBox.Show("Введённые пароли не совпадают");
        }

        public Boolean checkUser()  
        {
            DB db = new DB();  

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());    
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userNameField.Text;  

            adapter.SelectCommand = command;    
            adapter.Fill(table);    

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой пользователь уже зарегистрирован");
                return true;
            }
            else
                return false;
        }
    }
}
