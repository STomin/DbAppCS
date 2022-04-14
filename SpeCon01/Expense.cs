using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeCon01
{
    public partial class Expense : Form
    {
        public Expense()
        {

            InitializeComponent();
        }

        private void main_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

        private void rev_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Revenue revenue = new Revenue();
            revenue.Show();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void log_out_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void pecture_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void log_out_btn_MouseEnter(object sender, EventArgs e)
        {
            log_out_btn.ForeColor = Color.FromArgb(70, 223, 242);
        }

        private void log_out_btn_MouseLeave(object sender, EventArgs e)
        {
            log_out_btn.ForeColor = Color.FromArgb(4, 43, 77);
        }

        Point lastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void dash_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void dash_panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void av_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)  
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void av_panel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(70, 223, 242);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(91, 136, 147);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpTable expTable = new ExpTable();
            expTable.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExpTable expTable = new ExpTable();
            expTable.Show();
        }

        private void Expense_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand commandExp = new MySqlCommand(string.Format("SELECT SUM(`summ`) from `expense`"), db.getConnection());   

            try
            {
                DataTable tableExp = new DataTable();
                tableExp.Clear();
                db.openConnection();
                commandExp.ExecuteNonQuery();
                tableExp.Load(commandExp.ExecuteReader());
                dataGridView1.DataSource = tableExp;
                exp_summ_exp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
                
            }
        }
    }
}
