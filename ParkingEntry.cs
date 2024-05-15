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
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using Button = System.Windows.Forms.Button;

namespace Parking
{
    public partial class ParkingEntry : Form
    {
        private FlowLayoutPanel flowLayoutPanel2;
        ParkingRecordsManager prm = new ParkingRecordsManager();
        public event EventHandler ParkingRecordAdded;
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

        string imagePath1 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car2.png";
        string imagePath2 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car1.png";

        string Sloc;
        bool isSelected;
        bool setVehicleTypeIcon = false;
      

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
            ParkingRecordAdded?.Invoke(this, EventArgs.Empty);
        }

        public void setVehicleIcon(int i) {

            if (i == 1)
            {
                imagePath1 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car2.png";
                imagePath2 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car1.png";
            }
            if (i == 0) {
                 imagePath1 = @"C:\Users\carlconrad\source\Parking-Management-System\img\motorbike2.png";
                 imagePath2 = @"C:\Users\carlconrad\source\Parking-Management-System\img\motorbike1.png";

            }

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

                        Parkin parkin = new Parkin();
                        parkin.setIsParkin(true);

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


            string type = comboBoxType.SelectedItem?.ToString().ToUpper();
            if (type != "MOTORBIKE")
            {
                setVehicleIcon(1);
            }


                if (type == "MOTORBIKE")
                {
                setVehicleIcon(0);

            }

            
            setTypeImage(comboBoxType.SelectedItem?.ToString().ToUpper(), getSloc());

        }
       
        private void setTypeImage(string type,string sloc) {

            Image image1 = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\Car2.png");
            Image image2 = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\Car1.png");
            Image motorbikeImage1 = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\motorbike2.png");
            Image motorbikeImage2 = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\motorbike1.png");

            Button[] buttons = { b01, b02, b03, b04, b05, b06, b07, b08, b09, b10,
                         a01, a02, a03, a04, a05, a06, a07, a08, a09, a10,
                         bb01, bb02, bb03, bb04, bb05, bb06, bb07, bb08, bb09, bb10 };
            Label[] labels = { labelB1, labelB2, labelB3, labelB4, labelB5, labelB6, labelB7, labelB8, labelB9, labelB10,
                       labela1, labela2, labela3, labela4, labela5, labela6, labela7, labela8, labela9, labela10,
                       labelb01, labelb02, labelb03, labelb04, labelb05, labelb06, labelb07, labelb08, labelb09, labelbB10 };
            string[] labelNames = { "BM-01", "BM-02", "BM-03", "BM-04", "BM-05", "BM-06", "BM-07", "BM-08", "BM-09", "BM-10",
                            "A-01", "A-02", "A-03", "A-04", "A-05", "A-06", "A-07", "A-08", "A-09", "A-10",
                            "B-01", "B-02", "B-03", "B-04", "B-05", "B-06", "B-07", "B-08", "B-09", "B-10" };

            if (type != "MOTORBIKE")
                for (int i = 0; i < labelNames.Length; i++)
                    if (labelNames[i] == sloc)
                    {
                        buttons[i].Image = (i >= 0 && i < 5) || (i >= 10 && i <= 14) || (i >= 19 && i <= 23) ? image1 : image2;
                        labels[i].Hide();
                    }
            if (type == "MOTORBIKE")
                for (int j = 0; j < labelNames.Length; j++)
                                      if (labelNames[j] == sloc){
                                        buttons[j].Image = (j >= 0 && j < 5) || (j >= 10 && j <= 14) || (j >= 19 && j <= 23) ? motorbikeImage1 : motorbikeImage2;
                                         labels[j].Hide();
                                     }

        }

