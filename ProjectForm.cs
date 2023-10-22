using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TikTask.Properties;

namespace TikTask
{
    public partial class ProjectForm : Form
    {
        public Project curProject;
        TextBox stageName;
        public ProjectForm(Project project)
        {
            InitializeComponent();
            this.curProject = project;
            nameLabel.Text = curProject.name;
            stagesPanel.Controls.Remove(addStageButton);
            foreach (DataRow stage in curProject.GetProjectsStages().Rows) 
            {
                Stage new_stage = new Stage(stage);
                FlowLayoutPanel new_stagePanel = new_stage.GetStagePanel(stagesPanel.Height - 50);
                foreach (DataRow task in new_stage.GetStagesTasks().Rows) 
                {
                    Task new_task = new Task(task);
                    Panel new_taskPanel = new_task.GetExistingTaskPreviewPanel(true);
                    new_stagePanel.Controls.Add(new_taskPanel);
                }
                stagesPanel.Controls.Add(new_stagePanel);
            }
            stagesPanel.Controls.Add(addStageButton);
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
        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            mainForm.Show();
        }
        private void addStageButton_Click(object sender, EventArgs e)
        {
            stageName = new TextBox();
            stageName.KeyPress += (sender2, e2) => 
            {
                if (e2.KeyChar == (char)Keys.Enter)
                {
                    Stage stage = new Stage(curProject.main, this, stageName.Text, curProject.host, null);
                    stage.PushToDB(stageName);
                    stagesPanel.Controls.Add(stage.GetStagePanel(stagesPanel.Height - 50));
                    stagesPanel.Controls.Remove(stageName);
                    stagesPanel.Controls.Add(addStageButton);
                    stagesPanel.Controls.Add(addStageButton);
                }
            };
            stageName.Width = 300;
            stageName.Height = 30;
            stageName.Font = new Font("Century Gothic", 12);
            stagesPanel.Controls.Remove(addStageButton);
            stagesPanel.Controls.Add(stageName);
        }

        public void UpdateProjectView() 
        {
            if (visualTabs.SelectedTab == tabPage3)
            {
                dayTaskFlowLayout.Controls.Clear();
                noDeadlineTasksLayout.Controls.Clear();
                MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                DataTable tasks = main.curUser.GetUserTasksByDate(DateTime.Today);
                if (tasks.Rows.Count == 0) dayTaskFlowLayout.Controls.Add(zeroTaskLabel);
                foreach (DataRow row in tasks.Rows)
                {
                    Task newTask = new Task(row);
                    dayTaskFlowLayout.Controls.Add(newTask.GetExistingTaskPreviewPanel(false));
                }
                tasks = main.curUser.GetUserTasksByDate(DateTime.MinValue);
                foreach (DataRow row in tasks.Rows)
                {
                    Task newTask = new Task(row);
                    noDeadlineTasksLayout.Controls.Add(newTask.GetExistingTaskPreviewPanel(false));
                }
            }
            stagesPanel.Controls.Clear();
            foreach (DataRow stage in curProject.GetProjectsStages().Rows)
            {
                Stage new_stage = new Stage(stage);
                FlowLayoutPanel new_stagePanel = new_stage.GetStagePanel(stagesPanel.Height - 50);
                foreach (DataRow task in new_stage.GetStagesTasks().Rows)
                {
                    Task new_task = new Task(task);
                    Panel new_taskPanel = new_task.GetExistingTaskPreviewPanel(true);
                    new_stagePanel.Controls.Add(new_taskPanel);
                }
                stagesPanel.Controls.Add(new_stagePanel);
            }
            stagesPanel.Controls.Add(addStageButton);
        }
        private void inviteUserButton_MouseEnter(object sender, EventArgs e)
        {
            inviteUserButton.Image = Resources.inviteDark;
        }

        private void inviteUserButton_MouseLeave(object sender, EventArgs e)
        {
            inviteUserButton.Image = Resources.inviteLight;
        }

