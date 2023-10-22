using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TikTask
{
    public partial class NewLabelForm : Form
    {
        Color color;
        public NewLabelForm()
        {
            InitializeComponent();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setLabelButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `labels` (`name`, `project`, `color`) VALUES (@lN, @lP, @lC)", db.getConnection());
            command.Parameters.Add("@lN", MySqlDbType.VarChar).Value = newTagNameTextBox.Text;
            ProjectForm pForm = Application.OpenForms.OfType<ProjectForm>().FirstOrDefault();
            command.Parameters.Add("@lP", MySqlDbType.Int32).Value = pForm.curProject.id;
            command.Parameters.Add("@lC", MySqlDbType.VarChar).Value = color.ToArgb().ToString();
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                color = colorDialog1.Color;
                colorPreview.BackColor = color;
            }
        }
    }
}
