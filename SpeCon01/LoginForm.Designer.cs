
namespace SpeCon01
{
    partial class LoginForm
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
            this.login_btn = new System.Windows.Forms.PictureBox();
            this.reg_btn = new System.Windows.Forms.Label();
            this.passField = new System.Windows.Forms.TextBox();
            this.picture_pass = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.picture_name = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.TopPanel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_name)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.MainPanel.Controls.Add(this.login_btn);
            this.MainPanel.Controls.Add(this.reg_btn);
            this.MainPanel.Controls.Add(this.passField);
            this.MainPanel.Controls.Add(this.picture_pass);
            this.MainPanel.Controls.Add(this.loginField);
            this.MainPanel.Controls.Add(this.picture_name);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(596, 599);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // login_btn
            // 
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.Image = global::SpeCon01.Properties.Resources.enter;
            this.login_btn.Location = new System.Drawing.Point(336, 426);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(183, 74);
            this.login_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.login_btn.TabIndex = 6;
            this.login_btn.TabStop = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // reg_btn
            // 
            this.reg_btn.AutoSize = true;
            this.reg_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reg_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.reg_btn.Location = new System.Drawing.Point(164, 548);
            this.reg_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(109, 23);
            this.reg_btn.TabIndex = 5;
            this.reg_btn.Text = "Регистрация";
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            this.reg_btn.MouseEnter += new System.EventHandler(this.RegButton_MouseEnter);
            this.reg_btn.MouseLeave += new System.EventHandler(this.RegButton_MouseLeave);
            // 
            // passField
            // 
            this.passField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.passField.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.passField.Location = new System.Drawing.Point(169, 334);
            this.passField.Margin = new System.Windows.Forms.Padding(4);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(351, 52);
            this.passField.TabIndex = 2;
            this.passField.UseSystemPasswordChar = true;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.passField_Leave);
            // 
            // picture_pass
            // 
            this.picture_pass.Image = global::SpeCon01.Properties.Resources.password;
            this.picture_pass.Location = new System.Drawing.Point(80, 323);
            this.picture_pass.Margin = new System.Windows.Forms.Padding(4);
            this.picture_pass.Name = "picture_pass";
            this.picture_pass.Size = new System.Drawing.Size(80, 74);
            this.picture_pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_pass.TabIndex = 3;
            this.picture_pass.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(223)))), ((int)(((byte)(242)))));
            this.loginField.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(76)))));
            this.loginField.Location = new System.Drawing.Point(168, 234);
            this.loginField.Margin = new System.Windows.Forms.Padding(4);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(351, 52);
            this.loginField.TabIndex = 1;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.loginField_Leave);
            // 
            // picture_name
            // 
            this.picture_name.Image = global::SpeCon01.Properties.Resources.user;
            this.picture_name.Location = new System.Drawing.Point(80, 222);
            this.picture_name.Margin = new System.Windows.Forms.Padding(4);
            this.picture_name.Name = "picture_name";
            this.picture_name.Size = new System.Drawing.Size(80, 74);
            this.picture_name.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_name.TabIndex = 1;
            this.picture_name.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(136)))), ((int)(((byte)(147)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.TopPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 123);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(247)))));
            this.closeButton.Location = new System.Drawing.Point(569, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Х";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // TopPanel
            // 
            this.TopPanel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(43)))), ((int)(((byte)(77)))));
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(596, 123);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.Text = "SpeCon";
            this.TopPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 599);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.login_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_name)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label TopPanel;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox picture_pass;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox picture_name;
        private System.Windows.Forms.Label reg_btn;
        private System.Windows.Forms.PictureBox login_btn;
    }
}