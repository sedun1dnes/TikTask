using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TikTask
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
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
        private void Register_Click(object sender, EventArgs e)
        {
            if (loginField_SA.Text == "" || passField_SA.Text == "" || mailField_SA.Text == "" ) 
            { 
                MessageBox.Show("Пожалуйста, заполните обязательные поля");
                return;
            }
            if (IsUserExist() || IsMailExist()) { return; }
            User newUser = new User();
            if (newUser.AddUser(loginField_SA, passField_SA, nameField_SA, surnameField_SA, mailField_SA)) 
            {
                MessageBox.Show("Аккаунт создан.");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
            else
                MessageBox.Show("Что-то пошло не так");
        }
        public bool IsUserExist() 
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField_SA.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Логин уже занят");
                return true;
            }
            else
                return false;
        }

        public bool IsMailExist()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `mail` = @uM", db.getConnection());

            command.Parameters.Add("@uM", MySqlDbType.VarChar).Value = mailField_SA.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с такой почтой уже существует.");
                return true;
            }
            else
                return false;
        }
        private void backToLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Application.OpenForms.OfType<LoginForm>().Count() > 0) Application.OpenForms.OfType<LoginForm>().FirstOrDefault().Show();
            else 
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }

}