        public void refreshParkingArea()
        {
            Button[] button = [b01, b02, b03, b04, b05, b06, b07, b08,b09,b10,
                               a01,a02,a03,a04,a05,a06,a07,a08,a09,a10,
                               bb01,bb02,bb03,bb04,bb05,bb06,bb07,bb08,bb09,bb10];
            Label[] labels = { labelB1, labelB2, labelB3, labelB4, labelB5, labelB6, labelB7, labelB8, labelB9, labelB10,
                       labela1, labela2, labela3, labela4, labela5, labela6, labela7, labela8, labela9, labela10,
                       labelb01, labelb02, labelb03, labelb04, labelb05, labelb06, labelb07, labelb08, labelb09, labelbB10 };

            for (int i = 0; i < 30; i++) {
                button[i].Image = null;
                labels[i].Show();
            }
               

            OccupiedArea();
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




        bool b1 = true;
        bool b2 = true;
        bool b3 = true;
        bool b4 = true;
        bool b5 = true;
        bool b6 = true;
        bool b7 = true;
        bool b8 = true;
        bool b9 = true;
        bool b_10 = true;

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

        bool bb1 = true;
        bool bb2 = true;
        bool bb3 = true;
        bool bb4 = true;
        bool bb5 = true;
        bool bb6 = true;
        bool bb7 = true;
        bool bb8 = true;
        bool bb9 = true;
        bool bb_10 = true;


        private void OccupiedArea()
        {
            Image motorbikeImage1 = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\motorbike2.png");
            Image motorbikeImage2 = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\motorbike1.png");
            Image carImage1 = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\Car2.png");
            Image carImage2 = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\Car1.png");

            Button[] buttons = { b01, b02, b03, b04, b05, b06, b07, b08, b09, b10,
                         a01, a02, a03, a04, a05, a06, a07, a08, a09, a10,
                         bb01, bb02, bb03, bb04, bb05, bb06, bb07, bb08, bb09, bb10 };
            Label[] labels = { labelB1, labelB2, labelB3, labelB4, labelB5, labelB6, labelB7, labelB8, labelB9, labelB10,
                       labela1, labela2, labela3, labela4, labela5, labela6, labela7, labela8, labela9, labela10,
                       labelb01, labelb02, labelb03, labelb04, labelb05, labelb06, labelb07, labelb08, labelb09, labelbB10 };
            string[] labelNames = { "BM-01", "BM-02", "BM-03", "BM-04", "BM-05", "BM-06", "BM-07", "BM-08", "BM-09", "BM-10",
                            "A-01", "A-02", "A-03", "A-04", "A-05", "A-06", "A-07", "A-08", "A-09", "A-10",
                            "B-01", "B-02", "B-03", "B-04", "B-05", "B-06", "B-07", "B-08", "B-09", "B-10" };

            for (int i = 0; i < labelNames.Length; i++)
            {
                if (isOccupied(labelNames[i]))
                {    
                    bool ismotorbike = isMotorbike(labelNames[i]);
                    buttons[i].Image = ismotorbike ? (i >= 0 && i < 5) || (i >= 10 && i <= 14) || (i >= 19 && i <= 23) ? motorbikeImage1 : motorbikeImage2
                                       : (i >= 0 && i < 5) || (i >= 10 && i <= 14) || (i >= 19 && i <= 23)  ? carImage1 : carImage2;
                    labels[i].Hide();
                }         
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

        private bool isMotorbike(string s_loc)
        {
            bool isMotorbike = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Vehicle WHERE s_sloc = @s_sloc AND status = 'PARKED' AND v_type = 'MOTORBIKE'  ";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@s_sloc", s_loc);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    isMotorbike = count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            return isMotorbike;
        }




        private void button12_Click(object sender, EventArgs e)
        {
            //basement
            handleDockPanels(1);
             Button[] firstFloorBtn = [a01, a02, a03, a04, a05, a06, a07, a08, a09, a10];
            Label[] firstFloorLabels = [labela1, labela2, labela3, labela4, labela5, labela6, labela7, labela8, labela8, labela9, labela10];
            Button[] secondFloorBtn = [bb01, bb02, bb03, a04, bb05, bb06, bb07, bb08, bb09, bb10];
            Label[] secondFloorlabels = [labelb01, labelb02, labelb03, labelb04, labelb05, labelb06, labelb07, labelb08, labelb09, labelB10];
            for (int i = 0; i < 10; i++)
            {
                firstFloorBtn[i].Image = null;
                firstFloorLabels[i].Show();
            }
            for (int i = 0; i < 10; i++)
            {
                secondFloorBtn[i].Image = null;
                secondFloorlabels[i].Show();
            }
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
            bb1 = true;
            bb2 = true;
            bb3 = true;
            bb4 = true;
            bb5 = true;
            bb6 = true;
            bb7 = true;
            bb8 = true;
            bb9 = true;
            bb_10 = true;
            OccupiedArea();
            setSloc(null);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            //firstfloor
            handleDockPanels(2);
             Button[] basementBtn = [b01, b02, b03, b04, b05, b06, b07, b08, b09, b10];
            Label[] basementLabels = [labelB1, labelB2, labelB3, labelB4, labelB5, labelB6, labelB7, labelB8, labelB9, labelB10];
            Button[] secondFloorBtn = [bb01, bb02, bb03, a04, bb05, bb06, bb07, bb08, bb09, bb10];
            Label[] secondFloorlabels = [labelb01, labelb02, labelb03, labelb04, labelb05, labelb06, labelb07, labelb08, labelb09, labelB10];
            for (int i = 0; i < 10; i++)
            {
                basementBtn[i].Image = null;
                basementLabels[i].Show();
            }
            for (int i = 0; i < 10; i++)
            {
                secondFloorBtn[i].Image = null;
                secondFloorlabels[i].Show();
            }
            b1 = true;
            b2 = true;
            b3 = true;
            b4 = true;
            b5 = true;
            b6 = true;
            b7 = true;
            b8 = true;
            b9 = true;
            b_10 = true;
            //secondfloor
            bb1 = true;
            bb2 = true;
            bb3 = true;
            bb4 = true;
            bb5 = true;
            bb6 = true;
            bb7 = true;
            bb8 = true;
            bb9 = true;
            bb_10 = true;
            OccupiedArea();
            setSloc(null);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            handleDockPanels(3);
            Button[] firstFloorBtn = [a01, a02, a03, a04, a05, a06, a07, a08, a09, a10];
            Label[] firstFloorLabels = [labela1, labela2, labela3, labela4, labela5, labela6, labela7, labela8, labela8, labela9, labela10];
            Button[] basementBtn = [b01, b02, b03, b04, b05, b06, b07, b08, b09, b10];
            Label[] basementLabels = [labelB1, labelB2, labelB3, labelB4, labelB5, labelB6, labelB7, labelB8, labelB9, labelB10];
            for (int i = 0; i < 10; i++)
            {
                firstFloorBtn[i].Image = null;
                firstFloorLabels[i].Show();
            }

            for (int i = 0; i < 10; i++)
            {
                basementBtn[i].Image = null;
                basementLabels[i].Show();
            }
            b1 = true;
            b2 = true;
            b3 = true;
            b4 = true;
            b5 = true;
            b6 = true;
            b7 = true;
            b8 = true;
            b9 = true;
            b_10 = true;
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
            OccupiedArea();
            setSloc(null);
        }
        private void setSloc(string sloc)
        {
            Sloc = sloc;
        }
        private string getSloc()
        {
            return Sloc;
        }

        public void setSelectedArea(bool bol)
        {
            isSelected = bol;
        }
        public bool getSelectedArea()
        {
            return isSelected;
        }
        private void handleDockPanels(int floor) {
            switch (floor)
            {
                case 1:
                    basementPanel.Dock = DockStyle.Fill;
                    panel5.Controls.Add(basementPanel);
                    basementPanel.Show();
                    firstFloorPanel.Dock = DockStyle.None;
                    panel5.Controls.Remove(firstFloorPanel);
                    firstFloorPanel.Hide();
                    panel5.Controls.Remove(secondFloorPanel);
                    secondFloorPanel.Dock = DockStyle.None;
                    secondFloorPanel.Hide();
                    break;
                case 2:
                    firstFloorPanel.Dock = DockStyle.Fill;
                    panel5.Controls.Add(firstFloorPanel);
                    firstFloorPanel.Show();
                    panel5.Controls.Remove(basementPanel);
                    basementPanel.Dock = DockStyle.None;
                    basementPanel.Hide();
                    panel5.Controls.Remove(secondFloorPanel);
                    secondFloorPanel.Dock = DockStyle.None;
                    secondFloorPanel.Hide();
                    break;
                case 3:
                    panel5.Controls.Add(secondFloorPanel);
                    secondFloorPanel.Dock = DockStyle.Fill;
                    secondFloorPanel.Show();
                    firstFloorPanel.Dock = DockStyle.None;
                    panel5.Controls.Remove(firstFloorPanel);
                    firstFloorPanel.Hide();
                    panel5.Controls.Remove(basementPanel);
                    basementPanel.Dock = DockStyle.None;
                    basementPanel.Hide();
                    break;
            }
        }
    
        private void handleFloorBtn(int floor) {
            switch (floor)
            {
                case 1:
                    button12.Enabled = true;
                    button13.Enabled = false;
                    
                    button14.Enabled = false;
                  
                    break;
                case 2:
                    button12.Enabled = false;
                   
                    button13.Enabled = true;
                    button14.Enabled = false;
                   
                    break;
                case 3:
                    button12.Enabled = false;
                   
                    button13.Enabled = false;
                 
                    button14.Enabled = true;
                    break;
            }

          
        }
       

        public void setLocationArea(string btn,int floor)
        {
            Image image1 = Image.FromFile(imagePath1);
            Image image2 = Image.FromFile(imagePath2);

            handleDockPanels(floor);
            handleFloorBtn(floor);

            switch (btn)
            {
                case "BM-01":
                    b01.Image = image1;
                    labelB1.Hide();
                    if (!isOccupied("BM-01"))
                        setSloc("BM-01");
                    b01.BackColor = Color.GreenYellow;
                    break;
                case "BM-02":
                    b02.Image = image1;
                    labelB2.Hide();
                    if (!isOccupied("BM-02"))
                        setSloc("BM-02");
                    b02.BackColor = Color.GreenYellow;
                    break;
                case "BM-03":
                    b03.Image = image1;
                    labelB3.Hide();
                    if (!isOccupied("BM-03"))
                        setSloc("BM-03");
                    b03.BackColor = Color.GreenYellow;
                    break;
                case "BM-04":
                    b04.Image = image1;
                    labelB4.Hide();
                    if (!isOccupied("BM-04"))
                        setSloc("BM-04");
                    b04.BackColor = Color.GreenYellow;
                    break;
                case "BM-05":
                    b05.Image = image1;
                    labelB5.Hide();
                    if (!isOccupied("BM-05"))
                        setSloc("BM-05");
                    b05.BackColor = Color.GreenYellow;
                    break;
                case "BM-06":
                    b06.Image = image2;
                    labelB6.Hide();
                    if (!isOccupied("BM-06"))
                        setSloc("BM-06");
                    b06.BackColor = Color.GreenYellow;
                    break;
                case "BM-07":
                    b07.Image = image2;
                    labelB7.Hide();
                    if (!isOccupied("BM-07"))
                        setSloc("BM-07");
                    b07.BackColor = Color.GreenYellow;
                    break;
                case "BM-08":
                    b08.Image = image2;
                    labelB8.Hide();
                    if (!isOccupied("BM-08"))
                        setSloc("BM-08");
                    b08.BackColor = Color.GreenYellow;
                    break;
                case "BM-09":
                    b09.Image = image2;
                    labelB9.Hide();
                    if (!isOccupied("BM-09"))
                        setSloc("BM-09");
                    b09.BackColor = Color.GreenYellow;
                    break;
                case "BM-10":
                    b10.Image = image2;
                    labelB10.Hide();
                    if (!isOccupied("BM-10"))
                        setSloc("BM-10");
                    b10.BackColor = Color.GreenYellow;
                    break;

                case "A-01":
                    a01.Image = image1;
                    labela1.Hide();
                    if (!isOccupied("A-01"))
                        setSloc("A-01");
                    a01.BackColor = Color.GreenYellow;
                    break;
                case "A-02":
                    b02.Image = image1;
                    labela2.Hide();
                    if (!isOccupied("A-02"))
                        setSloc("A-02");
                    a02.BackColor = Color.GreenYellow;
                    break;
                case "A-03":
                    a03.Image = image1;
                    labela3.Hide();
                    if (!isOccupied("A-03"))
                        setSloc("A-03");
                    a03.BackColor = Color.GreenYellow;
                    break;
                case "A-04":
                    a04.Image = image1;
                    labela4.Hide();
                    if (!isOccupied("A-04"))
                        setSloc("A-04");
                    a04.BackColor = Color.GreenYellow;
                    break;
                case "A-05":
                    a05.Image = image1;
                    labela5.Hide();
                    if (!isOccupied("A-05"))
                        setSloc("A-05");
                    a05.BackColor = Color.GreenYellow;
                    break;
                case "A-06":
                    a06.Image = image2;
                    labelB6.Hide();
                    if (!isOccupied("A-06"))
                        setSloc("A-06");
                    a06.BackColor = Color.GreenYellow;
                    break;
                case "A-07":
                    a07.Image = image2;
                    labela7.Hide();
                    if (!isOccupied("A-07"))
                        setSloc("A-07");
                    a07.BackColor = Color.GreenYellow;
                    break;
                case "A-08":
                    a08.Image = image2;
                    labela8.Hide();
                    if (!isOccupied("A-08"))
                        setSloc("A-08");
                    a08.BackColor = Color.GreenYellow;
                    break;
                case "A-09":
                    a09.Image = image2;
                    labela9.Hide();
                    if (!isOccupied("A-09"))
                        setSloc("A-09");
                    a09.BackColor = Color.GreenYellow;
                    break;
                case "A-10":
                    a10.Image = image2;
                    labela10.Hide();
                    if (!isOccupied("A-10"))
                        setSloc("A-10");
                    a10.BackColor = Color.GreenYellow;
                    break;


                case "B-01":
                    bb01.Image = image1;
                    labelb01.Hide();
                    if (!isOccupied("B-01"))
                        setSloc("B-01");
                    bb01.BackColor = Color.GreenYellow;
                    break;
                case "B-02":
                    bb02.Image = image1;
                    labelb02.Hide();
                    if (!isOccupied("B-02"))
                        setSloc("B-02");
                    bb02.BackColor = Color.GreenYellow;
                    break;
                case "B-03":
                    bb03.Image = image1;
                    labelb03.Hide();
                    if (!isOccupied("B-03"))
                        setSloc("B-03");
                    bb03.BackColor = Color.GreenYellow;
                    break;
                case "B-04":
                    bb04.Image = image1;
                    labelb04.Hide();
                    if (!isOccupied("B-04"))
                        setSloc("B-04");
                    bb04.BackColor = Color.GreenYellow;
                    break;
                case "B-05":
                    bb05.Image = image1;
                    labelb05.Hide();
                    if (!isOccupied("B-05"))
                        setSloc("B-05");
                    bb05.BackColor = Color.GreenYellow;
                    break;
                case "B-06":
                    bb06.Image = image2;
                    labelb06.Hide();
                    if (!isOccupied("B-06"))
                        setSloc("B-06");
                    bb06.BackColor = Color.GreenYellow;
                    break;
                case "B-07":
                    bb07.Image = image2;
                    labelb07.Hide();
                    if (!isOccupied("B-07"))
                        setSloc("B-07");
                    bb07.BackColor = Color.GreenYellow;
                    break;
                case "B-08":
                    bb08.Image = image2;
                    labelb08.Hide();
                    if (!isOccupied("B-08"))
                        setSloc("B-08");
                    bb08.BackColor = Color.GreenYellow;
                    break;
                case "B-09":
                    bb09.Image = image2;
                    labelb09.Hide();
                    if (!isOccupied("B-09"))
                        setSloc("B-09");
                    bb09.BackColor = Color.GreenYellow;
                    break;
                case "B-10":
                    bb10.Image = image2;
                    labelB10.Hide();
                    if (!isOccupied("B-10"))
                        setSloc("B-10");
                    bb10.BackColor = Color.GreenYellow;
                    break;

            }
        }
        private void handleParkingArea(string btn, string btnLabel)
        {
            handleBool(btn);
            HandleNullImage(btn);
            handleText(btnLabel);
            OccupiedArea();
        }
        private void handleBool(string btn)
        {
            if (btn != "b1")
                b1 = true;
            if (btn != "b2")
                b2 = true;
            if (btn != "b3")
                b3 = true;
            if (btn != "b4")
                b4 = true;
            if (btn != "b5")
                b5 = true;
            if (btn != "b6")
                b6 = true;
            if (btn != "b7")
                b7 = true;
            if (btn != "b8")
                b8 = true;
            if (btn != "b9")
                b9 = true;
            if (btn != "b10")
                b_10 = true;


            if (btn != "a1")
                a1 = true;
            if (btn != "a2")
                a2 = true;
            if (btn != "a3")
                a3 = true;
            if (btn != "a4")
                a4 = true;
            if (btn != "a5")
                a5 = true;
            if (btn != "a6")
                a6 = true;
            if (btn != "a7")
                a7 = true;
            if (btn != "a8")
                a8 = true;
            if (btn != "a9")
                a9 = true;
            if (btn != "a10")
                a_10 = true;

            if (btn != "2b1")
                bb1 = true;
            if (btn != "2b2")
                bb2 = true;
            if (btn != "2b3")
                bb3 = true;
            if (btn != "2b4")
                bb4 = true;
            if (btn != "2b5")
                bb5 = true;
            if (btn != "2b6")
                bb6 = true;
            if (btn != "2b7")
                bb7 = true;
            if (btn != "2b8")
                bb8 = true;
            if (btn != "2b9")
                bb9 = true;
            if (btn != "2b10")
                bb_10 = true;



        }
        private void HandleNullImage(string btn)
        {
            Button[] button = [b01, b02, b03, b04, b05, b06, b07, b08,b09,b10,
                               a01,a02,a03,a04,a05,a06,a07,a08,a09,a10,
                               bb01,bb02,bb03,bb04,bb05,bb06,bb07,bb08,bb09,bb10];
            string[] btnName = ["b1", "b2", "b3", "b4", "b5", "b6", "b7", "b8","b9","b10",
                                 "a1","a2","a3","a4","a5","a6","a7","a8","a9","a10",
                                 "2b1", "2b2","2b3","2b4","2b5","2b6","2b7","2b8","2b9","2b10"
            ];
            for (int i = 0; i < 30; i++)
                if (btnName[i] != btn)
                    button[i].Image = null;
        

        }
        private void handleText(string btn)
        {

            Label[] labels = [labelB1, labelB2, labelB3, labelB4, labelB5, labelB6, labelB7, labelB8,labelB9,labelB10,
                              labela1,labela2,labela3,labela4,labela5,labela6,labela7,labela8,labela9,labela10,
                              labelb01,labelb02,labelb03,labelb04,labelb05,labelb06,labelb07,labelb08,labelb09,labelbB10];
            for (int i = 0; i < 30; i++)
                if (labels[i].Text != btn)
                    labels[i].Show();
               
        }
        private void toggleImg(int btn, string btnName )
        {
            Image image1 = Image.FromFile(imagePath1);
            Image image2 =  Image.FromFile(imagePath2);
            Button[] button = [b01, b02, b03, b04, b05,       b06, b07, b08,b09,b10,
                               a01,a02,a03,a04,a05,           a06,a07,a08,a09,a10,
                               bb01,bb02,bb03,bb04,bb05,      bb06,bb07,bb08,bb09,bb10];
            Label[] labels = [labelB1, labelB2, labelB3, labelB4, labelB5, labelB6, labelB7, labelB8,labelB9,labelB10,
                              labela1,labela2,labela3,labela4,labela5,labela6,labela7,labela8,labela9,labela10,
                              labelb01,labelb02,labelb03,labelb04,labelb05,labelb06,labelb07,labelb08,labelb09,labelbB10];
           
            button[btn].Image = (btn >= 0 && btn < 5) || (btn >= 10 && btn <= 14) || (btn >= 19 && btn <= 23) ? image1 :  image2;
            
           labels[btn].Hide();

            if (!isOccupied(btnName))
                setSloc(btnName);
            else
                setSloc(null);
        }
        private void unToggleImg(int btn, int label)
        {
            Button[] button = [b01, b02, b03, b04, b05, b06, b07, b08,b09,b10,
                               a01,a02,a03,a04,a05,a06,a07,a08,a09,a10,
                               bb01,bb02,bb03,bb04,bb05,bb06,bb07,bb08,bb09,bb10];
            Label[] labels = [labelB1, labelB2, labelB3, labelB4, labelB5, labelB6, labelB7, labelB8,labelB9,labelB10,
                              labela1,labela2,labela3,labela4,labela5,labela6,labela7,labela8,labela9,labela10,
                              labelb01,labelb02,labelb03,labelb04,labelb05,labelb06,labelb07,labelb08,labelb09,labelbB10];

            button[btn].Image = null;
            setSloc(null);
            labels[btn].Show();
        }
        private void b01_Click(object sender, EventArgs e)
        {
          
            if (!getSelectedArea())
            {
                if (b1)
                    toggleImg(0, "BM-01");
                else
                    unToggleImg(0, 0);
                b1 = !b1;
                handleParkingArea("b1", "BM-01");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
        }
        private void button5_Click(object sender, EventArgs e)
        {
            
             if (!getSelectedArea())
            {
                if (b2)
                    toggleImg(1, "BM-02");
                else
                    unToggleImg(1, 1);
                b2 = !b2;
                handleParkingArea("b2", "BM-02");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        private void b03_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (b3)
                    toggleImg(2, "BM-03");
                else
                    unToggleImg(2, 2);
                b3 = !b3;
                handleParkingArea("b3", "BM-03");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void b04_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (b4)
                    toggleImg(3, "BM-04");
                else
                    unToggleImg(3, 3);
                b4 = !b4;
                handleParkingArea("b4", "BM-04");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void b05_Click_1(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (b5)
                    toggleImg(4, "BM-05");
                else
                    unToggleImg(4, 4);
                b5 = !b5;
                handleParkingArea("b5", "BM-05");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void b06_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (b6)
                    toggleImg(5, "BM-06");
                else
                    unToggleImg(5, 5);
                b6 = !b6;
                handleParkingArea("b6", "BM-06");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void b07_Click_1(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (b7)
                    toggleImg(6, "BM-07");
                else
                    unToggleImg(6, 6);
                b7 = !b7;
                handleParkingArea("b7", "BM-07");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void b08_Click_1(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (b8)
                    toggleImg(7, "BM-08");
                else
                    unToggleImg(7, 7);
                b8 = !b8;
                handleParkingArea("b8", "BM-08");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void b09_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (b9)
                    toggleImg(8, "BM-09");
                else
                    unToggleImg(8, 8);
                b9 = !b9;
                handleParkingArea("b9", "BM-09");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void b10_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (b_10)
                    toggleImg(9, "BM-10");
                else
                    unToggleImg(9, 9);
                b_10 = !b_10;
                handleParkingArea("b10", "BM-10");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //firstfloor btns
        private void a01_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (a1)
                    toggleImg(10, "A-01");
                else
                    unToggleImg(10, 10);
                a1 = !a1;
                handleParkingArea("a1", "A-01");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void a02_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (a2)
                    toggleImg(11, "A-02");
                else
                    unToggleImg(11, 11);
                a2 = !a2;
                handleParkingArea("a2", "A-02");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void a03_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (a3)
                    toggleImg(12, "A-03");
                else
                    unToggleImg(12, 12);
                a3 = !a3;
                handleParkingArea("a3", "A-03");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void a04_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (a4)
                    toggleImg(13, "A-04");
                else
                    unToggleImg(13, 13);
                a4 = !a4;
                handleParkingArea("a4", "A-04");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void a05_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (a5)
                    toggleImg(14, "A-05");
                else
                    unToggleImg(14, 14);
                a5 = !a5;
                handleParkingArea("a5", "A-05");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void a06_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (a6)
                    toggleImg(15, "A-06");
                else
                    unToggleImg(15, 15);
                a6 = !a6;
                handleParkingArea("a6", "A-06");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (a7)
                    toggleImg(16, "A-07");
                else
                    unToggleImg(16, 16);
                a7 = !a7;
                handleParkingArea("a7", "A-07");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void a08_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (a8)
                    toggleImg(17, "A-08");
                else
                    unToggleImg(17, 17);
                a8 = !a8;
                handleParkingArea("a8", "A-08");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void a09_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (a9)
                    toggleImg(18, "A-09");
                else
                    unToggleImg(18, 18);
                a9 = !a9;
                handleParkingArea("a9", "A-09");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void a10_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (a_10)
                    toggleImg(19, "A-10");
                else
                    unToggleImg(19, 19);
                a_10 = !a_10;
                handleParkingArea("a10", "A-10");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bb01_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (bb1)
                    toggleImg(20, "B-01");
                else
                    unToggleImg(20, 20);
                bb1 = !bb1;
                handleParkingArea("2b1", "B-01");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bb02_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (bb2)
                    toggleImg(21, "B-02");
                else
                    unToggleImg(21, 21);
                bb2 = !bb2;
                handleParkingArea("2b2", "B-02");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bb03_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (bb3)
                    toggleImg(22, "B-03");
                else
                    unToggleImg(22, 22);
                bb3 = !bb3;
                handleParkingArea("2b3", "B-03");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bb04_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (bb4)
                    toggleImg(23, "B-04");
                else
                    unToggleImg(23, 23);
                bb4 = !bb4;
                handleParkingArea("2b4", "B-04");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bb05_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (bb5)
                    toggleImg(24, "B-05");
                else
                    unToggleImg(24, 24);
                bb5 = !bb5;
                handleParkingArea("2b5", "B-05");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bb06_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (bb6)
                    toggleImg(25, "B-06");
                else
                    unToggleImg(25, 25);
                bb6 = !bb6;
                handleParkingArea("2b6", "B-06");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bb07_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (bb7)
                    toggleImg(26, "B-07");
                else
                    unToggleImg(26, 26);
                bb7 = !bb7;
                handleParkingArea("2b7", "B-07");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bb08_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (bb8)
                    toggleImg(27, "B-08");
                else
                    unToggleImg(27, 27);
                bb8 = !bb8;
                handleParkingArea("2b8", "B-08");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bb09_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (bb9)
                    toggleImg(28, "B-09");
                else
                    unToggleImg(28, 28);
                bb9 = !bb9;
                handleParkingArea("2b9", "B-09");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bb10_Click(object sender, EventArgs e)
        {
            if (!getSelectedArea())
            {
                if (bb_10)
                    toggleImg(29, "B-10");
                else
                    unToggleImg(29, 29);
                bb_10 = !bb_10;
                handleParkingArea("2b10", "B-10");
            }
            else
                MessageBox.Show("Can't perform action, you have already selected a slot area!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}