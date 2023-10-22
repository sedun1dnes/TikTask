using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TikTask.Properties;

namespace TikTask
{
    public class Stage
    {
        public string id, name, author, project;
        public ProjectForm parentProject;
        public MainForm mainProj;
        public FlowLayoutPanel stage;
        public bool activeTaskPreview = false;
        PictureBox addTaskButton, editStageButton, deleteStageButton;
        Label stageName;
        Panel head;

        public Stage(MainForm main, ProjectForm parentProject, string name, string author, string id) 
        {
            this.author = author;
            this.name = name;
            this.mainProj = main;
            this.parentProject = parentProject;
            this.id = id;

        }
        public Stage(string id)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `stages` WHERE `id` = @sI", db.getConnection());
            command.Parameters.Add("@sI", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            
            foreach (DataRow row in table.Rows)
            {
                this.id = row["id"].ToString();
                this.name = row["name"].ToString();
                this.author = row["author"].ToString();
                this.project = row["project"].ToString();
            }
        }

        public Stage(DataRow row)
        {
            this.id = row["id"].ToString();
            this.name = row["name"].ToString();
            this.author = row["author"].ToString();
            this.project = row["project"].ToString();
        }


        public bool PushToDB(TextBox name)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `stages` (`name`, `author`, `project`) VALUES (@sN, @sA, @sPr);", db.getConnection());

