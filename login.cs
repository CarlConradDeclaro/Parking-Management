using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Parking
{
    public partial class login : Form
    {
        string userEmail;
        string userPassword;

        public login(string userEmail, string userPassword)
        {
            this.userEmail = userEmail;
            this.userPassword = userPassword;
            InitializeComponent();
        }
        public login()
        {

            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string enteredEmail = email.Text;
            string enteredPassword = password.Text;

            User foundUser = GetUserByEmail(enteredEmail);
            if (foundUser != null && foundUser.Password == enteredPassword)
            {
                InsertAdminLog((int)foundUser.Id, foundUser.FirstName + foundUser.LastName);
                var c = UserDetails.Instance;
                c.addUser(foundUser);
                Form1 content = new Form1();
                content.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.email.Text = "";
                password.Text = "";
            }
        }
        private void InsertAdminLog(int adminID, string adminName)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";
          
            string query = "INSERT INTO Admin_logs (adminID, adminName, timestamp) VALUES (@adminID, @adminName, GETDATE())";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@adminID", adminID);
                        command.Parameters.AddWithValue("@adminName", adminName);
                        command.ExecuteNonQuery();
                     }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public static User GetUserByEmail(string email)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM UsersData WHERE email = @Email";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Email", email);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new User
                        {
                            Id = (int)reader["id"],
                            FirstName = reader["firstName"].ToString(),
                            LastName = reader["lastName"].ToString(),
                            Pnumber = (string)reader["phoneNum"],
                            Gender = reader["gender"].ToString(),
                            Email = reader["email"].ToString(),
                            Password = reader["uPassword"].ToString()
                        };
                    }
                }
            }
            return null;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Registration register = new Registration();
            register.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
