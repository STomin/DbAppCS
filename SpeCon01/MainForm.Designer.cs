
namespace SpeCon01
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.result_main = new System.Windows.Forms.Label();
            this.chart1_panel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.time_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.time_lbl = new System.Windows.Forms.Label();
            this.date_lbl = new System.Windows.Forms.Label();
            this.exp_panel = new System.Windows.Forms.Panel();
            this.dataGridView_exp_main = new System.Windows.Forms.DataGridView();
            this.exp_summ_main = new System.Windows.Forms.Label();
            this.picture_minus = new System.Windows.Forms.PictureBox();
            this.chart2_panel = new System.Windows.Forms.Panel();
            this.rev_panel = new System.Windows.Forms.Panel();
            this.dataGridView_rev_main = new System.Windows.Forms.DataGridView();
            this.rev_summ_main = new System.Windows.Forms.Label();
            this.picture_plus = new System.Windows.Forms.PictureBox();
            this.picture_main = new System.Windows.Forms.PictureBox();
            this.picture_rev = new System.Windows.Forms.PictureBox();
            this.pecture_out = new System.Windows.Forms.PictureBox();
            this.picture_exp = new System.Windows.Forms.PictureBox();
            this.log_out_btn = new System.Windows.Forms.Label();
            this.main_btn = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.av_panel = new System.Windows.Forms.Label();
            this.exp_btn = new System.Windows.Forms.Button();
            this.rev_btn = new System.Windows.Forms.Button();
            this.dash_panel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.time_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.exp_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_exp_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_minus)).BeginInit();
            this.rev_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rev_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecture_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_exp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.result_main);
            this.MainPanel.Controls.Add(this.chart1_panel);
            this.MainPanel.Controls.Add(this.closeButton);
            this.MainPanel.Controls.Add(this.time_panel);
            this.MainPanel.Controls.Add(this.exp_panel);
            this.MainPanel.Controls.Add(this.chart2_panel);
            this.MainPanel.Controls.Add(this.rev_panel);
            this.MainPanel.Controls.Add(this.picture_main);
            this.MainPanel.Controls.Add(this.picture_rev);
            this.MainPanel.Controls.Add(this.pecture_out);
            this.MainPanel.Controls.Add(this.picture_exp);
            this.MainPanel.Controls.Add(this.log_out_btn);
            this.MainPanel.Controls.Add(this.main_btn);
            this.MainPanel.Controls.Add(this.name_label);
            this.MainPanel.Controls.Add(this.avatar);
            this.MainPanel.Controls.Add(this.av_panel);
            this.MainPanel.Controls.Add(this.exp_btn);
            this.MainPanel.Controls.Add(this.rev_btn);
            this.MainPanel.Controls.Add(this.dash_panel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1067, 554);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.pictureBox2.Image = global::SpeCon01.Properties.Resources.resultpic;
            this.pictureBox2.Location = new System.Drawing.Point(390, 113);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // result_main
            // 
            this.result_main.BackColor = System.Drawing.Color.Transparent;
            this.result_main.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.result_main.Location = new System.Drawing.Point(193, 155);
            this.result_main.Name = "result_main";
            this.result_main.Size = new System.Drawing.Size(455, 81);
            this.result_main.TabIndex = 40;
            this.result_main.Text = "Итог";
            this.result_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1_panel
            // 
            this.chart1_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.chart1_panel.Location = new System.Drawing.Point(193, 239);
            this.chart1_panel.Name = "chart1_panel";
            this.chart1_panel.Size = new System.Drawing.Size(456, 303);
            this.chart1_panel.TabIndex = 36;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.closeButton.Location = new System.Drawing.Point(1047, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 23);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Х";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // time_panel
            // 
            this.time_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.time_panel.Controls.Add(this.pictureBox1);
            this.time_panel.Controls.Add(this.time_lbl);
            this.time_panel.Controls.Add(this.date_lbl);
            this.time_panel.Location = new System.Drawing.Point(655, 12);
            this.time_panel.Name = "time_panel";
            this.time_panel.Size = new System.Drawing.Size(400, 124);
            this.time_panel.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.pictureBox1.Image = global::SpeCon01.Properties.Resources.timepic;
            this.pictureBox1.Location = new System.Drawing.Point(127, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BackColor = System.Drawing.Color.Transparent;
            this.time_lbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.time_lbl.Location = new System.Drawing.Point(214, 70);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(85, 32);
            this.time_lbl.TabIndex = 38;
            this.time_lbl.Text = "Время";
            this.time_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date_lbl
            // 
            this.date_lbl.AutoSize = true;
            this.date_lbl.BackColor = System.Drawing.Color.Transparent;
            this.date_lbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.date_lbl.Location = new System.Drawing.Point(214, 28);
            this.date_lbl.Name = "date_lbl";
            this.date_lbl.Size = new System.Drawing.Size(66, 32);
            this.date_lbl.TabIndex = 37;
            this.date_lbl.Text = "Дата";
            this.date_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exp_panel
            // 
            this.exp_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.exp_panel.Controls.Add(this.dataGridView_exp_main);
            this.exp_panel.Controls.Add(this.exp_summ_main);
            this.exp_panel.Controls.Add(this.picture_minus);
            this.exp_panel.Location = new System.Drawing.Point(422, 12);
            this.exp_panel.Name = "exp_panel";
            this.exp_panel.Size = new System.Drawing.Size(227, 124);
            this.exp_panel.TabIndex = 34;
            // 
            // dataGridView_exp_main
            // 
            this.dataGridView_exp_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_exp_main.Location = new System.Drawing.Point(14, 28);
            this.dataGridView_exp_main.Name = "dataGridView_exp_main";
            this.dataGridView_exp_main.RowHeadersWidth = 51;
            this.dataGridView_exp_main.RowTemplate.Height = 24;
            this.dataGridView_exp_main.Size = new System.Drawing.Size(1, 1);
            this.dataGridView_exp_main.TabIndex = 41;
            // 
            // exp_summ_main
            // 
            this.exp_summ_main.BackColor = System.Drawing.Color.Transparent;
            this.exp_summ_main.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exp_summ_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.exp_summ_main.Location = new System.Drawing.Point(27, 68);
            this.exp_summ_main.Name = "exp_summ_main";
            this.exp_summ_main.Size = new System.Drawing.Size(196, 56);
            this.exp_summ_main.TabIndex = 40;
            this.exp_summ_main.Text = "Расходы";
            this.exp_summ_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_minus
            // 
            this.picture_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.picture_minus.Image = global::SpeCon01.Properties.Resources.minus;
            this.picture_minus.Location = new System.Drawing.Point(86, 4);
            this.picture_minus.Margin = new System.Windows.Forms.Padding(4);
            this.picture_minus.Name = "picture_minus";
            this.picture_minus.Size = new System.Drawing.Size(60, 60);
            this.picture_minus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_minus.TabIndex = 38;
            this.picture_minus.TabStop = false;
            // 
            // chart2_panel
            // 
            this.chart2_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.chart2_panel.Location = new System.Drawing.Point(655, 142);
            this.chart2_panel.Name = "chart2_panel";
            this.chart2_panel.Size = new System.Drawing.Size(400, 400);
            this.chart2_panel.TabIndex = 35;
            // 
            // rev_panel
            // 
            this.rev_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.rev_panel.Controls.Add(this.dataGridView_rev_main);
            this.rev_panel.Controls.Add(this.rev_summ_main);
            this.rev_panel.Controls.Add(this.picture_plus);
            this.rev_panel.Location = new System.Drawing.Point(193, 12);
            this.rev_panel.Name = "rev_panel";
            this.rev_panel.Size = new System.Drawing.Size(227, 124);
            this.rev_panel.TabIndex = 33;
            // 
            // dataGridView_rev_main
            // 
            this.dataGridView_rev_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_rev_main.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_rev_main.Name = "dataGridView_rev_main";
            this.dataGridView_rev_main.RowHeadersWidth = 51;
            this.dataGridView_rev_main.RowTemplate.Height = 24;
            this.dataGridView_rev_main.Size = new System.Drawing.Size(1, 1);
            this.dataGridView_rev_main.TabIndex = 0;
            // 
            // rev_summ_main
            // 
            this.rev_summ_main.BackColor = System.Drawing.Color.Transparent;
            this.rev_summ_main.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rev_summ_main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.rev_summ_main.Location = new System.Drawing.Point(3, 68);
            this.rev_summ_main.Name = "rev_summ_main";
            this.rev_summ_main.Size = new System.Drawing.Size(197, 56);
            this.rev_summ_main.TabIndex = 39;
            this.rev_summ_main.Text = "Доходы";
            this.rev_summ_main.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picture_plus
            // 
            this.picture_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.picture_plus.Image = global::SpeCon01.Properties.Resources.plus;
            this.picture_plus.Location = new System.Drawing.Point(81, 4);
            this.picture_plus.Margin = new System.Windows.Forms.Padding(4);
            this.picture_plus.Name = "picture_plus";
            this.picture_plus.Size = new System.Drawing.Size(60, 60);
            this.picture_plus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_plus.TabIndex = 37;
            this.picture_plus.TabStop = false;
            // 
            // picture_main
            // 
            this.picture_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.picture_main.Image = global::SpeCon01.Properties.Resources.main;
            this.picture_main.Location = new System.Drawing.Point(140, 189);
            this.picture_main.Margin = new System.Windows.Forms.Padding(4);
            this.picture_main.Name = "picture_main";
            this.picture_main.Size = new System.Drawing.Size(46, 41);
            this.picture_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_main.TabIndex = 32;
            this.picture_main.TabStop = false;
            // 
            // picture_rev
            // 
            this.picture_rev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.picture_rev.Image = global::SpeCon01.Properties.Resources.rev;
            this.picture_rev.Location = new System.Drawing.Point(140, 257);
            this.picture_rev.Margin = new System.Windows.Forms.Padding(4);
            this.picture_rev.Name = "picture_rev";
            this.picture_rev.Size = new System.Drawing.Size(46, 41);
            this.picture_rev.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_rev.TabIndex = 31;
            this.picture_rev.TabStop = false;
            // 
            // pecture_out
            // 
            this.pecture_out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(147)))));
            this.pecture_out.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pecture_out.Image = global::SpeCon01.Properties.Resources._out;
            this.pecture_out.Location = new System.Drawing.Point(97, 495);
            this.pecture_out.Margin = new System.Windows.Forms.Padding(4);
            this.pecture_out.Name = "pecture_out";
            this.pecture_out.Size = new System.Drawing.Size(57, 46);
            this.pecture_out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pecture_out.TabIndex = 30;
            this.pecture_out.TabStop = false;
            this.pecture_out.Click += new System.EventHandler(this.pecture_out_Click);
            // 
            // picture_exp
            // 
            this.picture_exp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.picture_exp.Image = global::SpeCon01.Properties.Resources.exp;
            this.picture_exp.Location = new System.Drawing.Point(140, 323);
            this.picture_exp.Margin = new System.Windows.Forms.Padding(4);
            this.picture_exp.Name = "picture_exp";
            this.picture_exp.Size = new System.Drawing.Size(46, 41);
            this.picture_exp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_exp.TabIndex = 29;
            this.picture_exp.TabStop = false;
            // 
            // log_out_btn
            // 
            this.log_out_btn.AutoSize = true;
            this.log_out_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(147)))));
            this.log_out_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_out_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_out_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.log_out_btn.Location = new System.Drawing.Point(23, 504);
            this.log_out_btn.Name = "log_out_btn";
            this.log_out_btn.Size = new System.Drawing.Size(76, 28);
            this.log_out_btn.TabIndex = 26;
            this.log_out_btn.Text = "Выход";
            this.log_out_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.log_out_btn.Click += new System.EventHandler(this.log_out_Click);
            this.log_out_btn.MouseEnter += new System.EventHandler(this.log_out_MouseEnter);
            this.log_out_btn.MouseLeave += new System.EventHandler(this.log_out_MouseLeave);
            // 
            // main_btn
            // 
            this.main_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.main_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.main_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(70)))));
            this.main_btn.FlatAppearance.BorderSize = 0;
            this.main_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.main_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.main_btn.Location = new System.Drawing.Point(0, 189);
            this.main_btn.Margin = new System.Windows.Forms.Padding(4);
            this.main_btn.Name = "main_btn";
            this.main_btn.Size = new System.Drawing.Size(186, 41);
            this.main_btn.TabIndex = 25;
            this.main_btn.Text = "Главная";
            this.main_btn.UseVisualStyleBackColor = false;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(147)))));
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.name_label.Location = new System.Drawing.Point(53, 113);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(77, 38);
            this.name_label.TabIndex = 24;
            this.name_label.Text = "Имя";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(147)))));
            this.avatar.Image = global::SpeCon01.Properties.Resources.avatar;
            this.avatar.Location = new System.Drawing.Point(50, 35);
            this.avatar.Margin = new System.Windows.Forms.Padding(4);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(80, 74);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 23;
            this.avatar.TabStop = false;
            // 
            // av_panel
            // 
            this.av_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(147)))));
            this.av_panel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.av_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.av_panel.Location = new System.Drawing.Point(0, 0);
            this.av_panel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.av_panel.Name = "av_panel";
            this.av_panel.Size = new System.Drawing.Size(186, 144);
            this.av_panel.TabIndex = 22;
            this.av_panel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.av_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.av_panel_MouseDown);
            this.av_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.av_panel_MouseMove);
            // 
            // exp_btn
            // 
            this.exp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.exp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exp_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(70)))));
            this.exp_btn.FlatAppearance.BorderSize = 0;
            this.exp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exp_btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exp_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.exp_btn.Image = global::SpeCon01.Properties.Resources.avatar;
            this.exp_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exp_btn.Location = new System.Drawing.Point(0, 323);
            this.exp_btn.Margin = new System.Windows.Forms.Padding(4);
            this.exp_btn.Name = "exp_btn";
            this.exp_btn.Size = new System.Drawing.Size(186, 41);
            this.exp_btn.TabIndex = 20;
            this.exp_btn.Text = "Расходы";
            this.exp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exp_btn.UseVisualStyleBackColor = false;
            this.exp_btn.Click += new System.EventHandler(this.exp_summ_main_Click);
            // 
            // rev_btn
            // 
            this.rev_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.rev_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rev_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(89)))), ((int)(((byte)(70)))));
            this.rev_btn.FlatAppearance.BorderSize = 0;
            this.rev_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rev_btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rev_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.rev_btn.Location = new System.Drawing.Point(0, 257);
            this.rev_btn.Margin = new System.Windows.Forms.Padding(4);
            this.rev_btn.Name = "rev_btn";
            this.rev_btn.Size = new System.Drawing.Size(186, 41);
            this.rev_btn.TabIndex = 19;
            this.rev_btn.Text = "Доходы";
            this.rev_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rev_btn.UseVisualStyleBackColor = false;
            this.rev_btn.Click += new System.EventHandler(this.rev_summ_main_Click_1);
            // 
            // dash_panel
            // 
            this.dash_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(147)))));
            this.dash_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dash_panel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dash_panel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.dash_panel.Location = new System.Drawing.Point(0, 0);
            this.dash_panel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dash_panel.Name = "dash_panel";
            this.dash_panel.Size = new System.Drawing.Size(186, 554);
            this.dash_panel.TabIndex = 18;
            this.dash_panel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dash_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dash_panel_MouseDown);
            this.dash_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dash_panel_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.time_panel.ResumeLayout(false);
            this.time_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.exp_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_exp_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_minus)).EndInit();
            this.rev_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_rev_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_rev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pecture_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_exp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label dash_panel;
        private System.Windows.Forms.Button rev_btn;
        private System.Windows.Forms.Button exp_btn;
        private System.Windows.Forms.Label av_panel;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Button main_btn;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label log_out_btn;
        private System.Windows.Forms.PictureBox pecture_out;
        private System.Windows.Forms.PictureBox picture_exp;
        private System.Windows.Forms.PictureBox picture_main;
        private System.Windows.Forms.PictureBox picture_rev;
        private System.Windows.Forms.Panel chart1_panel;
        private System.Windows.Forms.Panel chart2_panel;
        private System.Windows.Forms.Panel rev_panel;
        private System.Windows.Forms.PictureBox picture_plus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView_rev_main;
        private System.Windows.Forms.Label rev_summ_main;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label date_lbl;
        private System.Windows.Forms.Label exp_summ_main;
        private System.Windows.Forms.PictureBox picture_minus;
        private System.Windows.Forms.Panel time_panel;
        private System.Windows.Forms.Panel exp_panel;
        private System.Windows.Forms.DataGridView dataGridView_exp_main;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label result_main;
    }
}