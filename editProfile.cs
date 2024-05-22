using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class editProfile : Form
    {
        int Id = 0;
        Label AdminName;

        Label profileName;
        Label profileEmail;
        Label profilePhone;
        Label profileGender;
        Panel profileIcon;
        Button adminIcon;

        Image MaleIcon = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\defaultBoy.png");
        Image FemaleIcon = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\defaultGirl.png");
        Image adminIconMale = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\maleAdmin.png");
        Image adminIconFemale = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\femaleAdmin.png");

        public editProfile(int id, Panel profileicon, Button adminicon, Label adminName, Label profilename, Label profileemail, Label profilephone, Label profilegender, string firstname, string lastname, string email, string pnumber, string gender)
        {
            InitializeComponent();
            updateLable(id, firstname, lastname, email, pnumber, gender);
            AdminName = adminName;
            profileIcon = profileicon;
            adminIcon = adminicon;

            profileName = profilename;
            profileEmail = profileemail;
            profilePhone = profilephone;
            profileGender = profilegender;
            setGender();


            iconPanel.BackgroundImage = profileGender.Text == "MALE" ? MaleIcon : FemaleIcon;
        }

        public void updateLable(int id, string firstname, string lastname, string email, string pnumber, string gender)
        {
            editFirstname.Text = firstname;
            editLastname.Text = lastname;
            editEmail.Text = email;
            editPnum.Text = pnumber;
            editGender.Text = gender;
            Id = id;
        }

        private void setGender()
        {
            //editGender
            editGender.Items.Add("MALE");
            editGender.Items.Add("FEMALE");
        }

        private void editProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            string phonePattern = @"^\d+$";
            string namePattern = @"^[a-zA-Z\s]+$";
            int proceedAddItem = 0;


            if (!string.IsNullOrEmpty((editFirstname.Text)) && System.Text.RegularExpressions.Regex.IsMatch(editFirstname.Text, namePattern))
            {
                proceedAddItem++;
                errorFn.Text = "";
            }
            else
            {
                errorFn.Text = "Invalid firstname. Name should not be numeric.";
            }


            if (!string.IsNullOrEmpty((editLastname.Text)) && System.Text.RegularExpressions.Regex.IsMatch(editLastname.Text, namePattern))
            {
                proceedAddItem++;
                errorLn.Text = "";
            }
            else
            {
                errorLn.Text = "Invalid lastname. Name should not be numeric.";
            }


            if (System.Text.RegularExpressions.Regex.IsMatch(editEmail.Text, emailPattern))
            {
                proceedAddItem++;
                errorEmail.Text = "";
            }
            else
            {
                errorEmail.Text = "Please enter a valid email address";
            }

            if (!string.IsNullOrWhiteSpace(editPnum.Text) || !System.Text.RegularExpressions.Regex.IsMatch(editPnum.Text, phonePattern))
            {
                proceedAddItem++;
                errorPnum.Text = "";
            }
            else
            {
                errorPnum.Text = "Please enter a valid phone number (digits only)";
            }


            if (!string.IsNullOrWhiteSpace(editGender.SelectedItem?.ToString()))
            {
                proceedAddItem++;
                errorGender.Text = "";
            }
            else
            {
                errorGender.Text = "Please select a gender";
            }





            if (proceedAddItem == 5)
            {
                updateUserData(Id);
                profileIcon.BackgroundImage = profileGender.Text == "MALE" ? MaleIcon : FemaleIcon;
                adminIcon.Image = profileGender.Text == "MALE" ? adminIconMale : adminIconFemale;
            }

        }

        public void updateUserData(int id)
        {

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

            string sqlQuery = "UPDATE UsersData SET firstName = @FirstName, lastName = @LastName, phoneNum = @Pnumber, gender = @Gender, email = @Email WHERE Id = @Id";

            string firstName = editFirstname.Text;
            string lastName = editLastname.Text;
            string phoneNum = editPnum.Text;
            string gender = editGender.Text;
            string email = editEmail.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var userDatails = UserDetails.Instance;
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Pnumber", phoneNum);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Id", id);
                    connection.Open();

                    string pass = userDatails.getPassword();

                    userDatails.clearUser();

                    userDatails.addUser(new User(firstName, lastName, phoneNum, gender, email, pass));
                    userDatails.setId(Id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No data was updated. Please check the ID and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                AdminName.Text = userDatails.getFirstname();
                profileName.Text = userDatails.getFirstname() + " " + userDatails.getLastname();
                profileEmail.Text = userDatails.getEmail();
                profilePhone.Text = userDatails.getPhoneNum();
                profileGender.Text = userDatails.getGender();


            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
