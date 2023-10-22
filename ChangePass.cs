using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using TikTask.Properties;

namespace TikTask
{
    public partial class ChangePass : Form
    {
        User curUser;
        public ChangePass(User curUser)
        {
            InitializeComponent();
            this.curUser = curUser;
            this.Location = new Point(Cursor.Position.X, Cursor.Position.Y);
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
        private void changePassButton_Click(object sender, EventArgs e)
        {
            if (CheckCondition()) 
            {
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `users` SET `password` = @newPass WHERE `id` = @userID", db.getConnection());
                command.Parameters.Add("@newPass", MySqlDbType.VarChar).Value = newPassField1.Text;
                command.Parameters.Add("@userID", MySqlDbType.Int32).Value = curUser.id;
                db.openConnection();
                command.ExecuteNonQuery();
                db.closeConnection();
                this.Close();
            }
        }
        private bool CheckCondition() 
        {
            if (oldPassField.Text == "" || newPassField1.Text == "" || newPassField2.Text == "") 
            { 
                MessageBox.Show("Пожалуйста, заполните обязательные поля.");
                return false;
            }
            if (newPassField1.Text != newPassField2.Text) 
            {
                MessageBox.Show("Пароли не совпадают.");
                return false;
            }
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT `password` FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = curUser.login;
            db.openConnection();
            if (command.ExecuteScalar().ToString() != oldPassField.Text) 
            {
                MessageBox.Show("Старый пароль неверен.");
                return false;
            }
            db.closeConnection();
            return true;
        }
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Resources.closeDark16;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Resources.closeLight32;
        }
    }
 
}
