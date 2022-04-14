
namespace SpeCon01
{
    partial class RevTable
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.back_pic = new System.Windows.Forms.PictureBox();
            this.summBox = new System.Windows.Forms.MaskedTextBox();
            this.refresh = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Label();
            this.rev_del_btn = new System.Windows.Forms.Button();
            this.rev_update_btn = new System.Windows.Forms.Button();
            this.rev_add_btn = new System.Windows.Forms.Button();
            this.dateBox = new System.Windows.Forms.MaskedTextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.articleBox = new System.Windows.Forms.TextBox();
            this.revenue_table = new System.Windows.Forms.DataGridView();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenue_table)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.MainPanel.Controls.Add(this.back_pic);
            this.MainPanel.Controls.Add(this.summBox);
            this.MainPanel.Controls.Add(this.refresh);
            this.MainPanel.Controls.Add(this.closeButton);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Controls.Add(this.rev_del_btn);
            this.MainPanel.Controls.Add(this.rev_update_btn);
            this.MainPanel.Controls.Add(this.rev_add_btn);
            this.MainPanel.Controls.Add(this.dateBox);
            this.MainPanel.Controls.Add(this.titleBox);
            this.MainPanel.Controls.Add(this.articleBox);
            this.MainPanel.Controls.Add(this.revenue_table);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1067, 554);
            this.MainPanel.TabIndex = 2;
            // 
            // back_pic
            // 
            this.back_pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(147)))));
            this.back_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_pic.Image = global::SpeCon01.Properties.Resources.backpic;
            this.back_pic.Location = new System.Drawing.Point(987, 49);
            this.back_pic.Margin = new System.Windows.Forms.Padding(4);
            this.back_pic.Name = "back_pic";
            this.back_pic.Size = new System.Drawing.Size(80, 74);
            this.back_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back_pic.TabIndex = 40;
            this.back_pic.TabStop = false;
            this.back_pic.Click += new System.EventHandler(this.back_pic_Click);
            // 
            // summBox
            // 
            this.summBox.Location = new System.Drawing.Point(313, 171);
            this.summBox.Margin = new System.Windows.Forms.Padding(4);
            this.summBox.Name = "summBox";
            this.summBox.Size = new System.Drawing.Size(119, 22);
            this.summBox.TabIndex = 19;
            this.summBox.Enter += new System.EventHandler(this.summBox_Enter_1);
            this.summBox.Leave += new System.EventHandler(this.summBox_Leave);
            // 
            // refresh
            // 
            this.refresh.AutoSize = true;
            this.refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.refresh.Location = new System.Drawing.Point(4, 123);
            this.refresh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(88, 23);
            this.refresh.TabIndex = 18;
            this.refresh.Text = "Обновить";
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(147)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.closeButton.Location = new System.Drawing.Point(1040, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 23);
            this.closeButton.TabIndex = 17;
            this.closeButton.Text = "Х";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            this.closeButton.MouseHover += new System.EventHandler(this.closeButton_MouseHover);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(147)))));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1067, 123);
            this.TopPanel.TabIndex = 16;
            this.TopPanel.Text = "Доходы";
            this.TopPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // rev_del_btn
            // 
            this.rev_del_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rev_del_btn.Location = new System.Drawing.Point(699, 489);
            this.rev_del_btn.Margin = new System.Windows.Forms.Padding(4);
            this.rev_del_btn.Name = "rev_del_btn";
            this.rev_del_btn.Size = new System.Drawing.Size(100, 28);
            this.rev_del_btn.TabIndex = 15;
            this.rev_del_btn.Text = "Удалить";
            this.rev_del_btn.UseVisualStyleBackColor = true;
            this.rev_del_btn.Click += new System.EventHandler(this.rev_del_btn_Click);
            // 
            // rev_update_btn
            // 
            this.rev_update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rev_update_btn.Location = new System.Drawing.Point(699, 453);
            this.rev_update_btn.Margin = new System.Windows.Forms.Padding(4);
            this.rev_update_btn.Name = "rev_update_btn";
            this.rev_update_btn.Size = new System.Drawing.Size(100, 28);
            this.rev_update_btn.TabIndex = 14;
            this.rev_update_btn.Text = "Изменить";
            this.rev_update_btn.UseVisualStyleBackColor = true;
            this.rev_update_btn.Click += new System.EventHandler(this.rev_update_btn_Click);
            // 
            // rev_add_btn
            // 
            this.rev_add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rev_add_btn.Location = new System.Drawing.Point(591, 171);
            this.rev_add_btn.Margin = new System.Windows.Forms.Padding(4);
            this.rev_add_btn.Name = "rev_add_btn";
            this.rev_add_btn.Size = new System.Drawing.Size(100, 28);
            this.rev_add_btn.TabIndex = 13;
            this.rev_add_btn.Text = "Добавить";
            this.rev_add_btn.UseVisualStyleBackColor = true;
            this.rev_add_btn.Click += new System.EventHandler(this.rev_add_btn_Click);
            // 
            // dateBox
            // 
            this.dateBox.Location = new System.Drawing.Point(441, 171);
            this.dateBox.Margin = new System.Windows.Forms.Padding(4);
            this.dateBox.Mask = "0000/00/00";
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(119, 22);
            this.dateBox.TabIndex = 12;
            this.dateBox.ValidatingType = typeof(System.DateTime);
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(185, 171);
            this.titleBox.Margin = new System.Windows.Forms.Padding(4);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(119, 22);
            this.titleBox.TabIndex = 10;
            this.titleBox.Enter += new System.EventHandler(this.titleBox_Enter);
            this.titleBox.Leave += new System.EventHandler(this.titleBox_Leave);
            // 
            // articleBox
            // 
            this.articleBox.Location = new System.Drawing.Point(57, 171);
            this.articleBox.Margin = new System.Windows.Forms.Padding(4);
            this.articleBox.Name = "articleBox";
            this.articleBox.Size = new System.Drawing.Size(119, 22);
            this.articleBox.TabIndex = 9;
            this.articleBox.Enter += new System.EventHandler(this.articleBox_Enter);
            this.articleBox.Leave += new System.EventHandler(this.articleBox_Leave);
            // 
            // revenue_table
            // 
            this.revenue_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.revenue_table.Location = new System.Drawing.Point(57, 226);
            this.revenue_table.Margin = new System.Windows.Forms.Padding(4);
            this.revenue_table.Name = "revenue_table";
            this.revenue_table.RowHeadersWidth = 51;
            this.revenue_table.Size = new System.Drawing.Size(633, 290);
            this.revenue_table.TabIndex = 8;
            this.revenue_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.revenue_table_CellClick);
            // 
            // RevTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RevTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevTable";
            this.Load += new System.EventHandler(this.RevTable_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.back_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenue_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.DataGridView revenue_table;
        private System.Windows.Forms.Button rev_del_btn;
        private System.Windows.Forms.Button rev_update_btn;
        private System.Windows.Forms.Button rev_add_btn;
        private System.Windows.Forms.MaskedTextBox dateBox;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox articleBox;
        private System.Windows.Forms.Label TopPanel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label refresh;
        private System.Windows.Forms.MaskedTextBox summBox;
        private System.Windows.Forms.PictureBox back_pic;
    }
}