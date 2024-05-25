using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Parking
{


    public partial class Registration : Form
    {
        string connectionString = ConnectionString.Instance.connectionString();
        public Registration()
        {
            InitializeComponent();

            setGenderItems();
            SetButtonRoundedCorners(createAccBtn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

            login logIn = new login();
            logIn.Show();
            this.Hide();

        }

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void number_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void setGenderItems()
        {//editGender
            comboBoxGender.Items.Add("MALE");
            comboBoxGender.Items.Add("FEMALE");
        }


        private void createAccBtn_Click(object sender, EventArgs e)
        {

            string firstname = fname.Text;
            string lastname = Lname.Text;
            string Password = password.Text;
            string Email = email.Text;
            string phoneNum = number.Text;
            string gender = comboBoxGender.SelectedItem?.ToString();


            bool hasError = false;


            string namePattern = @"^[a-zA-Z\s]+$";
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string phonePattern = @"^\d+$";


            if (isEmailInList(Email, connectionString))
                return;

            if (string.IsNullOrEmpty((firstname)) || !System.Text.RegularExpressions.Regex.IsMatch(firstname, namePattern))
            {
                errorLabelFN.Text = "Please enter a valid first name (letters only)";
                hasError = true;
            }
            else
            {
                errorLabelFN.Text = "";
            }


            if (string.IsNullOrWhiteSpace(lastname) || !System.Text.RegularExpressions.Regex.IsMatch(lastname, namePattern))
            {
                errorLabelLN.Text = "Please enter a valid last name (letters only)";
                hasError = true;
            }
            else
            {
                errorLabelLN.Text = "";
            }


            if (string.IsNullOrWhiteSpace(Password))
            {
                errorLabelPass.Text = "Please enter a specified value";
                hasError = true;
            }
            else
            {
                errorLabelPass.Text = "";
            }

            if (string.IsNullOrWhiteSpace(Email) || !System.Text.RegularExpressions.Regex.IsMatch(Email, emailPattern))
            {
                errorLabelEmail.Text = "Please enter a valid email address";
                hasError = true;
            }
            else
            {
                errorLabelEmail.Text = "";
            }

            if (string.IsNullOrWhiteSpace(phoneNum) || !System.Text.RegularExpressions.Regex.IsMatch(phoneNum, phonePattern))
            {
                errorLabelPhoneNum.Text = "Enter a valid phone number (digits only)";
                hasError = true;
            }
            else
            {
                errorLabelPhoneNum.Text = "";
            }

            if (string.IsNullOrWhiteSpace(gender))
            {
                errorLabelGender.Text = "Please select a gender";
                hasError = true;
            }
            else
            {
                errorLabelGender.Text = "";
            }

            if (!hasError)
            {

                User user = new User(

                    firstname,
                    lastname,
                    phoneNum,
                    gender,
                    Email,
                    Password
                );
                /*
                   InsertAdminLog((int)foundUser.Id, foundUser.FirstName + foundUser.LastName);
                    var c = UserDetails.Instance;
                    c.addUser(foundUser);
                    Form1 content = new Form1();
                    content.Show();
                    this.Hide();
                 */

                AddUser(user, connectionString);
                User foundUser = GetUserByEmail(Email);
                var c = UserDetails.Instance;
                c.addUser(foundUser);


                /*Form1 content = new Form1();
                content.Show();*/

                LoadingState load = new LoadingState();
                load.Show();
                
                InsertAdminLog(getAdminId(Email, connectionString), firstname + " " + lastname, connectionString);
                this.Hide();

            }
        }

        public User GetUserByEmail(string email)
        {

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
        public static void AddUser(User user, string connectionString)
        {

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sqlQuery = "INSERT INTO UsersData (firstName, lastName, phoneNum, gender, email, uPassword) VALUES (@FirstName, @LastName, @Pnumber, @Gender, @Email, @Password)";
                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("@FirstName", user.getFirstname());
                cmd.Parameters.AddWithValue("@LastName", user.getLastname());
                cmd.Parameters.AddWithValue("@Pnumber", user.getPnumber());
                cmd.Parameters.AddWithValue("@Gender", user.getGender());
                cmd.Parameters.AddWithValue("@Email", user.getEmail());
                cmd.Parameters.AddWithValue("@Password", user.getPassword());
                cmd.ExecuteNonQuery();
            }

        }

        private void InsertAdminLog(int adminID, string adminName, string connectionString)
        {

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

        private int getAdminId(string email, string connectionString)
        {
            string query = "SELECT id FROM UsersData WHERE email = @email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@email", email);
                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return 0;
                }
            }
        }

        private bool isEmailInList(string email, string connectionString)
        {

            string query = "SELECT id FROM UsersData WHERE email = @Email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        MessageBox.Show("Email already exist.", "Email In Use", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        return true;
                    }
                }
            }
            return false;
        }


        private void SetButtonRoundedCorners(Button button)
        {
            int radius = 20; // Radius for the rounded corners
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

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxGender_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel29_Paint(object sender, PaintEventArgs e)
        {
            /* this.Close();*/
        }

        private void panel29_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
