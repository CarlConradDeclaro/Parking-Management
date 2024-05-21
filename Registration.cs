using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

        public Registration()
        {
            InitializeComponent();

            setGenderItems();
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
        {
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


            string namePattern = @"^[a-zA-Z]+$";
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string phonePattern = @"^\d+$";


            if (string.IsNullOrWhiteSpace(firstname) || !System.Text.RegularExpressions.Regex.IsMatch(firstname, namePattern))
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
                errorLabelPhoneNum.Text = "Please enter a valid phone number (digits only)";
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

                AddUser(user, connectionString);
                var c = UserDetails.Instance;
                c.addUser(user);
                Form1 content = new Form1();
                content.Show();
                InsertAdminLog(getAdminId(Email, connectionString), firstname + " " + lastname, connectionString);
                this.Hide();
            }
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

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
