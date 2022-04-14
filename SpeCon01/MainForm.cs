using MySql.Data.MySqlClient;
using SpeCon01;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void log_out_MouseEnter(object sender, EventArgs e)
        {
            log_out_btn.ForeColor = Color.FromArgb(70, 223, 242);
        }

        private void log_out_MouseLeave(object sender, EventArgs e)
        {
            log_out_btn.ForeColor = Color.FromArgb(4, 43, 77);
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Black;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }

        private void log_out_Click(object sender, EventArgs e)
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

        private void rev_summ_main_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Revenue revenue = new Revenue();
            revenue.Show();
        }

        private void exp_summ_main_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expense expense = new Expense();
            expense.Show();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();

            
            
            DB db = new DB();

            MySqlCommand commandRev = new MySqlCommand(string.Format("SELECT SUM(`summ`) from `revenue`"), db.getConnection());   

            try
            {
                DataTable table = new DataTable();
                table.Clear();
                db.openConnection();
                commandRev.ExecuteNonQuery();
                table.Load(commandRev.ExecuteReader());
                dataGridView_rev_main.DataSource = table;
                rev_summ_main.Text = dataGridView_rev_main.CurrentRow.Cells[0].Value.ToString();

                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
                
            }

            // Расходы
            MySqlCommand commandExp = new MySqlCommand(string.Format("SELECT SUM(`summ`) from `expense`"), db.getConnection());   

            try
            {
                DataTable table = new DataTable();
                table.Clear();
                db.openConnection();
                commandExp.ExecuteNonQuery();
                table.Load(commandExp.ExecuteReader());
                dataGridView_exp_main.DataSource = table;
                exp_summ_main.Text = dataGridView_exp_main.CurrentRow.Cells[0].Value.ToString();

                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.closeConnection();
                
            }

            decimal res = Convert.ToDecimal(rev_summ_main.Text) - Convert.ToDecimal(exp_summ_main.Text);
            result_main.Text = res.ToString(); 

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_lbl.Text = DateTime.Now.ToShortTimeString();
            date_lbl.Text = DateTime.Now.ToShortDateString();
        }

        

    }
}
