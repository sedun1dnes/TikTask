using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using TikTask.Properties;

namespace TikTask
{
    public partial class InviteUserForm : Form
    {
        User curUser;
        Project curProject;
        public InviteUserForm(User curUser, Project project)
        {
            this.curUser = curUser;
            this.curProject = project;
            InitializeComponent();
            Location = new Point(Cursor.Position.X - this.Width, Cursor.Position.Y);
        }
        private void closeButton_Click(object sender, EventArgs e) { this.Close(); }
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

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Resources.closeDark32;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Resources.closeLight32;
        }

        private void inviteButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT `id` FROM `users` WHERE `mail` = @userMail", db.getConnection());
            command.Parameters.Add("@userMail", MySqlDbType.VarChar).Value = userMailField.Text;
            db.openConnection();
            if (command.ExecuteScalar() == null)
            {
                MessageBox.Show("Пользователь не найден");
                db.closeConnection();
            }
            else
            {
                string id = command.ExecuteScalar().ToString();
                db.closeConnection();
                command = new MySqlCommand("INSERT INTO `notification` (`receiver`, `message`, `sender`, `received`, `project`) VALUES (@receiver, @message, @sender, @received, @project)", db.getConnection());
                command.Parameters.Add("@receiver", MySqlDbType.Int32).Value = id;
                command.Parameters.Add("@message", MySqlDbType.LongText).Value = "Пользователь {sender} приглашает вас присоединиться к проекту";
                command.Parameters.Add("@sender", MySqlDbType.Int32).Value = curUser.id;
                command.Parameters.Add("@received", MySqlDbType.Int32).Value = 0;
                command.Parameters.Add("@project", MySqlDbType.Int32).Value = curProject.id;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
                MessageBox.Show("Приглашение отправлено");
                this.Close();
            }
        }
    }
}
