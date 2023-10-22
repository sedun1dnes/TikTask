using System;
using System.Drawing;
using System.Windows.Forms;

namespace TikTask
{
    public partial class CreateProjectForm : Form
    {
        MainForm main;
        public CreateProjectForm(MainForm main)
        {
            this.main = main;
            InitializeComponent();
            Location = new Point(Cursor.Position.X, Cursor.Position.Y);
        }
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
        private void createProjectButton_Click(object sender, EventArgs e)
        {
            Project newProject = new Project(main, nameField.Text, startDatePicker.Value, finishDatePicker.Value, main.curUser.id);
            newProject.PushToDB();
            main.UpdateProjects();
            this.Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
