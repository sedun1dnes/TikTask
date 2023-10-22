using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TikTask.Properties;
using System.IO;

namespace TikTask
{
    public partial class TaskForm : Form
    {
        public Task task;
        Project project;
        LabelForm labelForm;
        public TaskForm(Task task)
        {
            this.task = task;
            InitializeComponent();
            taskNameLabel.Text = task.name;
            Stage stage = new Stage(task.stage);
            project = new Project(stage.project);
            if (task.responsible != null) label7.Text = task.responsible;
            if (task.startDate != DateTime.MinValue) label12.Text = task.startDate.ToString().Split()[0];
            if (task.finishDate != DateTime.MinValue) label13.Text = task.finishDate.ToString().Split()[0];
            stageNameLabel.Text = stage.name;
            projectNameLabel.Text = project.name;
            if (task.description != null) descriptionBox.Text = task.description;
            DataTable tags = task.GetTasksTags();
            foreach (DataRow tagRow in tags.Rows)
            {
                Tag tag = new Tag(tagRow["label"].ToString());
                Panel tagPanel = tag.GetBigLabelPreview();
                tagsFlowLayout.Controls.Add(tagPanel);
            }
            UpdateAttachedFiles();
            labelForm = new LabelForm(task);
        }
        public void UpdateResponsible()
        {
            label7.Text = task.responsible;
        }
        public void UpdateDates()
        {
            label12.Text = task.startDate.ToString().Split()[0];
            label13.Text = task.finishDate.ToString().Split()[0];
        }
        public void UpdateTags()
        {
            tagsFlowLayout.Controls.Clear();
            tagsFlowLayout.Controls.Add(addLabel);
            DataTable tags = task.GetTasksTags();
            foreach (DataRow tagRow in tags.Rows)
            {
                Tag tag = new Tag(tagRow["label"].ToString());
                Panel tagPanel = tag.GetBigLabelPreview();
                tagsFlowLayout.Controls.Add(tagPanel);
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void editNameButton_MouseEnter(object sender, EventArgs e)
        {
            editNameButton.Image = Resources.editDark32;
        }
        private void editNameButton_MouseLeave(object sender, EventArgs e)
        {
            editNameButton.Image = Resources.editLight32;
        }
        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            deleteButton.Image = Resources.deleteDark321;
        }
        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.Image = Resources.deleteLight321;
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Resources.closeDark32;
        }
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Resources.closeLight32;
        }
        private void addResponsButton_MouseEnter(object sender, EventArgs e)
        {
            addResponsButton.Image = Resources.add_user_dark;
        }
        private void addResponsButton_MouseLeave(object sender, EventArgs e)
        {
            addResponsButton.Image = Resources.add_user_light;
        }
        private void editFinishDateButton_MouseEnter(object sender, EventArgs e)
        {
            editFinishDateButton.Image = Resources.editDark32;
        }
        private void editFinishDateButton_MouseLeave(object sender, EventArgs e)
        {
            editFinishDateButton.Image = Resources.editLight32;
        }
        private void editStageButton_MouseEnter(object sender, EventArgs e)
        {
            editStageButton.Image = Resources.editDark32;
        }
        private void editStageButton_MouseLeave(object sender, EventArgs e)
        {
            editStageButton.Image = Resources.editLight32;
        }
        private void addAttachmentButton_MouseEnter(object sender, EventArgs e)
        {
            addAttachmentButton.Image = Resources.addDark32;
        }
        private void addAttachmentButton_MouseLeave(object sender, EventArgs e)
        {
            addAttachmentButton.Image = Resources.addLight32;
        }

