using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTask
{
    public class Notification
    {
        public string id, receiver, message, sender, project;
        public bool received;
        public Notification(string id) 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `notification` WHERE `id` = @notID", db.getConnection());
            command.Parameters.Add("@notID", MySqlDbType.Int32).Value = id;
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            db.openConnection();
            adapter.Fill(table);
            db.closeConnection();
            this.id = id;
            foreach (DataRow row in table.Rows) 
            {
                this.receiver = row["receiver"].ToString();
                this.message = row["message"].ToString();
                this.sender = row["sender"].ToString();
                this.project = row["project"].ToString();
                this.received = Convert.ToBoolean(row["received"]);
            }
        }
        public Panel GetInvitationNotificationPanel() 
        {
            Panel notPanel = new Panel();
            notPanel.Size = new Size(350, 30);
            Label notLabel = new Label();
            User senUser = new User(sender);
            Project projectObj = new Project(project);
            notLabel.Text = $"{senUser.mail} приглашает вас присоединиться к проекту \"{projectObj.name}\"";
            notLabel.AutoEllipsis = true;
            notLabel.Size = new Size(255, 30);
            notLabel.Font = new Font("Century Gothic", 8);
            notLabel.Location = new Point(default, 5);
            notPanel.Controls.Add(notLabel);
            Button acceptButton = new Button();
            acceptButton.Cursor = Cursors.Hand;
            acceptButton.Text = "Принять";
            acceptButton.Font = new Font("Century Gothic", 8);
            acceptButton.Size = new Size(60, 22);
            acceptButton.Click += (sender, e) =>
            {
                received = true;
                DB db = new DB();
                MySqlCommand command = new MySqlCommand("UPDATE `notification` SET `received` = @status WHERE `id` = @notID", db.getConnection());
                command.Parameters.Add("@status", MySqlDbType.Int32).Value = received;
                command.Parameters.Add("@notID", MySqlDbType.Int32).Value = id;
                db.openConnection();
                command.ExecuteNonQuery();
                command = new MySqlCommand("INSERT INTO `involved` (`project`, `user`) VALUES (@projectID, @userID)", db.getConnection());
                command.Parameters.Add("@projectID", MySqlDbType.Int32).Value = projectObj.id;
                command.Parameters.Add("@userID", MySqlDbType.Int32).Value = receiver;
                command.ExecuteNonQuery();
                db.closeConnection();
                UserForm uForm = Application.OpenForms.OfType<UserForm>().FirstOrDefault();
                uForm.Update();
            };
            notPanel.Controls.Add(acceptButton);
            acceptButton.Location = new Point(260, 1);
            return notPanel;
        }
        public void SetReceived() 
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("UPDATE `notification` SET `received` = @status WHERE `id` = @notID", db.getConnection());
            command.Parameters.Add("@status", MySqlDbType.Int32).Value = 1;
            this.received = true;
            command.Parameters.Add("@notID", MySqlDbType.Int32).Value = id;
            db.openConnection();
            command.ExecuteNonQuery();
            db.closeConnection();
        }
    }
}
