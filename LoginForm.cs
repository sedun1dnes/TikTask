using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TikTask
{
    public partial class LoginForm : Form
    {
        public LoginForm()
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
        private void Login_Click(object sender, EventArgs e)
        {
            string login = loginField.Text;
            string pass = passField.Text;

            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                string i = table.Rows[0][0].ToString();
                string l = table.Rows[0][1].ToString();
                string n = table.Rows[0][3].ToString();
                string s = table.Rows[0][4].ToString();
                string m = table.Rows[0][5].ToString();
                User user = new User(i, n, s, l, m);
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }
        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }       
    }
}
