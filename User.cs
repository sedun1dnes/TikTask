using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace TikTask
{
    public class User
    {
        public string id, name, surname, login, mail;
        public User(string id = null, string name = null, string surname = null, string login = null, string mail = null) 
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.mail = mail;
        }
        public User(string id) 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `id` = @userID", db.getConnection());
            command.Parameters.Add("@userID", MySqlDbType.Int32).Value = id;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();
            this.id = id;
            foreach (DataRow row in table.Rows)
            {
                this.mail = row["mail"].ToString();
                this.name = row["name"].ToString();
                this.surname = row["surname"].ToString();
                this.login = row["login"].ToString();
            }
        }
        public DataTable GetUserTasks() 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tasks` WHERE `responsible` = @uM", db.getConnection());
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            command.Parameters.Add("@uM", MySqlDbType.VarChar).Value = mail;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public DataTable GetUserTasksByDate(DateTime date) 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `tasks` WHERE `finishDate` = @finDate AND `responsible` = @userMail", db.getConnection());
            command.Parameters.Add("@finDate", MySqlDbType.DateTime).Value = date;
            command.Parameters.Add("@userMail", MySqlDbType.VarChar).Value = mail;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            db.openConnection();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }
        public bool AddUser(TextBox login, TextBox pass, TextBox name, TextBox surname, TextBox mail) 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `name`, `surname`, `mail`) VALUES (@uL, @uP, @uN, @uS, @uM);", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = pass.Text;
            command.Parameters.Add("@uN", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@uS", MySqlDbType.VarChar).Value = surname.Text;
            command.Parameters.Add("@uM", MySqlDbType.VarChar).Value = mail.Text;

            this.name = name.Text;
            this.surname = surname.Text;
            this.login = login.Text;
            this.mail = mail.Text;


            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {     
                db.closeConnection();
                id = command.LastInsertedId.ToString();
                return true;
            }
            else
                db.closeConnection();
                return false;
                
        }
        public void ChangeName(string newName) 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `name` = @newName WHERE `id` = @userID", db.getConnection());
            command.Parameters.Add("@newName", MySqlDbType.VarChar).Value = newName;
            name = newName;
            command.Parameters.Add("userID", MySqlDbType.Int32).Value = id;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public void ChangeSurname(string newSurname)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `surname` = @newSurname WHERE `id` = @userID", db.getConnection());
            command.Parameters.Add("@newSurname", MySqlDbType.VarChar).Value = newSurname;
            surname = newSurname;
            command.Parameters.Add("userID", MySqlDbType.Int32).Value = id;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public void ChangePassword(string newPass) 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `password` = @newPass WHERE `id` = @userID", db.getConnection());
            command.Parameters.Add("@newPass", MySqlDbType.VarChar).Value = newPass;
            command.Parameters.Add("userID", MySqlDbType.Int32).Value = id;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
        }
        public DataTable GetUserNotifications() 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `notification` WHERE `receiver` = @userID", db.getConnection());
            command.Parameters.Add("@userID", MySqlDbType.Int32).Value = id;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();
            return table;
        }
        public DataTable GetUserProjects()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `involved` WHERE `user` = @user", db.getConnection());
            command.Parameters.Add("@user", MySqlDbType.Int32).Value = id;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

    }
}
