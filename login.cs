using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string name = username.Text;
            string pass = password.Text;

            if (name == "admin" && pass == "x")
            {
                Form1 content = new Form1();

                // Show Form2
                content.Show();

                this.Hide();
            }
            else {
                MessageBox.Show("Invalid username or password. Please try again.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Clear the username and password fields (optional)
                username.Text = "";
                password.Text = "";
            }
        }
    }
}