            command.Parameters.Add("@sN", MySqlDbType.VarChar).Value = name.Text;
            this.name = name.Text;
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            command.Parameters.Add("@sA", MySqlDbType.Int32).Value = mainForm.curUser.id;
            this.author = mainForm.curUser.id;
            command.Parameters.Add("@sPr", MySqlDbType.Int32).Value = parentProject.curProject.id;
            this.project = parentProject.curProject.id;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                this.id = command.LastInsertedId.ToString();
                return true;
            }
            else
                db.closeConnection();
            return false;
        }
        public FlowLayoutPanel GetStagePanel(int height) 
        {
            stage = new FlowLayoutPanel();
            stage.AllowDrop = true;
            stage.DragEnter += Stage_DragEnter;
            stage.DragOver += Stage_DragOver;
            stage.DragDrop += Stage_DragDrop;
            stage.Width = 300;
            stage.Height = height;
            stage.AutoScroll = true;
            stage.BackColor = Color.FromArgb(217, 217, 217);
            head = new Panel();
            head.Width = stage.Width - 30;
            head.Height = 40;

            stageName = new System.Windows.Forms.Label();
            stageName.Width = stage.Width - 110;
            stageName.Height = 20;
            stageName.Text = name;
            stageName.AutoEllipsis = true;
            stageName.Font = new Font("Century Gothic", 14);
            stageName.ForeColor = Color.FromArgb(82, 102, 93);

            addTaskButton = new PictureBox();
            addTaskButton.Width = 24;
            addTaskButton.Height = 24;
            addTaskButton.Image = Properties.Resources.addDark32;
            addTaskButton.SizeMode = PictureBoxSizeMode.StretchImage;
            addTaskButton.Cursor = Cursors.Hand;
            addTaskButton.Location = new Point(head.Location.X + head.Width - 50 - addTaskButton.Width, default);
            addTaskButton.Click += AddTaskButton_Click;
            addTaskButton.MouseEnter += AddTaskButton_MouseEnter;
            addTaskButton.MouseLeave += AddTaskButton_MouseLeave;

            deleteStageButton = new PictureBox();
            deleteStageButton.Width = 18;
            deleteStageButton.Height = 18;
            deleteStageButton.Image = Properties.Resources.deleteDark;
            deleteStageButton.SizeMode = PictureBoxSizeMode.StretchImage;
            deleteStageButton.Cursor = Cursors.Hand;
            deleteStageButton.Location = new Point(addTaskButton.Location.X + 26, addTaskButton.Location.Y + 4);
            deleteStageButton.Click += deleteStageButton_Click;
            deleteStageButton.MouseEnter += (sender, e) => { deleteStageButton.Image = Resources.deleteBlack; };
            deleteStageButton.MouseLeave += (sender, e) => { deleteStageButton.Image = Resources.deleteDark; };

            editStageButton = new PictureBox();
            editStageButton.Width = 18;
            editStageButton.Height = 18;
            editStageButton.Image = Properties.Resources.editDark32;
            editStageButton.SizeMode = PictureBoxSizeMode.StretchImage;
            editStageButton.Cursor = Cursors.Hand;
            editStageButton.Location = new Point(deleteStageButton.Location.X + 26, addTaskButton.Location.Y + 4);
            editStageButton.MouseEnter += EditStageButton_MouseEnter;
            editStageButton.MouseLeave += EditStageButton_MouseLeave;
            editStageButton.Click += EditStageButton_Click;

            head.Controls.Add(stageName);
            head.Controls.Add(editStageButton);
            head.Controls.Add(addTaskButton);
            head.Controls.Add(deleteStageButton);
            stage.Controls.Add(head);
            return stage;
        }

        private void Stage_DragDrop(object sender, DragEventArgs e)
        {
            Panel taskPanel = (Panel)e.Data.GetData(typeof(Panel));
            string taskId = taskPanel.Tag.ToString();
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET `stage` = @stageID WHERE `id` = @taskID", db.getConnection());
            command.Parameters.Add("@stageID", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@taskID", MySqlDbType.Int32).Value = taskId;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            ProjectForm projForm = Application.OpenForms.OfType<ProjectForm>().FirstOrDefault();
            projForm.UpdateProjectView();
        }

        private void Stage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Panel)))
                {
                    e.Effect = DragDropEffects.Move;
                }
        }
        private void Stage_DragOver(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Panel))) 
            {
                Panel taskPanel = (Panel)e.Data.GetData(typeof(Panel));
                Panel targetColumn = (Panel)sender;

                if (taskPanel.Parent != targetColumn) 
                {
                    targetColumn.Controls.Add(taskPanel);
                }
            }
        }
        TextBox stageField;
        private void EditStageButton_Click(object sender, EventArgs e)
        {
            head.Controls.Remove(stageName);
            stageField = new TextBox();
            stageField.Width = stage.Width - 110;
            stageField.Height = 18;
            stageField.Text = name;
            stageField.Font = new Font("Century Gothic", 14);
            stageField.ForeColor = Color.FromArgb(82, 102, 93);
            stageField.KeyPress += StageField_KeyPress;
            head.Controls.Add(stageField);

        }
        private void deleteStageButton_Click(object sender, EventArgs e) 
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите удалить этап? Задачи этапа удалятся вместе с ним.", "Подтверждение удаления", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Delete();
                ProjectForm openedPF = Application.OpenForms.OfType<ProjectForm>().FirstOrDefault();
                openedPF.UpdateProjectView();
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }
        public void Delete() 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `tasks` WHERE `stage` = @sI", db.getConnection());
            command.Parameters.Add("@sI", MySqlDbType.Int32).Value = id;
            db.openConnection();
            command.ExecuteNonQuery();
            command = new MySqlCommand("DELETE FROM `stages` WHERE `id` = @sI", db.getConnection());
            command.Parameters.Add("@sI", MySqlDbType.Int32).Value = id;
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        private void StageField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.name = stageField.Text; 
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `stages` SET `name` = @pN WHERE `id` = @sI", db.getConnection());
                command.Parameters.Add("@sI", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = name;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
                stageName.Text = name;
                head.Controls.Remove(stageField);
                head.Controls.Add(stageName);
            }
        }
        private void EditStageButton_MouseLeave(object sender, EventArgs e)
        {
            editStageButton.Image = Properties.Resources.editDark32;
        }
        private void EditStageButton_MouseEnter(object sender, EventArgs e)
        {
            editStageButton.Image = Properties.Resources.editBlack32;
        }
        private void AddTaskButton_MouseLeave(object sender, EventArgs e)
        {
            addTaskButton.Image = Properties.Resources.addDark32;
        }
        private void AddTaskButton_MouseEnter(object sender, EventArgs e)
        {
            addTaskButton.Image = Properties.Resources.addBlack32;
        }
        public void AddTaskButton_Click(object sender, EventArgs e)
        {
            if (!activeTaskPreview)
            {
                Task new_task = new Task(this);
                Panel panel = new_task.GetTaskPreviewPanel();
                stage.Controls.Add(panel);
            }
        }
        public DataTable GetStagesTasks() 
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `tasks` WHERE `stage` = @tS", db.getConnection());
            command.Parameters.Add("@tS", MySqlDbType.Int32).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
    }
}
