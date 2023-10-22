using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TikTask.Properties;

namespace TikTask
{
    public partial class UserForm : Form
    {
        User curUser;
        public UserForm(User curUser)
        {
            this.curUser = curUser;
            InitializeComponent();
            foreach (DataRow notRow in curUser.GetUserNotifications().Rows) 
            {
                Notification not = new Notification(notRow["id"].ToString());
                if (not.received == false) 
                {
                    notifFlowLayout.Controls.Add(not.GetInvitationNotificationPanel());
                }
            }
            nameLabel.Text = curUser.name;
            surnameLabel.Text = curUser.surname;
            loginLabel.Text = curUser.login;
            mailLabel.Text = curUser.mail;
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
        private void Update() 
        {
            notifFlowLayout.Controls.Clear();
            foreach (DataRow notRow in curUser.GetUserNotifications().Rows)
            {
                Notification not = new Notification(notRow["id"].ToString());
                if (not.received == false)
                {
                    notifFlowLayout.Controls.Add(not.GetInvitationNotificationPanel());
                }
            }
            nameLabel.Text = curUser.name;
            surnameLabel.Text = curUser.surname;
            loginLabel.Text = curUser.login;
            mailLabel.Text = curUser.mail;
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm main = Application.OpenForms.OfType<MainForm>().First();
            main.Show();
        }
        private void editNameButton_Click(object sender, EventArgs e)
        {
            TextBox nameField = new TextBox();
            nameField = new TextBox();
            nameField.Size = namePanel.Size;
            nameField.Location = namePanel.Location;
            nameField.Text = curUser.name;
            nameField.Font = new Font("Century Gothic", 10);
            nameField.KeyPress += (sender2, e2) =>
            {
                if (e2.KeyChar == (char)Keys.Enter)
                {
                    curUser.ChangeName(nameField.Text);
                    Controls.Remove(nameField);
                    Controls.Add(namePanel);
                    editNameButton.Click += editNameButton_Click;
                    Update();
                }
            };
            editNameButton.Click -= editNameButton_Click;
            Controls.Remove(namePanel);
            Controls.Add(nameField);
        }

        private void editSurnameButton_Click(object sender, EventArgs e)
        {
            TextBox surnameField = new TextBox();
            surnameField = new TextBox();
            surnameField.Size = surnamePanel.Size;
            surnameField.Location = surnamePanel.Location;
            surnameField.Text = curUser.surname;
            surnameField.Font = new Font("Century Gothic", 10);
            surnameField.KeyPress += (sender2, e2) =>
            {
                if (e2.KeyChar == (char)Keys.Enter)
                {
                    curUser.ChangeSurname(surnameField.Text);
                    Controls.Add(surnamePanel);
                    Controls.Remove(surnameField);
                    editSurnameButton.Click += editSurnameButton_Click;
                    Update();
                }
            };
            editSurnameButton.Click -= editSurnameButton_Click;
            Controls.Remove(surnamePanel);
            Controls.Add(surnameField);
        }
        private void editNameButton_MouseEnter(object sender, EventArgs e)
        {
            editNameButton.Image = Resources.editDark32;
        }

        private void editNameButton_MouseLeave(object sender, EventArgs e)
        {
            editNameButton.Image = Resources.editLight32;
        }

        private void editSurnameButton_MouseEnter(object sender, EventArgs e)
        {
            editSurnameButton.Image = Resources.editDark32;
        }

        private void editSurnameButton_MouseLeave(object sender, EventArgs e)
        {
            editSurnameButton.Image = Resources.editLight32;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm main = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            main.Update();
            main.Show();
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<ChangePass>().FirstOrDefault() != null) return;
            ChangePass changePassForm = new ChangePass(curUser);
            changePassForm.Show();
        }

        private void endSessionButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            (Application.OpenForms.OfType<MainForm>().FirstOrDefault()).Close();
            (Application.OpenForms.OfType<UserForm>().FirstOrDefault()).Close();
            if (Application.OpenForms.OfType<ProjectForm>().FirstOrDefault() != null) Application.OpenForms.OfType<ProjectForm>().FirstOrDefault().Close();

        }
    }
}
