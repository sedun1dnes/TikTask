using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TikTask
{
    public partial class AddDateForm : Form
    {
        public Task task;
        public TaskForm taskForm;
        public AddDateForm(Task task)
        {
            InitializeComponent();
            this.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            this.task = task;
            if (task.startDate != DateTime.MinValue) startTimePicker.Value = task.startDate;
            if (task.finishDate != DateTime.MinValue) finishTimePicker.Value = task.finishDate;

        }
        public AddDateForm(Task task, TaskForm taskForm)
        {
            InitializeComponent();
            this.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            this.task = task;
            this.taskForm = taskForm;
            if (task.startDate != DateTime.MinValue) startTimePicker.Value = task.startDate;
            if (task.finishDate != DateTime.MinValue) finishTimePicker.Value = task.finishDate;

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            task.startDate = startTimePicker.Value;
            task.finishDate = finishTimePicker.Value;
            
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET `startDate` = @tSD WHERE `id` = @tI", db.getConnection());
            command.Parameters.Add("tSD", MySqlDbType.Date).Value = task.startDate;
            command.Parameters.Add("tI", MySqlDbType.Int32).Value = task.id;
            command.ExecuteNonQuery();

            command = new MySqlCommand("UPDATE `tasks` SET `finishDate` = @tFD WHERE `id` = @tI", db.getConnection());
            command.Parameters.Add("tFD", MySqlDbType.Date).Value = task.finishDate;
            command.Parameters.Add("tI", MySqlDbType.Int32).Value = task.id;
            command.ExecuteNonQuery();

            db.closeConnection();

            task.UpdateFinishDate();
            if (taskForm != null) taskForm.UpdateDates();
            if (Application.OpenForms.OfType<MainForm>().FirstOrDefault() != null) Application.OpenForms.OfType<MainForm>().FirstOrDefault().UpdateTasks();
            if (Application.OpenForms.OfType<ProjectForm>().FirstOrDefault() != null) Application.OpenForms.OfType<ProjectForm>().FirstOrDefault().UpdateProjectView(); ;
            this.Close();
        }

        

    }
}
