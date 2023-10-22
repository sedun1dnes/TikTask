namespace TikTask
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.projectFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.createProjectButtonFirst = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginLabelMain = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userAccountButton = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.taskPanel = new System.Windows.Forms.Panel();
            this.tasksFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.taskLabel = new System.Windows.Forms.Label();
            this.tasksPic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.taskPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.greetingLabel);
            this.panel1.Controls.Add(this.taskPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.panel3.Controls.Add(this.projectFlowLayout);
            this.panel3.Controls.Add(this.createProjectButtonFirst);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(21, 223);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(372, 211);
            this.panel3.TabIndex = 2;
            // 
            // projectFlowLayout
            // 
            this.projectFlowLayout.AutoScroll = true;
            this.projectFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.projectFlowLayout.Location = new System.Drawing.Point(10, 50);
            this.projectFlowLayout.Name = "projectFlowLayout";
            this.projectFlowLayout.Size = new System.Drawing.Size(350, 150);
            this.projectFlowLayout.TabIndex = 11;
            this.projectFlowLayout.WrapContents = false;
            // 
            // createProjectButtonFirst
            // 
            this.createProjectButtonFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(151)))), ((int)(((byte)(139)))));
            this.createProjectButtonFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createProjectButtonFirst.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createProjectButtonFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.createProjectButtonFirst.Location = new System.Drawing.Point(222, 11);
            this.createProjectButtonFirst.Name = "createProjectButtonFirst";
            this.createProjectButtonFirst.Size = new System.Drawing.Size(136, 33);
            this.createProjectButtonFirst.TabIndex = 10;
            this.createProjectButtonFirst.Text = "+ Создать проект";
            this.createProjectButtonFirst.UseVisualStyleBackColor = false;
            this.createProjectButtonFirst.Click += new System.EventHandler(this.createProjectButtonFirst_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TikTask.Properties.Resources.project_48;
            this.pictureBox2.Location = new System.Drawing.Point(9, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(44, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Мои проекты";
            // 
            // dataLabel
            // 
            this.dataLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(102)))), ((int)(((byte)(93)))));
            this.dataLabel.Location = new System.Drawing.Point(0, 122);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(800, 29);
            this.dataLabel.TabIndex = 1;
            this.dataLabel.Text = "Вторник, 30 февраля";
            this.dataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(151)))), ((int)(((byte)(139)))));
            this.panel2.Controls.Add(this.loginLabelMain);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.userAccountButton);
            this.panel2.Controls.Add(this.topPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 94);
            this.panel2.TabIndex = 0;
            // 
            // loginLabelMain
            // 
            this.loginLabelMain.AutoSize = true;
            this.loginLabelMain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabelMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(221)))), ((int)(((byte)(213)))));
            this.loginLabelMain.Location = new System.Drawing.Point(68, 44);
            this.loginLabelMain.Name = "loginLabelMain";
            this.loginLabelMain.Size = new System.Drawing.Size(51, 19);
            this.loginLabelMain.TabIndex = 4;
            this.loginLabelMain.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TikTask.Properties.Resources.user_dark_48;
            this.pictureBox1.Location = new System.Drawing.Point(17, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // userAccountButton
            // 
            this.userAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userAccountButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.userAccountButton.Location = new System.Drawing.Point(30, 60);
            this.userAccountButton.Name = "userAccountButton";
            this.userAccountButton.Size = new System.Drawing.Size(183, 25);
            this.userAccountButton.TabIndex = 2;
            this.userAccountButton.Text = "Личный кабинет";
            this.userAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userAccountButton.Click += new System.EventHandler(this.userAccountButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(102)))), ((int)(((byte)(93)))));
            this.topPanel.Controls.Add(this.pictureBox4);
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(800, 31);
            this.topPanel.TabIndex = 2;
            this.topPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseClick);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
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
            this.pictureBox4.Click += new System.EventHandler(this.minimizeButton_Click);
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
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // greetingLabel
            // 
            this.greetingLabel.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greetingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.greetingLabel.Location = new System.Drawing.Point(3, 141);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(797, 51);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Доброе утро, Марина";
            this.greetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskPanel
            // 
            this.taskPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.taskPanel.Controls.Add(this.tasksFlowLayoutPanel);
            this.taskPanel.Controls.Add(this.taskLabel);
            this.taskPanel.Controls.Add(this.tasksPic);
            this.taskPanel.Location = new System.Drawing.Point(408, 223);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(369, 211);
            this.taskPanel.TabIndex = 3;
            // 
            // tasksFlowLayoutPanel
            // 
            this.tasksFlowLayoutPanel.AutoScroll = true;
            this.tasksFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.tasksFlowLayoutPanel.Location = new System.Drawing.Point(11, 50);
            this.tasksFlowLayoutPanel.Name = "tasksFlowLayoutPanel";
            this.tasksFlowLayoutPanel.Size = new System.Drawing.Size(350, 150);
            this.tasksFlowLayoutPanel.TabIndex = 12;
            this.tasksFlowLayoutPanel.WrapContents = false;
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.taskLabel.Location = new System.Drawing.Point(44, 10);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(157, 30);
            this.taskLabel.TabIndex = 11;
            this.taskLabel.Text = "Мои задачи";
            // 
            // tasksPic
            // 
            this.tasksPic.Image = global::TikTask.Properties.Resources.tasks_dark_48;
            this.tasksPic.Location = new System.Drawing.Point(9, 12);
            this.tasksPic.Name = "tasksPic";
            this.tasksPic.Size = new System.Drawing.Size(32, 32);
            this.tasksPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tasksPic.TabIndex = 7;
            this.tasksPic.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.taskPanel.ResumeLayout(false);
            this.taskPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tasksPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label loginLabelMain;
        private System.Windows.Forms.Label userAccountButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel taskPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox tasksPic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createProjectButtonFirst;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.FlowLayoutPanel projectFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel tasksFlowLayoutPanel;
    }
}