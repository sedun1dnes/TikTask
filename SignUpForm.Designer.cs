namespace TikTask
{
    partial class SignUpForm
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.Авторизация = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameField_SA = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.backToLoginButton = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mailField_SA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.passField_SA = new System.Windows.Forms.TextBox();
            this.loginField_SA = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.surnameField_SA = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(138)))), ((int)(((byte)(88)))));
            this.topPanel.Controls.Add(this.pictureBox4);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(533, 31);
            this.topPanel.TabIndex = 2;
            this.topPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseClick);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::TikTask.Properties.Resources.collapse_light_64;
            this.pictureBox4.Location = new System.Drawing.Point(468, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::TikTask.Properties.Resources.close_light_64;
            this.closeButton.Location = new System.Drawing.Point(500, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Авторизация
            // 
            this.Авторизация.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Авторизация.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(86)))), ((int)(((byte)(48)))));
            this.Авторизация.Location = new System.Drawing.Point(0, 35);
            this.Авторизация.Name = "Авторизация";
            this.Авторизация.Size = new System.Drawing.Size(533, 51);
            this.Авторизация.TabIndex = 0;
            this.Авторизация.Text = "Регистрация\r\n";
            this.Авторизация.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(180)))), ((int)(((byte)(109)))));
            this.panel2.Controls.Add(this.topPanel);
            this.panel2.Controls.Add(this.Авторизация);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 86);
            this.panel2.TabIndex = 0;
            // 
            // nameField_SA
            // 
            this.nameField_SA.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameField_SA.Location = new System.Drawing.Point(137, 100);
            this.nameField_SA.Name = "nameField_SA";
            this.nameField_SA.Size = new System.Drawing.Size(305, 33);
            this.nameField_SA.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(209)))), ((int)(((byte)(158)))));
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.backToLoginButton);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.mailField_SA);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.passField_SA);
            this.panel1.Controls.Add(this.loginField_SA);
            this.panel1.Controls.Add(this.Register);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.surnameField_SA);
            this.panel1.Controls.Add(this.nameField_SA);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 450);
            this.panel1.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(446, 273);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "*";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(446, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backToLoginButton
            // 
            this.backToLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToLoginButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backToLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(86)))), ((int)(((byte)(48)))));
            this.backToLoginButton.Location = new System.Drawing.Point(0, 404);
            this.backToLoginButton.Name = "backToLoginButton";
            this.backToLoginButton.Size = new System.Drawing.Size(533, 37);
            this.backToLoginButton.TabIndex = 18;
            this.backToLoginButton.Text = "Назад к авторизации\r\n";
            this.backToLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backToLoginButton.Click += new System.EventHandler(this.backToLoginButton_Click);
            // 
            // label9
            // 
            this.label9.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(147, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "*";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(446, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(86)))), ((int)(((byte)(48)))));
            this.label6.Location = new System.Drawing.Point(64, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Почта:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mailField_SA
            // 
            this.mailField_SA.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailField_SA.Location = new System.Drawing.Point(137, 273);
            this.mailField_SA.Name = "mailField_SA";
            this.mailField_SA.Size = new System.Drawing.Size(305, 33);
            this.mailField_SA.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(86)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(60, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Пароль:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(86)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(72, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 37);
            this.label4.TabIndex = 11;
            this.label4.Text = "Логин:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(86)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(88, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Имя:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(86)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(51, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фамилия:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passField_SA
            // 
            this.passField_SA.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField_SA.Location = new System.Drawing.Point(137, 229);
            this.passField_SA.Name = "passField_SA";
            this.passField_SA.Size = new System.Drawing.Size(305, 33);
            this.passField_SA.TabIndex = 8;
            // 
            // loginField_SA
            // 
            this.loginField_SA.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField_SA.Location = new System.Drawing.Point(137, 186);
            this.loginField_SA.Name = "loginField_SA";
            this.loginField_SA.Size = new System.Drawing.Size(305, 33);
            this.loginField_SA.TabIndex = 7;
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(180)))), ((int)(((byte)(109)))));
            this.Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(86)))), ((int)(((byte)(48)))));
            this.Register.Location = new System.Drawing.Point(108, 352);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(322, 49);
            this.Register.TabIndex = 6;
            this.Register.Text = "Зарегистрироваться";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(86)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(67, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(458, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Поля обязательные для заполнения";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // surnameField_SA
            // 
            this.surnameField_SA.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameField_SA.Location = new System.Drawing.Point(137, 143);
            this.surnameField_SA.Name = "surnameField_SA";
            this.surnameField_SA.Size = new System.Drawing.Size(305, 33);
            this.surnameField_SA.TabIndex = 4;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label Авторизация;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nameField_SA;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox surnameField_SA;
        private System.Windows.Forms.TextBox passField_SA;
        private System.Windows.Forms.TextBox loginField_SA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mailField_SA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label backToLoginButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
    }
}