using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parking
{
    public partial class ParkingEntry : Form
    {
        private FlowLayoutPanel flowLayoutPanel2;
        ParkingRecordsManager prm = new ParkingRecordsManager();
        public event EventHandler ParkingRecordAdded;
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

        string imagePath1 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car1.png";
        string imagePath2 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car2.png";
        string Sloc;
        public ParkingEntry(FlowLayoutPanel flowLayoutPanel2)
        {
            InitializeComponent();
            this.flowLayoutPanel2 = flowLayoutPanel2;


            OccupiedArea();

            firstFloorPanel.Hide();
            secondFloorPanel.Hide();



        


        }


        public ParkingEntry()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //CALCULATE AMD VALIDATE HERE
            string platenum = plateNo.Text;
            string type = comboBoxType.SelectedItem?.ToString();
            string model = comboBoxModel.SelectedItem?.ToString();
            string s_loc = getSloc();
            string driverName = driver.Text;
            string phoneNUm = phoneNo.Text;
            DateTime currentDateTime = DateTime.Now;
            string ArrivalDate = currentDateTime.ToString("MM/dd/yyyy");
            string ArrivalTime = currentDateTime.ToString("hh:mm:ss tt");

            int proccedAddItem = 0;

            if (platenum != "")
            {
                proccedAddItem++;
                inValidPN.Text = "";
            }
            else
            {
                inValidPN.Text = "please enter specified value";
            }

            if (type != null)
            {
                proccedAddItem++;
                invalidT.Text = "";
            }
            else
            {
                invalidT.Text = "please enter specified value";
            }
            if (model != null)
            {
                proccedAddItem++;
                inValidM.Text = "";
            }
            else
            {
                inValidM.Text = "please enter specified value";
            }
            if (double.TryParse(driver.Text, out _))
            {
                invalidDriver.Text = "Invalid name";
            }
            else
            {

                invalidDriver.Text = "";
            }

            if (phoneNUm != "")
                if (!double.TryParse(phoneNo.Text, out _))
                {
                    invalidPhone.Text = "Please enter a valid numeric number";
                }
                else
                {
                    proccedAddItem++;
                    invalidPhone.Text = "";
                }
            else
            {
                proccedAddItem++;
                invalidPhone.Text = "";
            }


            if (proccedAddItem == 4)
            {
                ParkingRecord carDetails = new ParkingRecord(0, platenum.ToUpper(), type, model,
                    driverName, phoneNUm, ArrivalDate, ArrivalTime, "PARKED", s_loc);
                var parkingRecordsManager = ParkingRecordsManager.Instance;
                var records = parkingRecordsManager.GetAllParkingRecords();

                bool isAlreadyInList = false;

                foreach (var record in records)
                {
                    // Assuming Platenum uniquely identifies a parking record
                    if (record.PlateNumber.ToUpper() == platenum.ToUpper() && record.Status == "PARKED")
                    {
                        isAlreadyInList = true;
                        break;
                    }
                }

                if (!isAlreadyInList)
                {
                    if (getSloc() != null)
                    {
                        parkingRecordsManager.AddParkingRecord(carDetails);
                        ParkingRecordAdded?.Invoke(this, EventArgs.Empty);
                        invalid.Text = "Successfully added new Vehicle!";
                        invalid.ForeColor = Color.Chartreuse;
                        updateAvailability_query();

                    }
                    else
                        MessageBox.Show("Please select a slot area for this vehicle!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("OPPS!, Vehicle is already in the list", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                invalid.Text = "Invalid Fields";
                invalid.ForeColor = Color.Red;
            }
        }
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear existing items in comboBoxModel
            comboBoxModel.Items.Clear();
            string selectedItem = comboBoxType.SelectedItem?.ToString();
            var vehicleBrand = VehicleBrandMAnger.Instance;
            var VB = vehicleBrand.GetVB();
            foreach (var record in VB)
            {
                if (record.vehicleType == selectedItem)
                    comboBoxModel.Items.Add(record.vBrand);
            }
        }



        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ParkingEntry_Load(object sender, EventArgs e)
        {
            var vehiclemanger = VehicleManger.Instance;
            var VPM = vehiclemanger.GetVPM();
            foreach (var record in VPM)
            {
                comboBoxType.Items.Add(record.vehicleType);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            invalid.Text = "";
            inValidPN.Text = "";
            invalidT.Text = "";
            inValidM.Text = "";
            plateNo.Text = "";
            comboBoxType.Text = "";
            comboBoxModel.Text = "";
            driver.Text = "";
            phoneNo.Text = "";
        }
        private void dateDepart_ValueChanged(object sender, EventArgs e)
        {

        }



        private void updateAvailability_query()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string updateQuery = "UPDATE V_Slots SET availability = 0 WHERE s_loc = @s_loc";


                SqlCommand command = new SqlCommand(updateQuery, connection);

                try
                {

                    connection.Open();


                    command.Parameters.AddWithValue("@s_loc", getSloc());


                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        bool select = false;




        private void OccupiedArea()
        {

            Image image = Image.FromFile(imagePath1);
            Image image2 = Image.FromFile(imagePath2);


            if (isOccupied("BM-01"))
            {
                b01.Image = image2;
                labelB1.Text = "";
            }

            if (isOccupied("BM-02"))
            {
                b02.Image = image2;
                labelB2.Text = "";
            }
            if (isOccupied("BM-03"))
            {
                b03.Image = image2;
                labelB3.Text = "";
            }
            if (isOccupied("BM-04"))
            {
                b04.Image = image2;
                labelB4.Text = "";
            }

            if (isOccupied("BM-05"))
            {
                b05.Image = image2;
                labelB5.Text = "";
            }

            if (isOccupied("BM-06"))
            {
                b06.Image = image;
                labelB6.Text = "";
            }
            if (isOccupied("BM-07"))
            {
                b07.Image = image;
                labelB7.Text = "";
            }
            if (isOccupied("BM-08"))
            {
                b08.Image = image;
                labelB8.Text = "";
            }

            if (isOccupied("A-01"))
            {
                a01.Image = image;
                labela1.Text = "";
            }
            if (isOccupied("A-02"))
            {
                a02.Image = image;
                labela2.Text = "";
            }
            if (isOccupied("A-03"))
            {
                a03.Image = image;
                labela3.Text = "";
            }
            if (isOccupied("A-04"))
            {
                a04.Image = image;
                labela4.Text = "";
            }
            if (isOccupied("A-05"))
            {
                a05.Image = image;
                labela5.Text = "";
            }
            if (isOccupied("A-06"))
            {
                a06.Image = image;
                labela6.Text = "";
            }
            if (isOccupied("A-07"))
            {
                a07.Image = image;
                labela7.Text = "";
            }
            if (isOccupied("A-08"))
            {
                a08.Image = image;
                labela8.Text = "";
            }
            if (isOccupied("A-09"))
            {
                a09.Image = image;
                labela9.Text = "";
            }
            if (isOccupied("A-10"))
            {
                a10.Image = image;
                labela10.Text = "";
            }


        }

        private bool isOccupied(string slotName)
        {
            List<string> occupiedSlots = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT s_loc FROM V_Slots WHERE availability = 0";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            occupiedSlots.Add(reader["s_loc"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return occupiedSlots.Contains(slotName);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //basement
            basementPanel.Dock = DockStyle.Fill;
            panel5.Controls.Add(basementPanel);
            basementPanel.Show();

            firstFloorPanel.Dock = DockStyle.None;
            panel5.Controls.Remove(firstFloorPanel);
            firstFloorPanel.Hide();

            panel5.Controls.Remove(secondFloorPanel);
            secondFloorPanel.Dock = DockStyle.None;
            secondFloorPanel.Hide();


            a1 = true;
            a2 = true;
            a3 = true;
            a4 = true;
            a5 = true;
            a6 = true;
            a7 = true;
            a8 = true;
            a9 = true;
            a_10 = true;


            a01.Image = null;
            a02.Image = null;
            a03.Image = null;
            a04.Image = null;
            a05.Image = null;
            a06.Image = null;
            a07.Image = null;
            a08.Image = null;
            a09.Image = null;
            a10.Image = null;

            labela1.Text = "A-01";
            labela2.Text = "A-02";
            labela3.Text = "A-03";
            labela4.Text = "A-04";
            labela5.Text = "A-05";
            labela6.Text = "A-06";
            labela7.Text = "A-07";
            labela8.Text = "A-08";
            labela9.Text = "A-09";
            labela10.Text = "A-10";

            OccupiedArea();
            setSloc(null);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //firstfloor

            firstFloorPanel.Dock = DockStyle.Fill;
            panel5.Controls.Add(firstFloorPanel);
            firstFloorPanel.Show();


            panel5.Controls.Remove(basementPanel);
            basementPanel.Dock = DockStyle.None;
            basementPanel.Hide();

            panel5.Controls.Remove(secondFloorPanel);
            secondFloorPanel.Dock = DockStyle.None;
            secondFloorPanel.Hide();


            b1 = true;
            b2 = true;
            b3 = true;
            b4 = true;
            b5 = true;
            b6 = true;
            b7 = true;
            b8 = true;


            b01.Image = null;
            b02.Image = null;
            b03.Image = null;
            b04.Image = null;
            b05.Image = null;
            b06.Image = null;
            b07.Image = null;
            b08.Image = null;

            labelB1.Text = "BM-01";
            labelB2.Text = "BM-02";
            labelB3.Text = "BM-03";
            labelB4.Text = "BM-04";
            labelB5.Text = "BM-05";
            labelB6.Text = "BM-06";
            labelB7.Text = "BM-07";
            labelB8.Text = "BM-08";
            OccupiedArea();
            setSloc(null);


        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel5.Controls.Add(secondFloorPanel);
            secondFloorPanel.Dock = DockStyle.Fill;
            secondFloorPanel.Show();

            firstFloorPanel.Dock = DockStyle.None;
            panel5.Controls.Remove(firstFloorPanel);
            firstFloorPanel.Hide();

            panel5.Controls.Remove(basementPanel);
            basementPanel.Dock = DockStyle.None;
            basementPanel.Hide();


        }


        bool b1 = true;
        bool b2 = true;
        bool b3 = true;
        bool b4 = true;
        bool b5 = true;
        bool b6 = true;
        bool b7 = true;
        bool b8 = true;

        private void setSloc(string sloc)
        {
            Sloc = sloc;
        }
        private string getSloc()
        {
            return Sloc;
        }

        private void b01_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (b1)
            {
                b01.Image = image;
                labelB1.Text = "";
            }
            else
            {
                b01.Image = null;
                setSloc(null);
                labelB1.Text = "BM-01";
            }

            b1 = !b1;


            b2 = true;
            b3 = true;
            b4 = true;
            b5 = true;
            b6 = true;
            b7 = true;
            b8 = true;

            b02.Image = null;
            b03.Image = null;
            b04.Image = null;
            b05.Image = null;
            b06.Image = null;
            b07.Image = null;
            b08.Image = null;


            labelB2.Text = "BM-02";
            labelB3.Text = "BM-03";
            labelB4.Text = "BM-04";
            labelB5.Text = "BM-05";
            labelB6.Text = "BM-06";
            labelB7.Text = "BM-07";
            labelB8.Text = "BM-08";

            OccupiedArea();

            if (!isOccupied("BM-01"))
                setSloc("BM-01");
            else
                setSloc(null);



        }

        private void button5_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (b2)
            {
                b02.Image = image;
                labelB2.Text = "";
            }
            else
            {
                b02.Image = null;
                setSloc(null);
                labelB2.Text = "BM-02";
            }

            b2 = !b2;


            b1 = true;
            b3 = true;
            b4 = true;
            b5 = true;
            b6 = true;
            b7 = true;
            b8 = true;

            b01.Image = null;
            b03.Image = null;
            b04.Image = null;
            b05.Image = null;
            b06.Image = null;
            b07.Image = null;
            b08.Image = null;


            labelB1.Text = "BM-01";
            labelB3.Text = "BM-03";
            labelB4.Text = "BM-04";
            labelB5.Text = "BM-05";
            labelB6.Text = "BM-06";
            labelB7.Text = "BM-07";
            labelB8.Text = "BM-08";
            OccupiedArea();
            if (!isOccupied("BM-02"))
                setSloc("BM-02");
        }




        private void b03_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (b3)
            {
                b03.Image = image;
                labelB3.Text = "";
            }
            else
            {
                b03.Image = null;
                labelB3.Text = "BM-03";
            }

            b3 = !b3;


            b1 = true;
            b2 = true;
            b4 = true;
            b5 = true;
            b6 = true;
            b7 = true;
            b8 = true;

            b01.Image = null;
            b02.Image = null;
            b04.Image = null;
            b05.Image = null;
            b06.Image = null;
            b07.Image = null;
            b08.Image = null;


            labelB1.Text = "BM-01";
            labelB2.Text = "BM-02";
            labelB4.Text = "BM-04";
            labelB5.Text = "BM-05";
            labelB6.Text = "BM-06";
            labelB7.Text = "BM-07";
            labelB8.Text = "BM-08";
            OccupiedArea();
            if (!isOccupied("BM-03"))
                setSloc("BM-03");
        }

        private void b04_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (b4)
            {
                b04.Image = image;
                labelB4.Text = "";
            }
            else
            {
                b04.Image = null;
                labelB4.Text = "BM-04";
            }

            b4 = !b4;


            b1 = true;
            b2 = true;
            b3 = true;
            b5 = true;
            b6 = true;
            b7 = true;
            b8 = true;

            b01.Image = null;
            b02.Image = null;
            b03.Image = null;
            b05.Image = null;
            b06.Image = null;
            b07.Image = null;
            b08.Image = null;


            labelB1.Text = "BM-01";
            labelB2.Text = "BM-02";
            labelB3.Text = "BM-03";
            labelB5.Text = "BM-05";
            labelB6.Text = "BM-06";
            labelB7.Text = "BM-07";
            labelB8.Text = "BM-08";
            OccupiedArea();
            if (!isOccupied("BM-04"))
                setSloc("BM-04");

        }

        private void b05_Click_1(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (b5)
            {
                b05.Image = image;
                labelB5.Text = "";
            }
            else
            {
                b05.Image = null;
                labelB5.Text = "BM-05";
            }

            b5 = !b5;


            b1 = true;
            b2 = true;
            b4 = true;
            b3 = true;
            b6 = true;
            b7 = true;
            b8 = true;

            b01.Image = null;
            b02.Image = null;
            b04.Image = null;
            b03.Image = null;
            b06.Image = null;
            b07.Image = null;
            b08.Image = null;


            labelB1.Text = "BM-01";
            labelB2.Text = "BM-02";
            labelB4.Text = "BM-04";
            labelB3.Text = "BM-03";
            labelB6.Text = "BM-06";
            labelB7.Text = "BM-07";
            labelB8.Text = "BM-08";
            OccupiedArea();
            if (!isOccupied("BM-05"))
                setSloc("BM-05");
        }

        private void b06_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath1);

            if (b6)
            {
                b06.Image = image;
                labelB6.Text = "";
            }
            else
            {
                b06.Image = null;
                labelB6.Text = "BM-06";
            }

            b6 = !b6;


            b1 = true;
            b2 = true;
            b4 = true;
            b5 = true;
            b3 = true;
            b7 = true;
            b8 = true;

            b01.Image = null;
            b02.Image = null;
            b04.Image = null;
            b05.Image = null;
            b03.Image = null;
            b07.Image = null;
            b08.Image = null;


            labelB1.Text = "BM-01";
            labelB2.Text = "BM-02";
            labelB4.Text = "BM-04";
            labelB5.Text = "BM-05";
            labelB3.Text = "BM-03";
            labelB7.Text = "BM-07";
            labelB8.Text = "BM-08";
            OccupiedArea();
            if (!isOccupied("BM-06"))
                setSloc("BM-06");
        }

        private void b07_Click_1(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath1);

            if (b7)
            {
                b07.Image = image;
                labelB7.Text = "";
                if (!isOccupied("BM-07"))
                    setSloc("BM-07");
                else
                    setSloc(null);
            }
            else
            {
                b07.Image = null;
                setSloc(null);
                labelB7.Text = "BM-07";
            }

            b7 = !b7;


            b1 = true;
            b2 = true;
            b4 = true;
            b5 = true;
            b6 = true;
            b3 = true;
            b8 = true;

            b01.Image = null;
            b02.Image = null;
            b04.Image = null;
            b05.Image = null;
            b06.Image = null;
            b03.Image = null;
            b08.Image = null;


            labelB1.Text = "BM-01";
            labelB2.Text = "BM-02";
            labelB4.Text = "BM-04";
            labelB5.Text = "BM-05";
            labelB6.Text = "BM-06";
            labelB3.Text = "BM-03";
            labelB8.Text = "BM-08";
            OccupiedArea();

        }


        private void b08_Click_1(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath1);

            if (b8)
            {
                b08.Image = image;
                labelB8.Text = "";
                if (!isOccupied("BM-08"))
                    setSloc("BM-08");
                else
                    setSloc(null);
            }
            else
            {
                b08.Image = null;
                setSloc(null);
                labelB8.Text = "BM-08";
            }

            b8 = !b8;


            b1 = true;
            b2 = true;
            b4 = true;
            b5 = true;
            b6 = true;
            b7 = true;
            b3 = true;

            b01.Image = null;
            b02.Image = null;
            b04.Image = null;
            b05.Image = null;
            b06.Image = null;
            b07.Image = null;
            b03.Image = null;


            labelB1.Text = "BM-01";
            labelB2.Text = "BM-02";
            labelB4.Text = "BM-04";
            labelB5.Text = "BM-05";
            labelB6.Text = "BM-06";
            labelB7.Text = "BM-07";
            labelB3.Text = "BM-03";
            OccupiedArea();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        bool a1 = true;
        bool a2 = true;
        bool a3 = true;
        bool a4 = true;
        bool a5 = true;
        bool a6 = true;
        bool a7 = true;
        bool a8 = true;
        bool a9 = true;
        bool a_10 = true;


        //firstfloor btns
        private void a01_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath1);

            if (a1)
            {
                a01.Image = image;
                labela1.Text = "";
                if (!isOccupied("A-01"))
                    setSloc("A-01");
                else
                    setSloc(null);
            }
            else
            {
                a01.Image = null;
                setSloc(null);
                labela1.Text = "A-01";
            }

            a1 = !a1;


            a2 = true;
            a3 = true;
            a4 = true;
            a5 = true;
            a6 = true;
            a7 = true;
            a8 = true;

            a02.Image = null;
            a03.Image = null;
            a04.Image = null;
            a05.Image = null;
            a06.Image = null;
            a07.Image = null;
            a08.Image = null;
            a9 = true;
            a_10 = true;
            a09.Image = null;
            a10.Image = null;
           

            labela2.Text = "A-02";
            labela3.Text = "A-03";
            labela4.Text = "A-04";
            labela5.Text = "A-05";
            labela6.Text = "A-06";
            labela7.Text = "A-07";
            labela8.Text = "A-08";
            labela9.Text = "A-09";
            labela10.Text = "A-10";

            OccupiedArea();
 
        }

        private void a02_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (a2)
            {
                a02.Image = image;
                labela2.Text = "";
                if (!isOccupied("A-02"))
                    setSloc("A-02");
                else
                    setSloc(null);
            }
            else
            {
                a02.Image = null;
                setSloc(null);
                labela2.Text = "A-02";
            }

            a2 = !a2;


            a1 = true;
            a3 = true;
            a4 = true;
            a5 = true;
            a6 = true;
            a7 = true;
            a8 = true;

            a01.Image = null;
            a03.Image = null;
            a04.Image = null;
            a05.Image = null;
            a06.Image = null;
            a07.Image = null;
            a08.Image = null;
            a9 = true;
            a_10 = true;
            a09.Image = null;
            a10.Image = null;
            labela9.Text = "A-09";
            labela10.Text = "A-10";

            labela1.Text = "A-01";
            labela3.Text = "A-03";
            labela4.Text = "A-04";
            labela5.Text = "A-05";
            labela6.Text = "A-06";
            labela7.Text = "A-07";
            labela8.Text = "A-08";
            OccupiedArea();
          
        }

        private void a03_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (a3)
            {
                a03.Image = image;
                labela3.Text = "";
                if (!isOccupied("A-03"))
                    setSloc("A-03");
                else
                    setSloc(null);
            }
            else
            {
                a03.Image = null;
                setSloc(null);
                labela3.Text = "A-03";
            }

            a3 = !a3;


            a1 = true;
            a2 = true;
            a4 = true;
            a5 = true;
            a6 = true;
            a7 = true;
            a8 = true;

            a01.Image = null;
            a02.Image = null;
            a04.Image = null;
            a05.Image = null;
            a06.Image = null;
            a07.Image = null;
            a08.Image = null;
            a9 = true;
            a_10 = true;
            a09.Image = null;
            a10.Image = null;
            labela9.Text = "A-09";
            labela10.Text = "A-10";

            labela1.Text = "A-01";
            labela2.Text = "A-02";
            labela4.Text = "A-04";
            labela5.Text = "A-05";
            labela6.Text = "A-06";
            labela7.Text = "A-07";
            labela8.Text = "A-08";
            OccupiedArea();
          
        }

        private void a04_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (a4)
            {
                a04.Image = image;
                labela4.Text = "";
                if (!isOccupied("A-04"))
                    setSloc("A-04");
                else
                    setSloc(null);
            }
            else
            {
                a04.Image = null;
                setSloc(null);
                labela4.Text = "A-04";
            }

            a4 = !a4;


            a1 = true;
            a2 = true;
            a3 = true;
            a5 = true;
            a6 = true;
            a7 = true;
            a8 = true;

            a01.Image = null;
            a02.Image = null;
            a03.Image = null;
            a05.Image = null;
            a06.Image = null;
            a07.Image = null;
            a08.Image = null;
            a9 = true;
            a_10 = true;
            a09.Image = null;
            a10.Image = null;
            labela9.Text = "A-09";
            labela10.Text = "A-10";


            labela1.Text = "A-01";
            labela2.Text = "A-02";
            labela3.Text = "A-03";
            labela5.Text = "A-05";
            labela6.Text = "A-06";
            labela7.Text = "A-07";
            labela8.Text = "A-08";
            OccupiedArea();
            
        }

        private void a05_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (a5)
            {
                a05.Image = image;
                labela5.Text = "";
                if (!isOccupied("A-05"))
                    setSloc("A-05");
                else
                    setSloc(null);
            }
            else
            {
                a05.Image = null;
                setSloc(null);
                labela5.Text = "A-05";
            }

            a5 = !a5;


            a1 = true;
            a2 = true;
            a3 = true;
            a4 = true;
            a6 = true;
            a7 = true;
            a8 = true;
            a9 = true;
            a_10 = true;

            a01.Image = null;
            a02.Image = null;
            a03.Image = null;
            a04.Image = null;
            a06.Image = null;
            a07.Image = null;
            a08.Image = null;
            a09.Image = null;
            a10.Image = null;


            labela1.Text = "A-01";
            labela2.Text = "A-02";
            labela3.Text = "A-03";
            labela4.Text = "A-04";
            labela6.Text = "A-06";
            labela7.Text = "A-07";
            labela8.Text = "A-08";
            labela9.Text = "A-09";
            labela10.Text = "A-10";
            OccupiedArea();
            
        }

        private void a06_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (a6)
            {
                a06.Image = image;
                labela6.Text = "";
                if (!isOccupied("A-06"))
                    setSloc("A-06");
                else
                    setSloc(null);
            }
            else
            {
                a06.Image = null;
                setSloc(null);
                labela6.Text = "A-6";
            }

            a6 = !a6;


            a1 = true;
            a2 = true;
            a3 = true;
            a4 = true;
            a5 = true;
            a7 = true;
            a8 = true;
            a9 = true;
            a_10 = true;

            a01.Image = null;
            a02.Image = null;
            a03.Image = null;
            a04.Image = null;
            a05.Image = null;
            a07.Image = null;
            a08.Image = null;
            a09.Image = null;
            a10.Image = null;


            labela1.Text = "A-01";
            labela2.Text = "A-02";
            labela3.Text = "A-03";
            labela4.Text = "A-04";
            labela5.Text = "A-05";
            labela7.Text = "A-07";
            labela8.Text = "A-08";
            labela9.Text = "A-09";
            labela10.Text = "A-10";
            OccupiedArea();
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (a7)
            {
                a07.Image = image;
                labela7.Text = "";
                if (!isOccupied("A-07"))
                    setSloc("A-07");
                else
                    setSloc(null);
            }
            else
            {
                a07.Image = null;
                setSloc(null);
                labela7.Text = "A-7";
            }

            a7 = !a7;


            a1 = true;
            a2 = true;
            a3 = true;
            a4 = true;
            a5 = true;
            a6 = true;
            a8 = true;
            a9 = true;
            a_10 = true;

            a01.Image = null;
            a02.Image = null;
            a03.Image = null;
            a04.Image = null;
            a05.Image = null;
            a06.Image = null;
            a08.Image = null;
            a09.Image = null;
            a10.Image = null;


            labela1.Text = "A-01";
            labela2.Text = "A-02";
            labela3.Text = "A-03";
            labela4.Text = "A-04";
            labela5.Text = "A-05";
            labela6.Text = "A-06";
            labela8.Text = "A-08";
            labela9.Text = "A-09";
            labela10.Text = "A-10";

            OccupiedArea();
         
        }

        private void a08_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (a8)
            {
                a08.Image = image;
                labela8.Text = "";
                if (!isOccupied("A-08"))
                    setSloc("A-08");
                else
                    setSloc(null);
            }
            else
            {
                a08.Image = null;
                setSloc(null);
                labela8.Text = "A-8";
            }

            a8 = !a8;


            a1 = true;
            a2 = true;
            a3 = true;
            a4 = true;
            a5 = true;
            a6 = true;
            a7 = true;
            a9 = true;
            a_10 = true;

            a01.Image = null;
            a02.Image = null;
            a03.Image = null;
            a04.Image = null;
            a05.Image = null;
            a06.Image = null;
            a07.Image = null;
            a09.Image = null;
            a10.Image = null;


            labela1.Text = "A-01";
            labela2.Text = "A-02";
            labela3.Text = "A-03";
            labela4.Text = "A-04";
            labela5.Text = "A-05";
            labela6.Text = "A-06";
            labela7.Text = "A-07";
            labela9.Text = "A-09";
            labela10.Text = "A-10";
            OccupiedArea();
            
        }

        private void a09_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (a9)
            {
                a09.Image = image;
                labela9.Text = "";
                if (!isOccupied("A-09"))
                    setSloc("A-09");
                else
                    setSloc(null);
            }
            else
            {
                a09.Image = null;
                setSloc(null);
                labela9.Text = "A-9";
            }

            a9 = !a9;


            a1 = true;
            a2 = true;
            a3 = true;
            a4 = true;
            a5 = true;
            a6 = true;
            a7 = true;
            a8 = true;
            a_10 = true;

            a01.Image = null;
            a02.Image = null;
            a03.Image = null;
            a04.Image = null;
            a05.Image = null;
            a06.Image = null;
            a07.Image = null;
            a08.Image = null;
            a10.Image = null;


            labela1.Text = "A-01";
            labela2.Text = "A-02";
            labela3.Text = "A-03";
            labela4.Text = "A-04";
            labela5.Text = "A-05";
            labela6.Text = "A-06";
            labela7.Text = "A-07";
            labela8.Text = "A-08";
            labela10.Text = "A-010";
            OccupiedArea();
            
        }

        private void a10_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath2);

            if (a_10)
            {
                a10.Image = image;
                labela10.Text = "";
                if (!isOccupied("A-10"))
                    setSloc("A-10");
                else
                    setSloc(null);
            }
            else
            {
                a10.Image = null;
                setSloc(null);
                labela10.Text = "A-10";
            }

            a_10 = !a_10;


            a1 = true;
            a2 = true;
            a3 = true;
            a4 = true;
            a5 = true;
            a6 = true;
            a7 = true;
            a8 = true;
            a9 = true;

            a01.Image = null;
            a02.Image = null;
            a03.Image = null;
            a04.Image = null;
            a05.Image = null;
            a06.Image = null;
            a07.Image = null;
            a08.Image = null;
            a09.Image = null;


            labela1.Text = "A-01";
            labela2.Text = "A-02";
            labela3.Text = "A-03";
            labela4.Text = "A-04";
            labela5.Text = "A-05";
            labela6.Text = "A-06";
            labela7.Text = "A-07";
            labela8.Text = "A-08";
            labela9.Text = "A-09";
            OccupiedArea();
            
        }
    }
}//