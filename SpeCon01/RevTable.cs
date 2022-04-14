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
    public partial class RevTable : Form
    {
        
        public RevTable()
        {
            InitializeComponent();

            articleBox.Text = "Статья";
            articleBox.ForeColor = Color.Gray;
            titleBox.Text = "Название";
            titleBox.ForeColor = Color.Gray;
            summBox.Text = "Сумма";
            summBox.ForeColor = Color.Gray;

        }

        private void rev_add_btn_Click(object sender, EventArgs e)
        {
           
            DB db = new DB();   

            MySqlCommand command = new MySqlCommand(string.Format("INSERT INTO `revenue`(`article`, `title`, `summ`, `date`) VALUES ('{0}', '{1}', {2}, '{3}')", articleBox.Text, titleBox.Text, summBox.Text, dateBox.Text), db.getConnection());    // выборка данных из БД


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

        private void FillData()         
        {
            try
            {
                DataTable table = new DataTable();
                table.Clear();
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `revenue`", db.getConnection());
                db.openConnection();
                table.Load(command.ExecuteReader());
                revenue_table.DataSource = table;
                revenue_table.Columns[0].Visible = false;
                revenue_table.Columns[1].HeaderText = "Статья";
                revenue_table.Columns[2].HeaderText = "Название";
                revenue_table.Columns[3].HeaderText = "Сумма";
                revenue_table.Columns[4].HeaderText = "Дата";
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


        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            FillData();
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
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

        private void summBox_Enter_1(object sender, EventArgs e)
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
            int tableID = Convert.ToInt32(revenue_table.CurrentRow.Cells[0].Value);
            try
            {
                MySqlCommand command = new MySqlCommand(string.Format("UPDATE `revenue` SET `article` = '{0}', `title` = '{1}', `summ` = {2}, `date` = '{3}' WHERE `revenue`.`id` = {4}", articleBox.Text, titleBox.Text, summBox.Text, dateBox.Text, revenue_table.CurrentRow.Cells[0].Value),  db.getConnection());

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
                MySqlCommand command = new MySqlCommand(string.Format("DELETE FROM `revenue` WHERE `revenue`.`id` = {0}", revenue_table.CurrentRow.Cells[0].Value), db.getConnection());

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

        private void rev_update_btn_Click(object sender, EventArgs e)
        {
            UpdateRecord();
        }

        private void rev_del_btn_Click(object sender, EventArgs e)
        {
            DeleteRecord();
        }

        private void RevTable_Load(object sender, EventArgs e)
        {
            FillData();
        }

        private void revenue_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            articleBox.Text = revenue_table.CurrentRow.Cells[1].Value.ToString();
            titleBox.Text = revenue_table.CurrentRow.Cells[2].Value.ToString();
            summBox.Text = revenue_table.CurrentRow.Cells[3].Value.ToString();
            dateBox.Text = revenue_table.CurrentRow.Cells[4].Value.ToString();

        }

        private void back_pic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Revenue revenue = new Revenue();
            revenue.Show();
        }
    }
}
