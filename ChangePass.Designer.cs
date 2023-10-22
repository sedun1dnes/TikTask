namespace TikTask
{
    partial class ChangePass
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
            this.label1 = new System.Windows.Forms.Label();
            this.oldPassField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newPassField1 = new System.Windows.Forms.TextBox();
            this.newPassField2 = new System.Windows.Forms.TextBox();
            this.changePassButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(73, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Старый пароль";
            // 
            // oldPassField
            // 
            this.oldPassField.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPassField.Location = new System.Drawing.Point(188, 31);
            this.oldPassField.Name = "oldPassField";
            this.oldPassField.Size = new System.Drawing.Size(169, 23);
            this.oldPassField.TabIndex = 23;
            this.oldPassField.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Повторите новый пароль";
            // 
            // newPassField1
            // 
            this.newPassField1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPassField1.Location = new System.Drawing.Point(188, 72);
            this.newPassField1.Name = "newPassField1";
            this.newPassField1.Size = new System.Drawing.Size(169, 23);
            this.newPassField1.TabIndex = 26;
            this.newPassField1.UseSystemPasswordChar = true;
            // 
            // newPassField2
            // 
            this.newPassField2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPassField2.Location = new System.Drawing.Point(188, 112);
            this.newPassField2.Name = "newPassField2";
            this.newPassField2.Size = new System.Drawing.Size(169, 23);
            this.newPassField2.TabIndex = 27;
            this.newPassField2.UseSystemPasswordChar = true;
            // 
            // changePassButton
            // 
            this.changePassButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePassButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePassButton.Location = new System.Drawing.Point(141, 152);
            this.changePassButton.Name = "changePassButton";
            this.changePassButton.Size = new System.Drawing.Size(105, 25);
            this.changePassButton.TabIndex = 28;
            this.changePassButton.Text = "Изменить";
            this.changePassButton.UseVisualStyleBackColor = true;
            this.changePassButton.Click += new System.EventHandler(this.changePassButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::TikTask.Properties.Resources.closeLight32;
            this.closeButton.Location = new System.Drawing.Point(364, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(19, 19);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 29;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(102)))), ((int)(((byte)(93)))));
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(383, 20);
            this.topPanel.TabIndex = 30;
            this.topPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseClick);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // ChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 187);
            this.Controls.Add(this.changePassButton);
            this.Controls.Add(this.newPassField2);
            this.Controls.Add(this.newPassField1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldPassField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChangePass";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox oldPassField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newPassField1;
        private System.Windows.Forms.TextBox newPassField2;
        private System.Windows.Forms.Button changePassButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel topPanel;
    }
}