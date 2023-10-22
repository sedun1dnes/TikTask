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
    public class Project
    {
        public string id, name, host;
        public DateTime? startDate, finishDate;
        public Panel previewCard;
        public MainForm main;

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
        public Project(MainForm main, string name = null, DateTime? startDate = null, DateTime? finishDate = null, string host = null, string id = null)
        {
            this.id = id;
            this.name = name;
            this.startDate = startDate;
            this.finishDate = finishDate;
            this.host = host;
            this.main = main;
        }
        public Project(string id) 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `projects` WHERE `id` = @pI", db.getConnection());
            command.Parameters.Add("@pI", MySqlDbType.Int32).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                this.id = id;
                this.name = row["name"].ToString();
                this.startDate = DateTime.Parse(row["startDate"].ToString());
                this.finishDate = DateTime.Parse(row["finishDate"].ToString());
                this.host = row["host"].ToString();
            }
        }


        public void PushToDB()
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `projects` (`name`, `startDate`, `finishDate`, `host`) VALUES (@pN, @pSD, @pED, @pH);", db.getConnection());

            command.Parameters.Add("@pN", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@pSD", MySqlDbType.DateTime).Value = startDate.Value;
            command.Parameters.Add("@pED", MySqlDbType.DateTime).Value = finishDate.Value;
            command.Parameters.Add("@pH", MySqlDbType.Int32).Value = host;

            db.openConnection();
            command.ExecuteNonQuery();
            this.id = command.LastInsertedId.ToString();
            command = new MySqlCommand("INSERT INTO `involved` (`project`, `user`) VALUES (@pI, @uI);", db.getConnection());
            command.Parameters.Add("@pI", MySqlDbType.Int32).Value = this.id;
            command.Parameters.Add("@uI", MySqlDbType.Int32).Value = this.host;
            command.ExecuteNonQuery();
            db.closeConnection();
        }

        public Panel GetPreviewCard() 
        {
            previewCard = new Panel();
            previewCard.Width = 320;
            previewCard.Height = 70;
            previewCard.BackColor = Color.White;
            previewCard.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 320, 70, 10, 10));

            Label projectNameLabel = new Label();
            projectNameLabel.Width = 250;
            projectNameLabel.AutoEllipsis = true;
            projectNameLabel.Text = this.name;
            projectNameLabel.Font = new Font("Century Gothic", 14);
            projectNameLabel.Location = new Point(previewCard.Location.X + 10, previewCard.Location.Y + 5);

            PictureBox deadline = new PictureBox();
            deadline.Image = Resources.calendarDark32;
            deadline.Height = 24;
            deadline.Width = 24;
            deadline.SizeMode = PictureBoxSizeMode.StretchImage;
            deadline.Location = new Point(previewCard.Location.X + 15, projectNameLabel.Location.Y + 35);

            Label dateLabel = new Label();
            dateLabel.Text = finishDate.ToString().Split()[0];
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Century Gothic", 8);
            dateLabel.Location = new Point(deadline.Location.X + deadline.Width + 3, deadline.Location.Y + 5);
            if (finishDate == DateTime.Today) dateLabel.Text = "Сегодня";
            if (finishDate < DateTime.Today) dateLabel.ForeColor = Color.Red;

            PictureBox hostImage = new PictureBox();
            hostImage.Image = Resources.userDark24;
            hostImage.Height = 22;
            hostImage.Width = 22;
            hostImage.SizeMode = PictureBoxSizeMode.StretchImage;
            hostImage.Location = new Point(dateLabel.Location.X + dateLabel.Width + 10, projectNameLabel.Location.Y + 36);

            User hostUs = new User(host);
            Label hostLabel = new Label();
            hostLabel.Text = hostUs.mail;
            hostLabel.AutoEllipsis = true;
            hostLabel.Font = new Font("Century Gothic", 8);
            hostLabel.Location = new Point(hostImage.Location.X + hostImage.Width + 3, hostImage.Location.Y + 5);

            PictureBox openProjectButton = new PictureBox();
            openProjectButton.Image = Resources.openLight32;
            openProjectButton.Height = 24;
            openProjectButton.Width = 24;
            openProjectButton.SizeMode = PictureBoxSizeMode.StretchImage;
            openProjectButton.Cursor = Cursors.Hand;
            openProjectButton.Location = new Point(previewCard.Width - 35, 7);
            openProjectButton.Click += (sender, e) =>
            {
                ProjectForm form = new ProjectForm(this);
                MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                main.Hide();
                form.Show();
            };
            openProjectButton.MouseEnter += (sender, e) =>
            {
                openProjectButton.Image = Resources.openDark32;
            };
            openProjectButton.MouseLeave += (sender, e) =>
            {
                openProjectButton.Image = Resources.openLight32;
            };

            previewCard.Controls.Add(openProjectButton);
            previewCard.Controls.Add(projectNameLabel);
            previewCard.Controls.Add(deadline);
            previewCard.Controls.Add(dateLabel);
            previewCard.Controls.Add(hostImage);
            previewCard.Controls.Add(hostLabel);
            return previewCard;
        }

        public DataTable GetProjectsStages() 
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `stages` WHERE `project` = @CUI", db.getConnection());
            command.Parameters.Add("@CUI", MySqlDbType.Int32).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public DataTable GetProjectTasks()
        {
            DataTable stages = GetProjectsStages();
            DB db = new DB();
            DataTable tasks = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command;
            db.openConnection();
            foreach (DataRow row in stages.Rows) 
            {
                command = new MySqlCommand("SELECT * FROM `tasks` WHERE `stage` = @stageID", db.getConnection());
                command.Parameters.Add("@stageID", MySqlDbType.Int32).Value = row["id"].ToString();
                adapter.SelectCommand = command;
                adapter.Fill(tasks);
            }
            db.closeConnection();
            return tasks;
        }
        public DataTable GetProjectLabels() 
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `labels` WHERE `project` = @CUI", db.getConnection());
            command.Parameters.Add("@CUI", MySqlDbType.Int32).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public void EditName(string newName) 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `projects` SET `name` = @projectName WHERE `id` = @projectID ", db.getConnection());
            command.Parameters.Add("@projectName", MySqlDbType.VarChar).Value = newName;
            command.Parameters.Add("@projectID", MySqlDbType.Int32).Value = id;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            name = newName;
        }
        public void Delete() 
        {
            foreach (DataRow taskRow in GetProjectTasks().Rows)
            {
                Task task = new Task(taskRow);
                task.Delete();
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `involved` WHERE `project` = @projectID", db.getConnection());
            command.Parameters.Add("@projectID", MySqlDbType.Int32).Value = id;
            db.openConnection();
            command.ExecuteNonQuery();
            command = new MySqlCommand("DELETE FROM `stages` WHERE `project` = @projectID", db.getConnection());
            command.Parameters.Add("@projectID", MySqlDbType.Int32).Value = id;
            command.ExecuteNonQuery();
            command = new MySqlCommand("DELETE FROM `projects` WHERE `id` = @projectID", db.getConnection());
            command.Parameters.Add("@projectID", MySqlDbType.Int32).Value = id;
            command.ExecuteNonQuery();
            command = new MySqlCommand("DELETE FROM `labels` WHERE `project` = @projectID", db.getConnection());
            command.Parameters.Add("@projectID", MySqlDbType.Int32).Value = id;
            command.ExecuteNonQuery();
            db.closeConnection();
            
        }
    }
}
