using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TikTask.Properties;

namespace TikTask
{
    internal class Tag
    {
        string id, project, name, color;
        public Tag(string id, string name, string color, string project)
        {
            this.id = id;
            this.name = name;
            this.color = color;
            this.project = project;
        }
        public Tag(DataRow labelRow) 
        {
            id = labelRow["id"].ToString();
            name = labelRow["name"].ToString();
            color = labelRow["color"].ToString();
            project = labelRow["project"].ToString();
        }
        public Tag(string id) 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `labels` WHERE `id` = @lI", db.getConnection());
            command.Parameters.Add("@lI", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                this.id = id;
                this.name = row["name"].ToString();
                this.color = row["color"].ToString();
                this.project = row["project"].ToString();
            }
        }
        public Color GetColor() 
        {
            Color tagColor = Color.FromArgb(Convert.ToInt32(color));
            return tagColor;
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
       );
        public Panel GetBigLabelPreview() 
        {
            Label tagNameLabel = new Label();
            tagNameLabel.Font = new Font("Century Gothic", 9);
            tagNameLabel.Text = name;
            tagNameLabel.AutoSize = true;
            FlowLayoutPanel tagBigPanel = new FlowLayoutPanel();
            tagBigPanel.FlowDirection = FlowDirection.LeftToRight;
            tagBigPanel.AutoScroll = false;
            tagBigPanel.AutoSize = true;
            tagBigPanel.BackColor = GetColor();
            PictureBox deleteTag = new PictureBox();
            deleteTag.Image = Resources.closeDark16;
            deleteTag.Size = new Size(14, 14);
            deleteTag.Cursor = Cursors.Hand;
            deleteTag.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteTag.Click += (sender, e) => { RemoveFromTask(); };
            tagBigPanel.Controls.Add(tagNameLabel);
            tagBigPanel.Controls.Add(deleteTag);
            tagBigPanel.SizeChanged += (sender, e) => {
                tagBigPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tagBigPanel.Width, tagBigPanel.Height, 4, 4));
            };
            return tagBigPanel;
        }
        private void RemoveFromTask() 
        {
            TaskForm openedTF = Application.OpenForms.OfType<TaskForm>().FirstOrDefault();
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `task-label` WHERE `task` = @t AND `label` = @l", db.getConnection());
            command.Parameters.Add("@t", MySqlDbType.Int32).Value = openedTF.task.id;
            command.Parameters.Add("@l", MySqlDbType.Int32).Value = id;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            openedTF.UpdateTags();

            if (Application.OpenForms.OfType<ProjectForm>().FirstOrDefault() != null) Application.OpenForms.OfType<ProjectForm>().FirstOrDefault().UpdateProjectView();
        }
        public Panel GetSmallTag() 
        {
            Panel tagPanel = new Panel();
            tagPanel.BackColor = GetColor();
            tagPanel.Size = new Size(10, 15);
            tagPanel.Cursor = Cursors.Hand;
            tagPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tagPanel.Width, tagPanel.Height, 4, 4));
            ToolTip tip = new ToolTip();
            tip.SetToolTip(tagPanel, $"{name}");
            return tagPanel;
        }
        public Panel GetLabelPanel() 
        {
            Panel panel = new Panel();
            panel.Size = new Size(240, 35);
            panel.BackColor = GetColor();
            panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel.Width, panel.Height, 10, 10));
            panel.Tag = id;
            CheckBox tagName = new CheckBox();
            tagName.Text = name;
            panel.Controls.Add(tagName);
            PictureBox deleteTag = new PictureBox();
            deleteTag.Image = Resources.deleteWhite;
            deleteTag.Size = new Size(20, 20);
            deleteTag.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteTag.Tag = id;
            deleteTag.Cursor = Cursors.Hand;
            deleteTag.Click += (sender, e) =>
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("DELETE FROM `labels` WHERE `id` = @tagID", db.getConnection());
                command.Parameters.Add("@tagID", MySqlDbType.Int32).Value = ((PictureBox)sender).Tag.ToString();
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
                ProjectForm projectForm = Application.OpenForms.OfType<ProjectForm>().FirstOrDefault();
                projectForm.DeleteTagPanel(id);
            };
            panel.Controls.Add(deleteTag);
            deleteTag.Location = new Point(panel.Width - 30, 5);
            tagName.Location = new Point(10, 5);
            tagName.CheckedChanged += (sender, e) => 
            {
                ProjectForm projectForm = Application.OpenForms.OfType<ProjectForm>().FirstOrDefault();
                DataTable tasks = GetTasksByTag();
                if (tagName.Checked)
                {
                    foreach (DataRow taskRow in tasks.Rows)
                    {
                        Task task = new Task(taskRow["task"].ToString());
                        projectForm.FillTasksPanel(task.GetExistingTaskPreviewPanel(false));
                    }
                }
                else 
                {
                    projectForm.DeleteTasksByTag(tasks);
                }
            };
            return panel;
        }

        public DataTable GetTasksByTag() 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT `task` FROM `task-label` WHERE `label` = @labelID", db.getConnection());
            command.Parameters.Add("@labelID", MySqlDbType.Int32).Value = id;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            db.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }
    }
}
