namespace TikTask
{
    partial class ProjectForm
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.projectPanel = new System.Windows.Forms.Panel();
            this.editProjectButton = new System.Windows.Forms.PictureBox();
            this.deleteProjectButton = new System.Windows.Forms.PictureBox();
            this.inviteUserButton = new System.Windows.Forms.PictureBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.visualTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.stagesPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addStageButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.taskDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dayTaskFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.zeroTaskLabel = new System.Windows.Forms.Label();
            this.noDeadlineTasksLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tasksFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tagsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.projectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editProjectButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteProjectButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteUserButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.visualTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.stagesPanel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.dayTaskFlowLayout.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(102)))), ((int)(((byte)(93)))));
            this.topPanel.Controls.Add(this.homeButton);
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
            // homeButton
            // 
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.Image = global::TikTask.Properties.Resources._8677983_home_line_house_icon;
            this.homeButton.Location = new System.Drawing.Point(0, -1);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(32, 32);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeButton.TabIndex = 4;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
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
            // projectPanel
            // 
            this.projectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(151)))), ((int)(((byte)(139)))));
            this.projectPanel.Controls.Add(this.editProjectButton);
            this.projectPanel.Controls.Add(this.deleteProjectButton);
            this.projectPanel.Controls.Add(this.inviteUserButton);
            this.projectPanel.Controls.Add(this.nameLabel);
            this.projectPanel.Controls.Add(this.topPanel);
            this.projectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectPanel.Location = new System.Drawing.Point(0, 0);
            this.projectPanel.Name = "projectPanel";
            this.projectPanel.Size = new System.Drawing.Size(800, 91);
            this.projectPanel.TabIndex = 0;
            // 
            // editProjectButton
            // 
            this.editProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editProjectButton.Image = global::TikTask.Properties.Resources.editLight32;
            this.editProjectButton.Location = new System.Drawing.Point(688, 42);
            this.editProjectButton.Name = "editProjectButton";
            this.editProjectButton.Size = new System.Drawing.Size(28, 28);
            this.editProjectButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editProjectButton.TabIndex = 7;
            this.editProjectButton.TabStop = false;
            this.editProjectButton.Click += new System.EventHandler(this.editProjectButton_Click);
            this.editProjectButton.MouseEnter += new System.EventHandler(this.editProjectButton_MouseEnter);
            this.editProjectButton.MouseLeave += new System.EventHandler(this.editProjectButton_MouseLeave);
            // 
            // deleteProjectButton
            // 
            this.deleteProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProjectButton.Image = global::TikTask.Properties.Resources.deleteLight321;
            this.deleteProjectButton.Location = new System.Drawing.Point(760, 39);
            this.deleteProjectButton.Name = "deleteProjectButton";
            this.deleteProjectButton.Size = new System.Drawing.Size(32, 32);
            this.deleteProjectButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deleteProjectButton.TabIndex = 6;
            this.deleteProjectButton.TabStop = false;
            this.deleteProjectButton.Click += new System.EventHandler(this.deleteProjectButton_Click);
            this.deleteProjectButton.MouseEnter += new System.EventHandler(this.deleteProjectButton_MouseEnter);
            this.deleteProjectButton.MouseLeave += new System.EventHandler(this.deleteProjectButton_MouseLeave);
            // 
            // inviteUserButton
            // 
            this.inviteUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inviteUserButton.Image = global::TikTask.Properties.Resources.inviteLight;
            this.inviteUserButton.Location = new System.Drawing.Point(722, 39);
            this.inviteUserButton.Name = "inviteUserButton";
            this.inviteUserButton.Size = new System.Drawing.Size(32, 32);
            this.inviteUserButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inviteUserButton.TabIndex = 5;
            this.inviteUserButton.TabStop = false;
            this.inviteUserButton.Click += new System.EventHandler(this.inviteUserButton_Click);
            this.inviteUserButton.MouseEnter += new System.EventHandler(this.inviteUserButton_MouseEnter);
            this.inviteUserButton.MouseLeave += new System.EventHandler(this.inviteUserButton_MouseLeave);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(12, 36);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(192, 33);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "projectName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panel1.Controls.Add(this.visualTabs);
            this.panel1.Controls.Add(this.projectPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 600);
            this.panel1.TabIndex = 2;
            // 
            // visualTabs
            // 
            this.visualTabs.Controls.Add(this.tabPage1);
            this.visualTabs.Controls.Add(this.tabPage3);
            this.visualTabs.Controls.Add(this.tabPage4);
            this.visualTabs.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.visualTabs.Location = new System.Drawing.Point(3, 111);
            this.visualTabs.Name = "visualTabs";
            this.visualTabs.SelectedIndex = 0;
            this.visualTabs.Size = new System.Drawing.Size(797, 486);
            this.visualTabs.TabIndex = 1;
            this.visualTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.visualTabs_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.stagesPanel);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "       Доска Kanban       ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // stagesPanel
            // 
            this.stagesPanel.AutoScroll = true;
            this.stagesPanel.Controls.Add(this.addStageButton);
            this.stagesPanel.Location = new System.Drawing.Point(11, 28);
            this.stagesPanel.Name = "stagesPanel";
            this.stagesPanel.Size = new System.Drawing.Size(770, 418);
            this.stagesPanel.TabIndex = 0;
            this.stagesPanel.WrapContents = false;
            // 
            // addStageButton
            // 
            this.addStageButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addStageButton.Location = new System.Drawing.Point(3, 3);
            this.addStageButton.Name = "addStageButton";
            this.addStageButton.Size = new System.Drawing.Size(200, 30);
            this.addStageButton.TabIndex = 1;
            this.addStageButton.Text = "+ Добавить колонку";
            this.addStageButton.UseVisualStyleBackColor = true;
            this.addStageButton.Click += new System.EventHandler(this.addStageButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.taskDateLabel);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.dayTaskFlowLayout);
            this.tabPage3.Controls.Add(this.noDeadlineTasksLayout);
            this.tabPage3.Controls.Add(this.monthCalendar);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(789, 452);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "       Календарь       ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // taskDateLabel
            // 
            this.taskDateLabel.AutoSize = true;
            this.taskDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.taskDateLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.taskDateLabel.Location = new System.Drawing.Point(183, 20);
            this.taskDateLabel.Name = "taskDateLabel";
            this.taskDateLabel.Size = new System.Drawing.Size(92, 21);
            this.taskDateLabel.TabIndex = 3;
            this.taskDateLabel.Text = "Задачи на";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(483, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задачи с неустановленным сроком";
            // 
            // dayTaskFlowLayout
            // 
            this.dayTaskFlowLayout.Controls.Add(this.zeroTaskLabel);
            this.dayTaskFlowLayout.Location = new System.Drawing.Point(188, 46);
            this.dayTaskFlowLayout.Name = "dayTaskFlowLayout";
            this.dayTaskFlowLayout.Size = new System.Drawing.Size(285, 413);
            this.dayTaskFlowLayout.TabIndex = 1;
            // 
            // zeroTaskLabel
            // 
            this.zeroTaskLabel.AutoSize = true;
            this.zeroTaskLabel.Location = new System.Drawing.Point(3, 0);
            this.zeroTaskLabel.Name = "zeroTaskLabel";
            this.zeroTaskLabel.Size = new System.Drawing.Size(237, 42);
            this.zeroTaskLabel.TabIndex = 0;
            this.zeroTaskLabel.Text = "В этот день у вас нет задач с истекающим сроком";
            // 
            // noDeadlineTasksLayout
            // 
            this.noDeadlineTasksLayout.Location = new System.Drawing.Point(488, 46);
            this.noDeadlineTasksLayout.Name = "noDeadlineTasksLayout";
            this.noDeadlineTasksLayout.Size = new System.Drawing.Size(285, 413);
            this.noDeadlineTasksLayout.TabIndex = 2;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.monthCalendar.Location = new System.Drawing.Point(11, 46);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 0;
            this.monthCalendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateSelected);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.pictureBox1);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.tasksFlowLayout);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.tagsFlowLayout);
            this.tabPage4.Location = new System.Drawing.Point(4, 30);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(789, 452);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "       Метки проекта       ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::TikTask.Properties.Resources.addLight;
            this.pictureBox1.Location = new System.Drawing.Point(258, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(310, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Задачи с выбранными метками";
            // 
            // tasksFlowLayout
            // 
            this.tasksFlowLayout.BackColor = System.Drawing.Color.LightGray;
            this.tasksFlowLayout.Location = new System.Drawing.Point(314, 52);
            this.tasksFlowLayout.Name = "tasksFlowLayout";
            this.tasksFlowLayout.Size = new System.Drawing.Size(321, 371);
            this.tasksFlowLayout.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Метки проекта";
            // 
            // tagsFlowLayout
            // 
            this.tagsFlowLayout.BackColor = System.Drawing.Color.LightGray;
            this.tagsFlowLayout.Location = new System.Drawing.Point(11, 52);
            this.tagsFlowLayout.Name = "tagsFlowLayout";
            this.tagsFlowLayout.Size = new System.Drawing.Size(271, 371);
            this.tagsFlowLayout.TabIndex = 0;
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.projectPanel.ResumeLayout(false);
            this.projectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editProjectButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteProjectButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inviteUserButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.visualTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.stagesPanel.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.dayTaskFlowLayout.ResumeLayout(false);
            this.dayTaskFlowLayout.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel projectPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.PictureBox inviteUserButton;
        private System.Windows.Forms.TabControl visualTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel stagesPanel;
        private System.Windows.Forms.Button addStageButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label taskDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel dayTaskFlowLayout;
        private System.Windows.Forms.Label zeroTaskLabel;
        private System.Windows.Forms.FlowLayoutPanel noDeadlineTasksLayout;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel tasksFlowLayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel tagsFlowLayout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox editProjectButton;
        private System.Windows.Forms.PictureBox deleteProjectButton;
    }
}