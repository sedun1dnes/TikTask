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
    public class Task
    {
        public string id, name, stage;
        public string responsible, description = null;
        bool archived = false;
        public DateTime startDate, finishDate;

        Panel taskPanel;
        TextBox taskNameField;
        public bool activeField = false;
        Stage parentStage;
        PictureBox addResponsButton;
        PictureBox addDatesButton;
        PictureBox openTaskButton;
        System.Windows.Forms.Label Responsible = new System.Windows.Forms.Label();
        CheckBox taskNameLabel;

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

        public Task(string id, string name, string description, string stage, DateTime startDate, DateTime finishDate, Stage parentStage = null)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.stage = stage;
            this.startDate = startDate;
            this.finishDate = finishDate;
            this.parentStage = parentStage;
        }

        public Task(DataRow row) 
        {
            this.id = row["id"].ToString();
            this.name = row["name"].ToString();
            if (row["description"] != null) this.description = row["description"].ToString();
            this.stage = row["stage"].ToString();
            if (row["startDate"] != null) this.startDate = DateTime.Parse(row["startDate"].ToString()); 
            if (row["startDate"] != null) this.finishDate = DateTime.Parse(row["finishDate"].ToString());
            if (row["responsible"] != null) this.responsible = row["responsible"].ToString();
            this.archived = Convert.ToBoolean(row["archived"]);

        }
        public Task(string id) 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tasks` WHERE `id` = @tI", db.getConnection());
            command.Parameters.Add("@tI", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                this.id = row["id"].ToString();
                this.name = row["name"].ToString();
                if (row["description"] != null) this.description = row["description"].ToString();
                this.stage = row["stage"].ToString();
                if (row["startDate"] != null) this.startDate = DateTime.Parse(row["startDate"].ToString());
                if (row["startDate"] != null) this.finishDate = DateTime.Parse(row["finishDate"].ToString());
                if (row["responsible"] != null) this.responsible = row["responsible"].ToString();
                this.archived = Convert.ToBoolean(row["archived"]);
            }
        }
        public Task(Stage parentStage) 
        {
            this.parentStage = parentStage;
            this.stage = parentStage.id;
        }

        public Project GetProject() 
        {
            Stage stage = new Stage(this.stage);
            Project project = new Project(stage.project);
            return project;
        }
        public void Delete() 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `tasks` WHERE `id` = @tI", db.getConnection());
            command.Parameters.Add("@tI", MySqlDbType.Int32).Value = id;
            db.openConnection();
            command.ExecuteNonQuery();
            command = new MySqlCommand("DELETE FROM `attachments` WHERE `task` = @tI", db.getConnection());
            command.Parameters.Add("@tI", MySqlDbType.Int32).Value = id;
            command.ExecuteNonQuery();
            command = new MySqlCommand("DELETE FROM `task-label` WHERE `task` = @tI", db.getConnection());
            command.Parameters.Add("@tI", MySqlDbType.Int32).Value = id;
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public void PushToDB() 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `tasks` (`archived`, `name`, `stage`, `description`, `startDate`, `finishDate`) VALUES (@tAr, @tN, @tS, @tD, @tSD, @tFD);", db.getConnection());

            command.Parameters.Add("tAr", MySqlDbType.Int32).Value = this.archived;
            command.Parameters.Add("@tN", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@tS", MySqlDbType.Int32).Value = parentStage.id;
            if (description != null)
            {
                command.Parameters.Add("tD", MySqlDbType.VarChar).Value = description;
            }
            else
            {
                command.Parameters.Add("tD", MySqlDbType.VarChar).Value = null;
            }
            if (startDate != null)
            {
                command.Parameters.Add("tSD", MySqlDbType.DateTime).Value = startDate;
            }
            else
            {
                command.Parameters.Add("tSD", MySqlDbType.DateTime).Value = null;
            }
            if (finishDate != null)
            {
                command.Parameters.Add("tFD", MySqlDbType.DateTime).Value = finishDate;
            }
            else
            {
                command.Parameters.Add("tFD", MySqlDbType.DateTime).Value = null;
            }

            db.openConnection();
            command.ExecuteNonQuery();
            this.id = command.LastInsertedId.ToString();
            db.closeConnection();
        }

        public Panel GetTaskPreviewPanel() 
        {
            taskPanel = new Panel();
            taskPanel.Width = 280;
            taskPanel.Height = 70;
            taskPanel.BackColor = Color.White;
            taskPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, taskPanel.Width, taskPanel.Height, 10, 10));

            taskNameField = new TextBox();
            taskNameField.Font = new Font("Century Gothic", 12);
            taskNameField.Location = new Point(taskPanel.Location.X + 5, taskPanel.Location.Y + 5);
            taskNameField.Width = taskPanel.Width - 50;
            taskNameField.KeyPress += TaskName_KeyPress;
            taskPanel.Controls.Add(taskNameField);

            if (parentStage != null) parentStage.activeTaskPreview = true;

            openTaskButton = new PictureBox();
            openTaskButton.Height = 24;
            openTaskButton.Width = 24;
            openTaskButton.SizeMode = PictureBoxSizeMode.StretchImage;
            openTaskButton.Image = Resources.openLight32;
            openTaskButton.Cursor = Cursors.Hand;
            openTaskButton.Location = new Point(taskPanel.Width - 30, 6);
            openTaskButton.MouseEnter += OpenTaskButton_MouseEnter;
            openTaskButton.MouseLeave += OpenTaskButton_MouseLeave;
            openTaskButton.Click += OpenTaskButton_Click;
            taskPanel.Controls.Add(openTaskButton);

            return taskPanel;
        }
        Label deadline = new Label();
        FlowLayoutPanel tagsPanel;
        public Panel GetExistingTaskPreviewPanel(bool allowDND) 
        {
            taskPanel = new Panel();
            taskPanel.Tag = id;
            taskPanel.Width = 280;
            taskPanel.Height = 70;
            taskPanel.BackColor =Color.White;
            if (allowDND) 
            {
                taskPanel.Tag = id;
                taskPanel.MouseDown += TaskPanel_MouseDown;
            }
            taskPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, taskPanel.Width, taskPanel.Height, 10, 10));
            if (archived) taskPanel.BackColor = Color.FromArgb(163, 181, 154);
            openTaskButton = new PictureBox();
            openTaskButton.Height = 24;
            openTaskButton.Width = 24;
            openTaskButton.SizeMode = PictureBoxSizeMode.StretchImage;
            openTaskButton.Image = Resources.openLight32;
            openTaskButton.Cursor = Cursors.Hand;
            openTaskButton.Location = new Point(taskPanel.Width - 30, 6);
            openTaskButton.MouseEnter += OpenTaskButton_MouseEnter;
            openTaskButton.MouseLeave += OpenTaskButton_MouseLeave;
            openTaskButton.Click += OpenTaskButton_Click;

            taskNameLabel = new CheckBox();
            taskNameLabel.Text = name;
            taskNameLabel.Size = new Size(200, 30);
            if (archived)
            {
                taskNameLabel.Font = new Font("Century Gothic", 12, FontStyle.Strikeout);
                taskNameLabel.Checked = true;
            }
            else taskNameLabel.Font = new Font("Century Gothic", 12);
            taskNameLabel.Location = new Point(10, 5);
            taskNameLabel.AutoEllipsis = true;
            taskNameLabel.CheckedChanged += TaskNameLabel_CheckedChanged;

            
            addResponsButton = new PictureBox();
            addResponsButton.Location = new Point(10, taskPanel.Height - 30);
            addResponsButton.Height = 24;
            addResponsButton.Width = 24;
            addDatesButton = new PictureBox();
            addDatesButton.Location = new Point(140, taskPanel.Height - 30);
            addDatesButton.SizeMode = PictureBoxSizeMode.StretchImage;
            addDatesButton.Height = 24;
            addDatesButton.Width = 24;
            if (responsible == null || responsible == "")
            {
                addResponsButton.Image = Resources.add_user_light;
                addResponsButton.Cursor = Cursors.Hand;
                Responsible.Text = "";
                addResponsButton.MouseEnter += AddResponsButton_MouseEnter;
                addResponsButton.MouseLeave += AddResponsButton_MouseLeave;
                addResponsButton.Click += AddResponsButton_Click;
                ToolTip responsibTip = new ToolTip();
                responsibTip.SetToolTip(addResponsButton, "Назначить задачу");
            }
            else 
            {                
                addResponsButton.Image = Resources.userDark24;
                Responsible.Text = responsible;
            }

            Responsible.Font = new Font("Century Gothic", 8);
            Responsible.Location = new Point(addResponsButton.Location.X + 25, addResponsButton.Location.Y + 5);
            Responsible.Width = addDatesButton.Location.X - addResponsButton.Location.X - 25;
            Responsible.AutoEllipsis = true;
            taskPanel.Controls.Add(Responsible);
            if (finishDate == DateTime.MinValue)
            {
                addDatesButton.Image = Resources.addDate_light;
                addDatesButton.Cursor = Cursors.Hand;
                addDatesButton.MouseEnter += addDatesButton_MouseEnter;
                addDatesButton.MouseLeave += addDatesButton_MouseLeave;
                addDatesButton.Click += AddDatesButton_Click;
                ToolTip dateTip = new ToolTip();
                dateTip.SetToolTip(addDatesButton, "Назначить сроки");
            }
            else
            {
                addDatesButton.Image = Resources.calendarDark32;
                if (finishDate == DateTime.Today) deadline.Text = "Сегодня";
                else deadline.Text = finishDate.ToString().Split()[0];
                deadline.Font = new Font("Century Gothic", 8);
                if (finishDate < DateTime.Today && !archived) deadline.ForeColor = Color.Red;
                deadline.Location = new Point(addDatesButton.Location.X + 25, addDatesButton.Location.Y + 5);
                deadline.Width = addDatesButton.Location.X - addResponsButton.Location.X - 25;
                taskPanel.Controls.Add(deadline);
                addDatesButton.SizeMode = PictureBoxSizeMode.StretchImage;
                addDatesButton.MouseEnter -= addDatesButton_MouseEnter;
                addDatesButton.MouseLeave -= addDatesButton_MouseLeave;
                addDatesButton.Click -= AddDatesButton_Click;
            }

            tagsPanel = new FlowLayoutPanel();
            tagsPanel.FlowDirection = FlowDirection.RightToLeft;
            tagsPanel.Size = new Size(60, 20);
            tagsPanel.AutoScroll = false;
            tagsPanel.Location = new Point(180, 8);
            foreach (DataRow tagRow in GetTasksTags().Rows)
            {
                Tag tag = new Tag(tagRow["label"].ToString());
                Panel tagPanel = tag.GetSmallTag();
                tagsPanel.Controls.Add(tagPanel);
                
            }
            taskPanel.Controls.Add(tagsPanel);
            taskPanel.Controls.Add(addResponsButton);
            taskPanel.Controls.Add(addDatesButton);
            taskPanel.Controls.Add(openTaskButton);
            taskPanel.Controls.Add(taskNameLabel);
            return taskPanel;
        }

        private void TaskPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                Panel taskPanel = (Panel)sender;
                taskPanel.DoDragDrop(taskPanel, DragDropEffects.Move);
            }
        }

        private void TaskNameLabel_CheckedChanged(object sender, EventArgs e)
        {
            taskNameLabel = (CheckBox)sender;
            if (taskNameLabel.Checked)
            {
                this.archived = true;
                taskPanel.BackColor = Color.FromArgb(163, 181, 154);
                taskNameLabel.Font = new Font("Century Gothic", 12, FontStyle.Strikeout);
                deadline.ForeColor = Color.Black;
            }
            else 
            {
                this.archived = false;
                taskPanel.BackColor = Color.White;
                taskNameLabel.Font = new Font("Century Gothic", 12);
                if (finishDate < DateTime.Today && !archived) deadline.ForeColor = Color.Red;
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET `archived` = @tS WHERE `id` = @tI", db.getConnection());
            command.Parameters.Add("@tS", MySqlDbType.Binary).Value = Convert.ToInt32(this.archived);
            command.Parameters.Add("@tI", MySqlDbType.Int32).Value = this.id;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
        }

        private void OpenTaskButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TaskForm>().FirstOrDefault() != null) Application.OpenForms.OfType<TaskForm>().FirstOrDefault().Close();
            TaskForm taskForm = new TaskForm(this);
            taskForm.Show();
        }
        private void OpenTaskButton_MouseLeave(object sender, EventArgs e)
        {
            openTaskButton.Image = Resources.openLight32;
        }

        private void OpenTaskButton_MouseEnter(object sender, EventArgs e)
        {
            openTaskButton.Image = Resources.openDark32;
        }

        private void TaskName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                taskPanel.Controls.Remove(taskNameField);

                CheckBox taskNameLabel = new CheckBox();
                taskNameLabel.Text = taskNameField.Text;
                this.name = taskNameLabel.Text;
                taskNameLabel.Size = new Size(200, 30);
                taskNameLabel.Location = new Point(10, 5);
                taskNameLabel.AutoEllipsis = true;
                taskNameLabel.CheckedChanged += TaskNameLabel_CheckedChanged;

                addResponsButton = new PictureBox();
                addResponsButton.Height = 24;
                addResponsButton.Width = 24;
                addResponsButton.Image = Resources.add_user_light;
                addResponsButton.Location = new Point(10, taskPanel.Height - 30);
                addResponsButton.Cursor = Cursors.Hand;
                addResponsButton.MouseEnter += AddResponsButton_MouseEnter;
                addResponsButton.MouseLeave += AddResponsButton_MouseLeave;
                addResponsButton.Click += AddResponsButton_Click;
                ToolTip responsibTip = new ToolTip();
                responsibTip.SetToolTip(addResponsButton, "Назначить задачу");

                addDatesButton = new PictureBox();
                addDatesButton.Height = 24;
                addDatesButton.Width = 24;
                addDatesButton.Image = Resources.addDate_light;
                addDatesButton.Location = new Point(140, taskPanel.Height - 30);
                addDatesButton.Cursor = Cursors.Hand;
                addDatesButton.MouseEnter += addDatesButton_MouseEnter;
                addDatesButton.MouseLeave += addDatesButton_MouseLeave;
                addDatesButton.Click += AddDatesButton_Click;
                ToolTip dateTip = new ToolTip();
                dateTip.SetToolTip(addDatesButton, "Назначить сроки");


                taskPanel.Controls.Add(addResponsButton);
                taskPanel.Controls.Add(addDatesButton);
                taskPanel.Controls.Add(taskNameLabel);
                parentStage.activeTaskPreview = false;
                this.PushToDB();
                taskPanel.Tag = id;
                taskPanel.MouseDown += TaskPanel_MouseDown;
            }
        }

        private void AddDatesButton_Click(object sender, EventArgs e)
        {
            AddDateForm form = new AddDateForm(this);
            form.Show();
        }

        private void AddResponsButton_Click(object sender, EventArgs e)
        {
            AddRespForm form = new AddRespForm(this);
            form.Show();
        }
        public void UpdateResponsible() 
        {
            if (responsible != null)
            {
                addResponsButton.Image = Resources.userDark24;
                Responsible.Text = responsible;
                addResponsButton.MouseEnter -= AddResponsButton_MouseEnter;
                addResponsButton.MouseLeave -= AddResponsButton_MouseLeave;
            }
            else 
            {
                addResponsButton.Image = Resources.add_user_light;
                addResponsButton.Cursor = Cursors.Hand;
                Responsible.Text = "";
                addResponsButton.MouseEnter += AddResponsButton_MouseEnter;
                addResponsButton.MouseLeave += AddResponsButton_MouseLeave;
                addResponsButton.Click += AddResponsButton_Click;
                ToolTip responsibTip = new ToolTip();
                responsibTip.SetToolTip(addResponsButton, "Назначить задачу");
            }

        }
        public void UpdateFinishDate()
        {
            addDatesButton.Image = Resources.calendarDark32;
            if (finishDate == DateTime.Today) deadline.Text = "Сегодня";
            else deadline.Text = finishDate.ToString().Split()[0];
            if (finishDate < DateTime.Today) deadline.ForeColor = Color.Red;            
            addDatesButton.MouseEnter -= addDatesButton_MouseEnter;
            addDatesButton.MouseLeave -= addDatesButton_MouseLeave;
        }

        public void UpdateStage(string newStageId) 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET `stage` = @sI WHERE `id` = @tI", db.getConnection());
            command.Parameters.Add("@sI", MySqlDbType.Int32).Value = newStageId;
            command.Parameters.Add("@tI", MySqlDbType.Int32).Value = id;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            this.stage = newStageId;
        }
        public void UpdateName(string newName) 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET `name` = @nN WHERE `id` = @tI", db.getConnection());
            command.Parameters.Add("@nN", MySqlDbType.VarChar).Value = newName;
            command.Parameters.Add("@tI", MySqlDbType.Int32).Value = id;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            this.name = newName;
        }
        public DataTable GetTasksTags()
        { 
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT `label` FROM `task-label` WHERE `task` = @tI", db.getConnection());
            command.Parameters.Add("@tI", MySqlDbType.Int32).Value = id;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }

        public DataTable GetAttachments() 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `attachments` WHERE `task` = @tI", db.getConnection());
            command.Parameters.Add("@tI", MySqlDbType.Int32).Value = id;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }

        private void AddResponsButton_MouseEnter(object sender, EventArgs e)
        {
            addResponsButton.Image = Resources.add_user_dark;
        }
        private void AddResponsButton_MouseLeave(object sender, EventArgs e)
        {
            addResponsButton.Image = Resources.add_user_light;
        }
        private void addDatesButton_MouseEnter(object sender, EventArgs e)
        {
            addDatesButton.Image = Resources.addDate_dark;
        }
        private void addDatesButton_MouseLeave(object sender, EventArgs e)
        {
            addDatesButton.Image = Resources.addDate_light;
        }
    }
}
