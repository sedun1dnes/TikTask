namespace TikTask
{
    partial class LabelForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.setLabelButton = new System.Windows.Forms.Button();
            this.labelsBox = new System.Windows.Forms.ComboBox();
            this.tagBoxElemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.newLabelButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tagBoxElemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // colorDialog1
            // 
            this.colorDialog1.Color = System.Drawing.Color.IndianRed;
            this.colorDialog1.ShowHelp = true;
            // 
            // setLabelButton
            // 
            this.setLabelButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setLabelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.setLabelButton.Location = new System.Drawing.Point(134, 92);
            this.setLabelButton.Name = "setLabelButton";
            this.setLabelButton.Size = new System.Drawing.Size(104, 24);
            this.setLabelButton.TabIndex = 10;
            this.setLabelButton.Text = "Присвоить";
            this.setLabelButton.UseVisualStyleBackColor = true;
            this.setLabelButton.Click += new System.EventHandler(this.setLabelButton_Click);
            // 
            // labelsBox
            // 
            this.labelsBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.labelsBox.FormattingEnabled = true;
            this.labelsBox.Location = new System.Drawing.Point(99, 47);
            this.labelsBox.Name = "labelsBox";
            this.labelsBox.Size = new System.Drawing.Size(177, 24);
            this.labelsBox.TabIndex = 11;
            // 
            // tagBoxElemBindingSource
            // 
            this.tagBoxElemBindingSource.DataSource = typeof(TikTask.TagBoxElem);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(14, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Мои метки";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Новая метка задачи";
            // 
            // newLabelButton
            // 
            this.newLabelButton.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newLabelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(52)))), ((int)(((byte)(48)))));
            this.newLabelButton.Location = new System.Drawing.Point(289, 47);
            this.newLabelButton.Name = "newLabelButton";
            this.newLabelButton.Size = new System.Drawing.Size(62, 24);
            this.newLabelButton.TabIndex = 14;
            this.newLabelButton.Text = "Новая";
            this.newLabelButton.UseVisualStyleBackColor = true;
            this.newLabelButton.Click += new System.EventHandler(this.newLabelButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Image = global::TikTask.Properties.Resources.closeDark24;
            this.closeButton.Location = new System.Drawing.Point(342, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(16, 16);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeButton.TabIndex = 9;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // LabelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 128);
            this.Controls.Add(this.newLabelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelsBox);
            this.Controls.Add(this.setLabelButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LabelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tagBoxElemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button setLabelButton;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.ComboBox labelsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newLabelButton;
        private System.Windows.Forms.BindingSource tagBoxElemBindingSource;
    }
}