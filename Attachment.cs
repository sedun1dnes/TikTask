using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using TikTask.Properties;

namespace TikTask
{
    internal class Attachment
    {
        string id, name, task;
        byte[] data;
        public Attachment(DataRow attachmentRow)
        {
            this.id = attachmentRow["id"].ToString();
            this.name = attachmentRow["name"].ToString();
            this.task = attachmentRow["task"].ToString();
            this.data = (byte[])attachmentRow["data"];
        }
        public Panel GetAttachmentPreview() 
        {
            Panel attachmentPanel = new Panel();
            attachmentPanel.Size = new Size(400, 30);
            Label attachmentName = new Label();
            attachmentName.Font = new Font("Century Gothic", 10);
            attachmentName.Size = new Size(370, 30);
            attachmentName.Text = name;
            attachmentName.AutoEllipsis = true;
            PictureBox download = new PictureBox();
            download.Image = Resources.downloadLight1;
            download.Cursor = Cursors.Hand;
            download.MouseEnter += (sender, e) => { download.Image = Resources.downloadDark; };
            download.MouseLeave += (sender, e) => { download.Image = Resources.downloadLight1; };
            download.SizeMode = PictureBoxSizeMode.StretchImage;
            download.Size = new Size(24, 24);
            download.Location = new Point(attachmentName.Location.X + attachmentName.Width + 10, attachmentName.Location.Y);
            download.Click += Save_Click;
            attachmentPanel.Controls.Add(download);
            attachmentPanel.Controls.Add(attachmentName);
            return attachmentPanel;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All Files (*.*)|*.*";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = name;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                File.WriteAllBytes(filePath, data);
            }
        }
    }
}
