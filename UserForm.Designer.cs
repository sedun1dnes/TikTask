namespace TikTask
{
    partial class UserForm
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
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.surnamePanel = new System.Windows.Forms.Panel();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.loginLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mailLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Label();
            this.notifFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.namePanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.endSessionButton = new System.Windows.Forms.Label();
            this.editSurnameButton = new System.Windows.Forms.PictureBox();
            this.editNameButton = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel2.SuspendLayout();
            this.surnamePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.namePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editSurnameButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNameButton)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(102)))), ((int)(((byte)(93)))));
            this.topPanel.Controls.Add(this.homeButton);
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.pictureBox4);
            this.topPanel.Controls.Add(this.pictureBox3);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(384, 31);
            this.topPanel.TabIndex = 2;
            this.topPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseClick);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // homeButton
            // 
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Image = global::TikTask.Properties.Resources._8677983_home_line_house_icon;
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(32, 32);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeButton.TabIndex = 35;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TikTask.Properties.Resources.collapse_light_64;
            this.pictureBox1.Location = new System.Drawing.Point(321, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::TikTask.Properties.Resources.collapse_light_64;
            this.pictureBox4.Location = new System.Drawing.Point(737, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::TikTask.Properties.Resources.close_light_64;
            this.pictureBox3.Location = new System.Drawing.Point(352, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::TikTask.Properties.Resources.close_light_64;
            this.closeButton.Location = new System.Drawing.Point(768, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 0;
            this.closeButton.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(151)))), ((int)(((byte)(139)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.topPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(384, 79);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.label6.Location = new System.Drawing.Point(3, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 34);
            this.label6.TabIndex = 3;
            this.label6.Text = "Личный кабинет";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(41, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Почта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // surnamePanel
            // 
            this.surnamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.surnamePanel.Controls.Add(this.surnameLabel);
            this.surnamePanel.Location = new System.Drawing.Point(89, 238);
            this.surnamePanel.Name = "surnamePanel";
            this.surnamePanel.Size = new System.Drawing.Size(236, 24);
            this.surnamePanel.TabIndex = 21;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(4, 3);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(12, 17);
            this.surnameLabel.TabIndex = 4;
            this.surnameLabel.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(52, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(19, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Фамилия";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel4.Controls.Add(this.loginLabel);
            this.panel4.Location = new System.Drawing.Point(89, 277);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 24);
            this.panel4.TabIndex = 21;
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(4, 4);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(43, 17);
            this.loginLabel.TabIndex = 5;
            this.loginLabel.Text = "Login";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel5.Controls.Add(this.mailLabel);
            this.panel5.Location = new System.Drawing.Point(89, 320);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 24);
            this.panel5.TabIndex = 22;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mailLabel.Location = new System.Drawing.Point(4, 3);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(34, 17);
            this.mailLabel.TabIndex = 6;
            this.mailLabel.Text = "Mail";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.AutoSize = true;
            this.changePasswordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePasswordButton.Location = new System.Drawing.Point(141, 367);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(122, 17);
            this.changePasswordButton.TabIndex = 32;
            this.changePasswordButton.Text = "Изменить пароль";
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // notifFlowLayout
            // 
            this.notifFlowLayout.AutoScroll = true;
            this.notifFlowLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.notifFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.notifFlowLayout.Location = new System.Drawing.Point(12, 113);
            this.notifFlowLayout.Name = "notifFlowLayout";
            this.notifFlowLayout.Size = new System.Drawing.Size(360, 58);
            this.notifFlowLayout.TabIndex = 33;
            this.notifFlowLayout.WrapContents = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(152, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Уведомления";
            // 
            // namePanel
            // 
            this.namePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.namePanel.Controls.Add(this.nameLabel);
            this.namePanel.Location = new System.Drawing.Point(89, 194);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(236, 24);
            this.namePanel.TabIndex = 22;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(4, 3);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(12, 17);
            this.nameLabel.TabIndex = 4;
            this.nameLabel.Text = "-";
            // 
            // endSessionButton
            // 
            this.endSessionButton.AutoSize = true;
            this.endSessionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endSessionButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endSessionButton.ForeColor = System.Drawing.Color.Firebrick;
            this.endSessionButton.Location = new System.Drawing.Point(335, 405);
            this.endSessionButton.Name = "endSessionButton";
            this.endSessionButton.Size = new System.Drawing.Size(48, 16);
            this.endSessionButton.TabIndex = 35;
            this.endSessionButton.Text = "Выйти";
            this.endSessionButton.Click += new System.EventHandler(this.endSessionButton_Click);
            // 
            // editSurnameButton
            // 
            this.editSurnameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editSurnameButton.Image = global::TikTask.Properties.Resources.editLight32;
            this.editSurnameButton.Location = new System.Drawing.Point(331, 238);
            this.editSurnameButton.Name = "editSurnameButton";
            this.editSurnameButton.Size = new System.Drawing.Size(24, 24);
            this.editSurnameButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editSurnameButton.TabIndex = 27;
            this.editSurnameButton.TabStop = false;
            this.editSurnameButton.Click += new System.EventHandler(this.editSurnameButton_Click);
            this.editSurnameButton.MouseEnter += new System.EventHandler(this.editSurnameButton_MouseEnter);
            this.editSurnameButton.MouseLeave += new System.EventHandler(this.editSurnameButton_MouseLeave);
            // 
            // editNameButton
            // 
            this.editNameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editNameButton.Image = global::TikTask.Properties.Resources.editLight32;
            this.editNameButton.Location = new System.Drawing.Point(331, 194);
            this.editNameButton.Name = "editNameButton";
            this.editNameButton.Size = new System.Drawing.Size(24, 24);
            this.editNameButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editNameButton.TabIndex = 26;
            this.editNameButton.TabStop = false;
            this.editNameButton.Click += new System.EventHandler(this.editNameButton_Click);
            this.editNameButton.MouseEnter += new System.EventHandler(this.editNameButton_MouseEnter);
            this.editNameButton.MouseLeave += new System.EventHandler(this.editNameButton_MouseLeave);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 425);
            this.Controls.Add(this.endSessionButton);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.notifFlowLayout);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editSurnameButton);
            this.Controls.Add(this.editNameButton);
            this.Controls.Add(this.surnamePanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserForm";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel2.ResumeLayout(false);
            this.surnamePanel.ResumeLayout(false);
            this.surnamePanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editSurnameButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editNameButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel surnamePanel;
        private System.Windows.Forms.PictureBox editNameButton;
        private System.Windows.Forms.PictureBox editSurnameButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label changePasswordButton;
        private System.Windows.Forms.FlowLayoutPanel notifFlowLayout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.Label endSessionButton;
    }
}