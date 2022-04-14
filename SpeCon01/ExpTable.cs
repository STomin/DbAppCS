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
    public partial class ExpTable : Form
    {
        public ExpTable()
        {
            InitializeComponent();

            articleBox.Text = "Статья";
            articleBox.ForeColor = Color.Gray;
            titleBox.Text = "Название";
            titleBox.ForeColor = Color.Gray;
            summBox.Text = "Сумма";
            summBox.ForeColor = Color.Gray;

        }


        private void FillData()       
        {
            try
            {
                DataTable table = new DataTable();
                table.Clear();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `expense`", db.getConnection());
                db.openConnection();
                table.Load(command.ExecuteReader());
                expense_table.DataSource = table;
                expense_table.Columns[0].Visible = false;
                expense_table.Columns[1].HeaderText = "Статья";
                expense_table.Columns[2].HeaderText = "Название";
                expense_table.Columns[3].HeaderText = "Сумма";
                expense_table.Columns[4].HeaderText = "Дата";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                DB db = new DB();
                db.closeConnection();
            }
        }
        private void exp_add_btn_Click(object sender, EventArgs e)
        {
            DB db = new DB();   

            MySqlCommand command = new MySqlCommand(string.Format("INSERT INTO `expense`(`article`, `title`, `summ`, `date`) VALUES ('{0}', '{1}', {2}, '{3}')", articleBox.Text, titleBox.Text, summBox.Text, dateBox.Text), db.getConnection());    

            try
            {
                db.openConnection();
                command.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
                FillData();
                articleBox.Text = "";
                titleBox.Text = "";
                summBox.Text = "";
                dateBox.Text = "";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            FillData();
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

        private void articleBox_Enter(object sender, EventArgs e)
        {
            if (articleBox.Text == "Статья")
            {
                articleBox.Text = "";
                articleBox.ForeColor = Color.Black;
            }
        }

        private void articleBox_Leave(object sender, EventArgs e)
        {
            if (articleBox.Text == "")
            {
                articleBox.Text = "Статья";
                articleBox.ForeColor = Color.Gray;
            }
        }

        private void titleBox_Enter(object sender, EventArgs e)
        {
            if (titleBox.Text == "Название")
            {
                titleBox.Text = "";
                titleBox.ForeColor = Color.Black;
            }
        }

        private void titleBox_Leave(object sender, EventArgs e)
        {
            if (titleBox.Text == "")
            {
                titleBox.Text = "Название";
                titleBox.ForeColor = Color.Gray;
            }
        }

        private void summBox_Enter(object sender, EventArgs e)
        {
            if (summBox.Text == "Сумма")
            {
                summBox.Text = "";
                summBox.ForeColor = Color.Black;
            }
        }

        private void summBox_Leave(object sender, EventArgs e)
        {
            if (summBox.Text == "")
            {
                summBox.Text = "Сумма";
                summBox.ForeColor = Color.Gray;
            }
        }

        private void UpdateRecord()
        {
            DB db = new DB();
            int tableID = Convert.ToInt32(expense_table.CurrentRow.Cells[0].Value);
            try
            {
                MySqlCommand command = new MySqlCommand(string.Format("UPDATE `expense` SET `article` = '{0}', `title` = '{1}', `summ` = {2}, `date` = '{3}' WHERE `expense`.`id` = {4}", articleBox.Text, titleBox.Text, summBox.Text, dateBox.Text, expense_table.CurrentRow.Cells[0].Value), db.getConnection());

                db.openConnection();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
                FillData();
            }
        }
        private void DeleteRecord()
        {
            DB db = new DB();

            try
            {
                MySqlCommand command = new MySqlCommand(string.Format("DELETE FROM `expense` WHERE `expense`.`id` = {0}", expense_table.CurrentRow.Cells[0].Value), db.getConnection());

                db.openConnection();
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
                FillData();
            }
        }

        private void exp_update_btn_Click(object sender, EventArgs e)
        {
            UpdateRecord();
        }

        private void exp_del_btn_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void ExpTable_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void expense_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            articleBox.Text = expense_table.CurrentRow.Cells[1].Value.ToString();
            titleBox.Text = expense_table.CurrentRow.Cells[2].Value.ToString();
            summBox.Text = expense_table.CurrentRow.Cells[3].Value.ToString();
            dateBox.Text = expense_table.CurrentRow.Cells[4].Value.ToString();

        }

        private void back_pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expense expense = new Expense();
            expense.Show();
        }
    }
}
