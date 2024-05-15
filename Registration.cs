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
            User user = new User(
                        fname.Text,
                        Lname.Text,
                        int.Parse(number.Text),
                        comboBoxGender.SelectedItem?.ToString(),
                        email.Text,
                        password.Text
                    );

            AddUser(user);

            login logIn = new login();
            logIn.Show();
            this.Hide();
        }
       

        public static void AddUser(User user)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

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
    }
}