        private void addResponsButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddRespForm>().Count() > 0) return;
            AddRespForm form = new AddRespForm(task, this);
            form.Show();
        }

        private void editFinishDateButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<AddDateForm>().Count() > 0) return;
            AddDateForm form = new AddDateForm(task, this);
            form.Show();
        }
        ComboBox stages;
        private void editStageButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT `project` FROM `stages` WHERE `id` = @sI", db.getConnection());
            command.Parameters.Add("@sI", MySqlDbType.Int32).Value = task.stage;
            db.openConnection();
            object projId = command.ExecuteScalar();
            db.closeConnection();
            Project project = new Project(projId.ToString());
            DataTable stagesTable = project.GetProjectsStages();
            List<TagBoxElem> stagesList = new List<TagBoxElem>();
            foreach (DataRow row in stagesTable.Rows)
            {
                stagesList.Add(new TagBoxElem(row));
            }
            stages = new ComboBox();
            stages.ValueMember = "id";
            stages.Location = new Point(313, 143);
            stages.Size = new Size(117, 24);
            stages.DataSource = stagesList;
            stages.Text = stageNameLabel.Text;
            stages.Font = new Font("Century Gothic", 10);
            Controls.Add(stages);
            stages.BringToFront();
            stages.KeyPress += (sender2, e2) => 
            {
                if (e2.KeyChar == (char)Keys.Enter)
                {
                    task.UpdateStage(((TagBoxElem)stages.SelectedValue).id);
                    stageNameLabel.Text = stages.SelectedItem.ToString();
                    ProjectForm projectForm = Application.OpenForms.OfType<ProjectForm>().FirstOrDefault();
                    projectForm.UpdateProjectView();
                    Controls.Remove(stages);
                }
            };

        }


        private void editDescription_Click(object sender, EventArgs e)
        {
            descriptionBox.ReadOnly = false;
            descriptionBox.Enabled = true;
        }

        private void saveDescription_Click(object sender, EventArgs e)
        {
            descriptionBox.ReadOnly = true;
            descriptionBox.Enabled = false;
            task.description = descriptionBox.Text;
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `tasks` SET `description` = @tD WHERE `id` = @tI", db.getConnection());
            command.Parameters.Add("@tD", MySqlDbType.LongText).Value = descriptionBox.Text;
            command.Parameters.Add("@tI", MySqlDbType.LongText).Value = task.id;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
        }

        private void editDescription_MouseEnter(object sender, EventArgs e)
        {
            editDescription.Image = Resources.editDark32;
        }

        private void editDescription_MouseLeave(object sender, EventArgs e)
        {
            editDescription.Image = Resources.editLight32;
        }

        private void saveDescription_MouseEnter(object sender, EventArgs e)
        {
            saveDescription.Image = Resources.saveDark;
        }

        private void saveDescription_MouseLeave(object sender, EventArgs e)
        {
            saveDescription.Image = Resources.saveLight32;
        }

        private void addLabel_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<LabelForm>().Count() > 0) Application.OpenForms.OfType<LabelForm>().FirstOrDefault().Show();
            labelForm = new LabelForm(task);
            labelForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить задачу?", "Подтверждение удаления", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                task.Delete();
                ProjectForm openedPF = Application.OpenForms.OfType<ProjectForm>().FirstOrDefault();
                openedPF.UpdateProjectView();
                this.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }
        }

        private void editNameButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(taskNameLabel);
            TextBox taskNameField;
            taskNameField = new TextBox();
            taskNameField.Font = new Font("Century Gothic", 16);
            taskNameField.Location = new Point(58, 5);
            taskNameField.Size = new Size(286, 37);
            taskNameField.Text = task.name;
            taskNameField.KeyPress += (sender2, e2) =>
            {
                if (e2.KeyChar == (char)Keys.Enter)
                {
                    task.UpdateName(taskNameField.Text);
                    taskNameLabel.Text = task.name;
                    Controls.Add(taskNameLabel);
                    Controls.Remove(taskNameField);
                    if (Application.OpenForms.OfType<ProjectForm>().Count() != 0) Application.OpenForms.OfType<ProjectForm>().FirstOrDefault().UpdateProjectView();
                }
            };
            this.Controls.Add(taskNameField);
        }
        private void addAttachmentButton_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog1.FileNames)
                {
                    byte[] fileData = File.ReadAllBytes(filePath);
                    SaveFileToDatabase(filePath.Split('\\').Last(), fileData);
                }
            }
            UpdateAttachedFiles();
        }
        private void SaveFileToDatabase(string fileName, byte[] fileData)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `attachments` (`name`, `data`, `task`) VALUES (@aN, @aD, @aT)", db.getConnection());
            command.Parameters.Add("@aN", MySqlDbType.VarChar).Value = fileName;
            command.Parameters.Add("@aD", MySqlDbType.LongBlob).Value = fileData;
            command.Parameters.Add("@aT", MySqlDbType.Int32).Value = task.id;
            db.openConnection();
            try { command.ExecuteNonQuery(); }
            catch
            {
                MessageBox.Show("Превышен допустимый размер файла");
            }
            db.closeConnection();
        }
        private void UpdateAttachedFiles()
        {
            attachmentsFlowLayout.Controls.Clear();
            foreach (DataRow attachmentRow in task.GetAttachments().Rows)
            {
                Attachment file = new Attachment(attachmentRow);
                attachmentsFlowLayout.Controls.Add(file.GetAttachmentPreview());
            }
        }
        private void addLabel_MouseEnter(object sender, EventArgs e)
        {
            addLabel.Image = Resources.addDark32;
        }

        private void addLabel_MouseLeave(object sender, EventArgs e)
        {
            addLabel.Image = Resources.addLight;
        }
    }
}
