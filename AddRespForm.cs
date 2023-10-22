using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TikTask
{
    public partial class AddRespForm : Form
    {
        public Task task;
        public TaskForm taskForm;
        public AddRespForm(Task task)
        {
            InitializeComponent();
            this.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            this.task = task;
            responsibleBox.DataSource = GetProjectMembers();
        }
        public AddRespForm(Task task, TaskForm taskForm)
        {
            InitializeComponent();
            this.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            this.task = task;
            this.taskForm = taskForm;
            responsibleBox.DataSource = GetProjectMembers();
        }
        private List<string> GetProjectMembers()
        {
            List<string> members = new List<string>();
            string stage, project, mail;
            DB db = new DB();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT `stage` FROM `tasks` WHERE `id` = @tI", db.getConnection());
            command.Parameters.Add("@tI", MySqlDbType.Int32).Value = task.id;
            object result = command.ExecuteScalar();
            stage = result.ToString();

            command = new MySqlCommand("SELECT `project` FROM `stages` WHERE `id` = @sI", db.getConnection());
            command.Parameters.Add("@sI", MySqlDbType.Int32).Value = stage;
            project = command.ExecuteScalar().ToString();


            command = new MySqlCommand("SELECT * FROM `involved` WHERE `project` = @pI", db.getConnection());
            command.Parameters.Add("@pI", MySqlDbType.Int32).Value = project;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                command = new MySqlCommand("SELECT `mail` FROM `users` WHERE `id` = @uI", db.getConnection());
                command.Parameters.Add("@uI", MySqlDbType.Int32).Value = row["user"].ToString();
                mail = command.ExecuteScalar().ToString();
                members.Add(mail);
            }
            members.Add("");
            db.closeConnection();
            return members;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string mail = responsibleBox.Text;
            DB db = new DB();
            db.openConnection();
            if (mail == "")
            {
                MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET `responsible` = NULL WHERE `id` = @tI", db.getConnection());
                command.Parameters.Add("@tI", MySqlDbType.Int32).Value = task.id;
                command.ExecuteNonQuery();
                task.responsible = null;
            }
            else 
            {
                MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET `responsible` = @tR WHERE `id` = @tI", db.getConnection());
                command.Parameters.Add("@tR", MySqlDbType.VarChar).Value = mail;
                command.Parameters.Add("@tI", MySqlDbType.Int32).Value = task.id;
                command.ExecuteNonQuery();
                task.responsible = mail;
            }
            
            db.closeConnection();
            if (taskForm != null) taskForm.UpdateResponsible();
            task.UpdateResponsible();
            if (Application.OpenForms.OfType<ProjectForm>().FirstOrDefault() != null) Application.OpenForms.OfType<ProjectForm>().FirstOrDefault().UpdateProjectView(); 
            this.Close();
        }
    }
}
