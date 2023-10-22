using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace TikTask
{
    public partial class MainForm : Form
    {
        public User curUser;
        public MainForm(User curUser)
        {
            this.curUser = curUser;
            InitializeComponent();
            greetingLabel.Text = Greeting();
            loginLabelMain.Text = curUser.login;
            dataLabel.Text = $"{DateTime.Now.ToString("dddd")}, {DateTime.Now.ToString("M")}";
            UpdateTasks();
            UpdateProjects();
        }
        public void Update() 
        {
            greetingLabel.Text = Greeting();
            loginLabelMain.Text = curUser.login;
            dataLabel.Text = $"{DateTime.Now.ToString("dddd")}, {DateTime.Now.ToString("M")}";
        }
        private void minimizeButton_Click(object sender, EventArgs e) { this.WindowState = FormWindowState.Minimized; }
        private void closeButton_Click(object sender, EventArgs e) { Application.Exit(); }
        Point clickPoint;
        private void topPanel_MouseClick(object sender, MouseEventArgs e)
        {
            clickPoint = new Point(e.X, e.Y);
        }
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - clickPoint.X;
                this.Top += e.Y - clickPoint.Y;
            }
        }
        public void UpdateTasks() 
        {
            tasksFlowLayoutPanel.Controls.Clear();
            DataTable curUserTasks = curUser.GetUserTasks();
            foreach (DataRow task in curUserTasks.Rows)
            {
                Task userTask = new Task(task);
                userTask.GetTaskPreviewPanel();
                tasksFlowLayoutPanel.Controls.Add(userTask.GetExistingTaskPreviewPanel(false));
            }
        }
        public void UpdateProjects() 
        {
            projectFlowLayout.Controls.Clear();
            DataTable curUserProjects = curUser.GetUserProjects();
            foreach (DataRow row in curUserProjects.Rows)
            {
                Project userProject = new Project(row["project"].ToString());
                projectFlowLayout.Controls.Add(userProject.GetPreviewCard());
            }
        }
        private string Greeting() 
        {
            string name;
            if (curUser.name != "") { name = curUser.name; }
            else name = curUser.login;
            int time = Convert.ToInt32(DateTime.Now.ToString("HH"));
            if (time <= 4)
                return $"Доброй ночи, {name}";
            else if (time <= 11)
                return $"Доброе утро, {name}";
            else if (time <= 17)
                return $"Добрый день, {name}";
            else return $"Добрый вечер, {name}";
        }
        private void createProjectButtonFirst_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<CreateProjectForm>().FirstOrDefault() != null) return;
            CreateProjectForm createProjectForm = new CreateProjectForm(this);
            createProjectForm.Show();
        }
        private void userAccountButton_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(curUser);
            userForm.Show();
            this.Hide();
        }
    }
}