        private void inviteUserButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<InviteUserForm>().FirstOrDefault() != null) Application.OpenForms.OfType<InviteUserForm>().FirstOrDefault().Show(); ;
            MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            InviteUserForm inviteForm = new InviteUserForm(main.curUser, curProject);
            inviteForm.Show();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            taskDateLabel.Text = $"Задачи на {monthCalendar.SelectionEnd.ToString().Split()[0]}";
            dayTaskFlowLayout.Controls.Clear();
            MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            DataTable tasks = main.curUser.GetUserTasksByDate(DateTime.Parse(monthCalendar.SelectionEnd.ToString().Split()[0]));
            if (tasks.Rows.Count == 0) dayTaskFlowLayout.Controls.Add(zeroTaskLabel);
            foreach (DataRow row in tasks.Rows)
            {
                Task newTask = new Task(row);
                dayTaskFlowLayout.Controls.Add(newTask.GetExistingTaskPreviewPanel(false));
            }
            noDeadlineTasksLayout.Controls.Clear();
            tasks = main.curUser.GetUserTasksByDate(DateTime.MinValue);
            foreach (DataRow row in tasks.Rows)
            {
                Task newTask = new Task(row);
                noDeadlineTasksLayout.Controls.Add(newTask.GetExistingTaskPreviewPanel(false));
            }
        }
        
        private void visualTabs_Selected(object sender, TabControlEventArgs e)
        {
            if (visualTabs.SelectedTab == tabPage3) 
            {
                dayTaskFlowLayout.Controls.Clear();
                taskDateLabel.Text = $"Задачи на {DateTime.Today.ToString().Split()[0]}";
                MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                DataTable tasks = main.curUser.GetUserTasksByDate(DateTime.Today);
                if (tasks.Rows.Count == 0) dayTaskFlowLayout.Controls.Add(zeroTaskLabel);
                foreach (DataRow row in tasks.Rows)
                {
                    Task newTask = new Task(row);
                    dayTaskFlowLayout.Controls.Add(newTask.GetExistingTaskPreviewPanel(false));
                }
                noDeadlineTasksLayout.Controls.Clear();
                tasks = main.curUser.GetUserTasksByDate(DateTime.MinValue);
                foreach (DataRow row in tasks.Rows)
                {
                    Task newTask = new Task(row);
                    noDeadlineTasksLayout.Controls.Add(newTask.GetExistingTaskPreviewPanel(false));
                }
            }
            if (visualTabs.SelectedTab == tabPage4)
            {
                tagsFlowLayout.Controls.Clear();
                tasksFlowLayout.Controls.Clear();
                DataTable tags = curProject.GetProjectLabels();
                foreach (DataRow tagRow in tags.Rows) 
                {
                    Tag tag = new Tag(tagRow);
                    tagsFlowLayout.Controls.Add(tag.GetLabelPanel());
                }

            }
        }
        public void FillTasksPanel(Panel taskCard) 
        {
            foreach (Panel panel in tasksFlowLayout.Controls) 
            {
                if (taskCard.Tag.ToString() == panel.Tag.ToString()) return;
            }
            tasksFlowLayout.Controls.Add(taskCard);
        }
        public void DeleteTasksByTag(DataTable tasks) 
        {
            foreach (DataRow taskRow in tasks.Rows)
            {
                foreach (Panel panel in tasksFlowLayout.Controls)
                {
                    if (panel.Tag.ToString() == taskRow["task"].ToString()) 
                    {
                        tasksFlowLayout.Controls.Remove(panel);
                    }
                }
            }
        }
        public void DeleteTagPanel(string id) 
        {
            foreach (Panel panel in tagsFlowLayout.Controls) 
            {
                if (panel.Tag.ToString() == id) 
                {
                    foreach (Panel taskPanel in tasksFlowLayout.Controls) 
                    {
                        if (taskPanel.Tag.ToString() == id) 
                        {
                            tasksFlowLayout.Controls.Remove(taskPanel);
                        }
                    }
                    tagsFlowLayout.Controls.Remove(panel);
                    UpdateProjectView();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            NewLabelForm labelForm = new NewLabelForm();
            labelForm.Show();
            UpdateProjectView();
        }
        private void editProjectButton_Click(object sender, EventArgs e)
        {
            if (projectPanel.Controls.OfType<TextBox>().Count() != 0) return;
            TextBox editProjectField = new TextBox();
            editProjectField.Size = nameLabel.Size;
            editProjectField.Text = nameLabel.Text;
            editProjectField.Location = nameLabel.Location;
            editProjectField.Font = nameLabel.Font;
            projectPanel.Controls.Remove(nameLabel);
            projectPanel.Controls.Add(editProjectField);
            editProjectField.KeyPress += (sender2, e2) =>
            {
                if (e2.KeyChar == (char)Keys.Enter)
                {
                    curProject.EditName(editProjectField.Text);
                    nameLabel.Text = editProjectField.Text;
                    projectPanel.Controls.Remove(editProjectField);
                    projectPanel.Controls.Add(nameLabel);
                    MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                    main.UpdateProjects();
                }
            };
        }

        private void editProjectButton_MouseEnter(object sender, EventArgs e)
        {
            editProjectButton.Image = Resources.editDark32;
        }

        private void editProjectButton_MouseLeave(object sender, EventArgs e)
        {
            editProjectButton.Image = Resources.editLight32;
        }

        private void deleteProjectButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить проект?", "Подтверждение удаления", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                curProject.Delete();
                MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
                main.UpdateProjects();
                main.UpdateTasks();
                main.Show();
                this.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void deleteProjectButton_MouseEnter(object sender, EventArgs e)
        {
            deleteProjectButton.Image = Resources.deleteDark321;
        }

        private void deleteProjectButton_MouseLeave(object sender, EventArgs e)
        {
            deleteProjectButton.Image = Resources.deleteLight321;
        }
    }
}
