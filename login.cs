using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            panel3.soundedCorners(35);
            SetButtonRoundedCorners(loginbtn);
        }
        public login()
        {

            InitializeComponent();
            panel3.soundedCorners(35);
            SetButtonRoundedCorners(loginbtn);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            string enteredEmail = email.Text;
            string enteredPassword = password.Text;

        
            errorEmail.Text = "";
            errorPass.Text = "";

          
            if (string.IsNullOrWhiteSpace(enteredEmail))
            {
                errorEmail.Text = "Email cannot be empty.";
                return;  
            }

           
            if (!IsValidEmail(enteredEmail))
            {
                errorEmail.Text = "Please enter a valid email address.";
                return;  
            }

           
            if (string.IsNullOrWhiteSpace(enteredPassword))
            {
                errorPass.Text = "Password cannot be empty.";
                return; 
            }

            User foundUser = GetUserByEmail(enteredEmail);
            if (foundUser != null)
            {
                if (foundUser.Password == enteredPassword)
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
                    password.Text = "";
                    errorPass.Text = "Incorrect password.";
                }
            }
            else
            {
                email.Text = "";
                password.Text = "";
                MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
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

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetButtonRoundedCorners(Button button)
        {
            int radius = 20; 
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddLine(radius, 0, button.Width - radius, 0);
            path.AddArc(new Rectangle(button.Width - radius, 0, radius, radius), -90, 90);
            path.AddLine(button.Width, radius, button.Width, button.Height - radius);
            path.AddArc(new Rectangle(button.Width - radius, button.Height - radius, radius, radius), 0, 90);
            path.AddLine(button.Width - radius, button.Height, radius, button.Height);
            path.AddArc(new Rectangle(0, button.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }

    }



    public static class RoundedCorners
    {
        public static void soundedCorners(this Panel panel, int borderRadius)
        {
            panel.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
                int diameter = borderRadius * 2;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y + bounds.Height - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Y + bounds.Height - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);

                using (Pen pen = new Pen(panel.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }
            };

            // Invalidate to ensure the panel is redrawn
            panel.Invalidate();
        }
    }
}


 