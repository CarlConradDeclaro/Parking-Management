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

        public ParkingEntry(FlowLayoutPanel flowLayoutPanel2)
        {
            InitializeComponent();
            this.flowLayoutPanel2 = flowLayoutPanel2;


            OccupiedArea();
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
            string s_loc = comboBoxS_slots.SelectedItem?.ToString();
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
                    parkingRecordsManager.AddParkingRecord(carDetails);
                    ParkingRecordAdded?.Invoke(this, EventArgs.Empty);
                    invalid.Text = "Successfully added new Vehicle!";
                    invalid.ForeColor = Color.Chartreuse;
                    updateAvailability_query();
                    fetchSlots_query();//  refresh the comboBoxS_slots
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
            fetchSlots_query();
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

        private void comboBoxS_slots_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fetchSlots_query()
        {
            comboBoxS_slots.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "SELECT s_loc FROM V_Slots where availability  != 0";


                SqlCommand command = new SqlCommand(query, connection);

                try
                {

                    connection.Open();


                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {

                            comboBoxS_slots.Items.Add(reader["s_loc"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message);
                }
            }
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


                    command.Parameters.AddWithValue("@s_loc", comboBoxS_slots.SelectedItem?.ToString());


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


            if (isOccupied("B-01"))
            {
                b01.Image = image2;
                labelB1.Text = "";
            }

            if (isOccupied("B-02"))
            {
                b02.Image = image2;
                labelB2.Text = "";
            }
            if (isOccupied("B-03"))
            {
                b03.Image = image2;
                labelB3.Text = "";
            }
            if (isOccupied("B-04")) { 
                b04.Image = image2;
                labelB4.Text = "";
            }

            if (isOccupied("B-05"))
            {
                b05.Image = image2;
                labelB5.Text = "";
            }

            if (isOccupied("B-06"))
            {
                b06.Image = image;
                labelB6.Text = "";
            }
            if (isOccupied("B-07"))
            {
                b07.Image = image;
                labelB7.Text = "";
            }
            if (isOccupied("B-08"))
            {
                b08.Image = image;
                labelB8.Text = "";
            }


        }

        private bool isOccupied(string slotName) {
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

        bool b1 = true;
        bool b2 = true;
        bool b3 = true;
        bool b4 = true;
        bool b5 = true;
        bool b6 = true;
        bool b7 = true;
        bool b8 = true;

 

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
                labelB1.Text = "B-01";
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


            labelB2.Text = "B-02";
            labelB3.Text = "B-03";
            labelB4.Text = "B-04";
            labelB5.Text = "B-05";
            labelB6.Text = "B-06";
            labelB7.Text = "B-07";
            labelB8.Text = "B-08";
            OccupiedArea();
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
                labelB2.Text = "B-02";
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


            labelB1.Text = "B-01";
            labelB3.Text = "B-03";
            labelB4.Text = "B-04";
            labelB5.Text = "B-05";
            labelB6.Text = "B-06";
            labelB7.Text = "B-07";
            labelB8.Text = "B-08";
            OccupiedArea();
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
                labelB3.Text = "B-03";
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


            labelB1.Text = "B-01";
            labelB2.Text = "B-02";
            labelB4.Text = "B-04";
            labelB5.Text = "B-05";
            labelB6.Text = "B-06";
            labelB7.Text = "B-07";
            labelB8.Text = "B-08";
            OccupiedArea();
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
                labelB4.Text = "B-04";
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


            labelB1.Text = "B-01";
            labelB2.Text = "B-02";
            labelB3.Text = "B-03";
            labelB5.Text = "B-05";
            labelB6.Text = "B-06";
            labelB7.Text = "B-07";
            labelB8.Text = "B-08";
            OccupiedArea();

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
                labelB5.Text = "B-05";
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


            labelB1.Text = "B-01";
            labelB2.Text = "B-02";
            labelB4.Text = "B-04";
            labelB3.Text = "B-03";
            labelB6.Text = "B-06";
            labelB7.Text = "B-07";
            labelB8.Text = "B-08";
            OccupiedArea();
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
                labelB6.Text = "B-06";
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


            labelB1.Text = "B-01";
            labelB2.Text = "B-02";
            labelB4.Text = "B-04";
            labelB5.Text = "B-05";
            labelB3.Text = "B-03";
            labelB7.Text = "B-07";
            labelB8.Text = "B-08";
            OccupiedArea();
        }

        private void b07_Click_1(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath1);

            if (b7)
            {
                b07.Image = image;
                labelB7.Text = "";
            }
            else
            {
                b07.Image = null;
                labelB7.Text = "B-07";
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


            labelB1.Text = "B-01";
            labelB2.Text = "B-02";
            labelB4.Text = "B-04";
            labelB5.Text = "B-05";
            labelB6.Text = "B-06";
            labelB3.Text = "B-03";
            labelB8.Text = "B-08";
            OccupiedArea();
        }
      

        private void b08_Click_1(object sender, EventArgs e)
        {
            Image image = Image.FromFile(imagePath1);
       
            if (b8)
            {
                b08.Image = image;
                labelB8.Text = "";
            }
            else
            {
                b08.Image = null;
                labelB8.Text = "B-08";
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


            labelB1.Text = "B-01";
            labelB2.Text = "B-02";
            labelB4.Text = "B-04";
            labelB5.Text = "B-05";
            labelB6.Text = "B-06";
            labelB7.Text = "B-07";
            labelB3.Text = "B-03";
            OccupiedArea();
        }
    }
}//
