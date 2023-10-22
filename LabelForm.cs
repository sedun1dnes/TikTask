using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TikTask
{
    public partial class LabelForm : Form
    {
        Task task;
        public LabelForm(Task task)
        {
            this.task = task;
            this.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
            InitializeComponent();
            List<TagBoxElem> labelsBoxSource = new List<TagBoxElem>();
            foreach (DataRow labelRow in task.GetProject().GetProjectLabels().Rows)
            {
                labelsBoxSource.Add(new TagBoxElem(labelRow));
            }
            labelsBox.ValueMember = "id";
            labelsBox.DataSource = labelsBoxSource;
        }

        private void newLabelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewLabelForm nLF = new NewLabelForm();
            nLF.Location = this.Location;
            nLF.Show();
        }

        private void setLabelButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `task-label` (`task`, `label`) VALUES (@t, @l)", db.getConnection());
            command.Parameters.Add("@t", MySqlDbType.VarChar).Value = task.id;
            command.Parameters.Add("@l", MySqlDbType.Int32).Value = ((TagBoxElem)labelsBox.SelectedValue).id;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            this.Close();
            TaskForm openedTF = Application.OpenForms.OfType<TaskForm>().FirstOrDefault();
            openedTF.UpdateTags();
            if (Application.OpenForms.OfType<ProjectForm>().FirstOrDefault() != null) Application.OpenForms.OfType<ProjectForm>().FirstOrDefault().UpdateProjectView();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
