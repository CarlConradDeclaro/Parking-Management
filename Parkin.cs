    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace Parking
    {
    public partial class Parkin : UserControl
    {
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

        string imagePath1 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car1.png";
        string imagePath2 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car2.png";
        string Sloc;
        ParkingEntry pe1;
        Parkout pOut;
        private FlowLayoutPanel flowPanelVH;
        private bool isParkin;

        private static Parkin instance;
        public static Parkin Instance
        {
            get
            {
                if (instance == null)
                    instance = new Parkin();
                return instance;
            }
        }
        public Parkin()
        {
            InitializeComponent();
            filterDisplay("PARKED");
            numV.Text = countVehicle() + "";
            numPV.Text = countParkedVehicle() + "";
            numCV.Text = countClearedVehicle() + "";
            panel5.Show();
            /*  history1.Hide();
             admin1.Hide();     */

            parkingView.Hide();
            OccupiedArea();
          
        }
        public void  setFlowVH(FlowLayoutPanel flowPanelVH) {
                this.flowPanelVH = flowPanelVH;
        }


        private void ParkinList_EditHandler(object sender, EventArgs e)
        {
            display();
        }
        private void Parkin_Load(object sender, EventArgs e)
        {
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;

                if (sidebar.Width <= 68)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;

                if (sidebar.Width >= 230)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }
        bool menuExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 350)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 65)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void humBtn_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pe1 = new ParkingEntry(flowLayoutPanel2);
            pe1.ParkingRecordAdded += ParkingRecordAddedHandler;
            pe1.ShowDialog();
           
        }
        public void setIsParkin(bool isPark) {
            isParkin = isPark;
        }
        private void ParkingRecordAddedHandler(object sender, EventArgs e)
        {
            display();


 
           refreshParkingArea();

            numV.Text = countVehicle() + "";
            numPV.Text = countParkedVehicle() + "";
            numCV.Text = countClearedVehicle() + "";
        }

        private void parkout_Click(object sender, EventArgs e)
        {
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

            pOut = new Parkout();
            pOut.Parking += ParkingRecordAddedHandler;
            pOut.ShowDialog();
 
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel2_Click(object sender, EventArgs e)
        {
        }

        public void display()
        {
            flowLayoutPanel2.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords(); // Add a semicolon here
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.Status == "PARKED")
                {
                    parkinList pL = new parkinList(numV, numCV, numPV);
                    pL.UpdateLabels(record);
                    pL.EditParking += ParkingRecordAddedHandler;
                    flowLayoutPanel2.Controls.Add(pL);
                }

            }
        }
        public void refreshParkingArea() {
            b01.Image = null;
            b02.Image = null;
            b03.Image = null;
            b04.Image = null;
            b05.Image = null;
            b06.Image = null;
            b07.Image = null;
            b08.Image = null;
            OccupiedArea();
        }
        public void filterDisplay(string category)
        {
            flowLayoutPanel2.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.Status == category)
                {
                    parkinList pL = new parkinList(numV, numCV, numPV);
                    pL.UpdateLabels(record);
                    flowLayoutPanel2.Controls.Add(pL);
                }
                else if (category == "ALL")
                {
                    parkinList pL = new parkinList(numV, numCV, numPV);
                    pL.UpdateLabels(record);
                    flowLayoutPanel2.Controls.Add(pL);
                }
            }
        }

        private void btnCleared_Click(object sender, EventArgs e)
        {
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var records = parkingRecordsManager.GetAllParkingRecords();
            DialogResult result;
            if (records.Count == 0)
            {
                result = MessageBox.Show("There are no records to clear.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                result = MessageBox.Show("Are you sure you want to clear all records?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (result == DialogResult.Yes)
            {
                records.Clear();
                display();
            }
        }

        private void btnParked_Click(object sender, EventArgs e)
        {
            filterDisplay("PARKED");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            filterDisplay("PARKED");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            bool foundRecord = false;
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.PlateNumber.Contains(searchVH.Text))
                {
                    if (record.Status != "Cleared")
                    {
                        parkinList pL = new parkinList(numV, numCV, numPV);
                        pL.UpdateLabels(record);
                        flowLayoutPanel2.Controls.Add(pL);
                        foundRecord = true;
                    }

                }
            }
            if (!foundRecord)
            {
                Label noResultsLabel = new Label();
                noResultsLabel.Text = "No results found.";
                noResultsLabel.ForeColor = Color.White;
                flowLayoutPanel2.Controls.Add(noResultsLabel);
            }
        }

        private int countVehicle()
        {
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            return parkingRecordsManager.GetAllParkingRecords().Count;

        }
        private int countClearedVehicle()
        {
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            int countCleareVehicle = 0;
            foreach (var record in allParkingRecords)
            {
                if (record.Status == "Cleared")
                    countCleareVehicle++;

            }
            return countCleareVehicle;
        }

        private int countParkedVehicle()
        {
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            int countParkedVehicle = 0;
            foreach (var record in allParkingRecords)
            {
                if (record.Status == "PARKED")
                    countParkedVehicle++;
            }
            return countParkedVehicle;
        }



        private void numV_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            /*  admin1.Hide();
               history1.deleteHistoryV += ParkingRecordAddedHandler;
               history1.Hide();*/
            panel5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*  history1.deleteHistoryV += ParkingRecordAddedHandler;
              history1.Show();
              admin1.Hide();*/

        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*   history1.deleteHistoryV += ParkingRecordAddedHandler;
               admin1.Show();
               history1.Hide();*/
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = panel9.Width;
            int height = panel9.Height;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90); // Top-left corner
            path.AddArc(width - 20, 0, 20, 20, 270, 90); // Top-right corner
            path.AddArc(width - 20, height - 20, 20, 20, 0, 90); // Bottom-right corner
            path.AddArc(0, height - 20, 20, 20, 90, 90); // Bottom-left corner
            path.CloseFigure();
            using (Pen pen = new Pen(Color.Black, 1)) // You can adjust color and thickness as needed
            {
                g.DrawPath(pen, path);
            }
        }
        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = panel10.Width;
            int height = panel10.Height;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(width - 20, 0, 20, 20, 270, 90);
            path.AddArc(width - 20, height - 20, 20, 20, 0, 90);
            path.AddArc(0, height - 20, 20, 20, 90, 90);
            path.CloseFigure();
            using (Pen pen = new Pen(Color.Black, 1))
            {
                g.DrawPath(pen, path);
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = panel11.Width;
            int height = panel11.Height;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(width - 20, 0, 20, 20, 270, 90);
            path.AddArc(width - 20, height - 20, 20, 20, 0, 90);
            path.AddArc(0, height - 20, 20, 20, 90, 90);
            path.CloseFigure();
            using (Pen pen = new Pen(Color.Black, 1))
            {
                g.DrawPath(pen, path);
            }
        }

        private void history1_Load(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void history1_Load_1(object sender, EventArgs e)
        {

        }

        private void admin1_Load(object sender, EventArgs e)
        {

        }

        //vLits
        private void btnViewParkList_Click(object sender, EventArgs e)
        {
            Content.Controls.Add(vehicleListPanel);
            vehicleListPanel.Dock = DockStyle.Fill;
            vehicleListPanel.Show();

            parkingView.Dock = DockStyle.None;
            Content.Controls.Remove(parkingView);
            parkingView.Hide();
            refreshParkingArea();

        }

        //v_parkLot
        private void btnViewParkLot_Click(object sender, EventArgs e)
        {
            //  vehicleListPanel.
            parkingView.Dock = DockStyle.Fill;
            Content.Controls.Add(parkingView);
            parkingView.Show();

            Content.Controls.Remove(vehicleListPanel);
            vehicleListPanel.Dock = DockStyle.None;
            vehicleListPanel.Hide();
            refreshParkingArea();
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

        private void OccupiedArea()
        {

            Image image = Image.FromFile(imagePath1);
            Image image2 = Image.FromFile(imagePath2);


            if (isOccupied("BM-01"))
            {
                b01.Image = image2;
                labelB1.Hide();
            }
            else
                labelB1.Show();

            if (isOccupied("BM-02"))
            {
                b02.Image = image2;
                labelB2.Hide();
            }
            else
                labelB2.Show();

            if (isOccupied("BM-03"))
            {
                b03.Image = image2;
                labelB3.Hide();
            }
            else
                labelB3.Show();

            if (isOccupied("BM-04"))
            {
                b04.Image = image2;
                labelB4.Hide();
            }
            else
                labelB4.Show();

            if (isOccupied("BM-05"))
            {
                b05.Image = image2;
                labelB5.Hide();
            }
            else
                labelB5.Show();

            if (isOccupied("BM-06"))
            {
                b06.Image = image;
                labelB6.Hide();
            }
            else
                labelB6.Show();

            if (isOccupied("BM-07"))
            {
                b07.Image = image;
                labelB7.Hide();
            }
            else
                labelB7.Show();

            if (isOccupied("BM-08"))
            {
                b08.Image = image;
                labelB8.Hide();
            }
            else
                labelB8.Show();

            /*  if (isOccupied("A-01"))
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
              }*/


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



        private void handleParkingArea(string btn)
        {
        
            handleBool(btn);
            HandleNullImage(btn);
       
        }

      


        private void handleBool(string btn)
        {
            switch (btn)
            {
                case "b1":
                    b2 = true;
                    b3 = true;
                    b4 = true;
                    b5 = true;
                    b6 = true;
                    b7 = true;
                    b8 = true;
                    break;
                case "b2":
                    b1 = true;
                    b3 = true;
                    b4 = true;
                    b5 = true;
                    b6 = true;
                    b7 = true;
                    b8 = true;
                    break;
                case "b3":
                    b1 = true;
                    b2 = true;
                    b4 = true;
                    b5 = true;
                    b6 = true;
                    b7 = true;
                    b8 = true;
                    break;
                case "b4":
                    b1 = true;
                    b2 = true;
                    b3 = true;
                    b5 = true;
                    b6 = true;
                    b7 = true;
                    b8 = true;
                    break;
                case "b5":
                    b1 = true;
                    b2 = true;
                    b3 = true;
                    b4 = true;
                    b6 = true;
                    b7 = true;
                    b8 = true;
                    break;
                case "b6":
                    b1 = true;
                    b2 = true;
                    b3 = true;
                    b4 = true;
                    b5 = true;
                    b7 = true;
                    b8 = true;
                    break;
                case "b7":
                    b1 = true;
                    b2 = true;
                    b3 = true;
                    b4 = true;
                    b5 = true;
                    b6 = true;
                    b8 = true;
                    break;
                case "b8":
                    b1 = true;
                    b2 = true;
                    b3 = true;
                    b4 = true;
                    b5 = true;
                    b6 = true;
                    b7 = true;
                    break;
            }
        }

        private void HandleNullImage(string btn)
        {
            switch (btn)
            {
                case "b1":
                    b02.Image = null;
                    b03.Image = null;
                    b04.Image = null;
                    b05.Image = null;
                    b06.Image = null;
                    b07.Image = null;
                    b08.Image = null;
                    break;
                case "b2":
                    b01.Image = null;
                    b03.Image = null;
                    b04.Image = null;
                    b05.Image = null;
                    b06.Image = null;
                    b07.Image = null;
                    b08.Image = null;
                    break;
                case "b3":
                    b01.Image = null;
                    b02.Image = null;
                    b04.Image = null;
                    b05.Image = null;
                    b06.Image = null;
                    b07.Image = null;
                    b08.Image = null;
                    break;
                case "b4":
                    b01.Image = null;
                    b02.Image = null;
                    b03.Image = null;
                    b05.Image = null;
                    b06.Image = null;
                    b07.Image = null;
                    b08.Image = null;
                    break;
                case "b5":
                    b01.Image = null;
                    b02.Image = null;
                    b03.Image = null;
                    b04.Image = null;
                    b06.Image = null;
                    b07.Image = null;
                    b08.Image = null;
                    break;
                case "b6":
                    b01.Image = null;
                    b02.Image = null;
                    b03.Image = null;
                    b04.Image = null;
                    b05.Image = null;
                    b07.Image = null;
                    b08.Image = null;
                    break;
                case "b7":
                    b01.Image = null;
                    b02.Image = null;
                    b03.Image = null;
                    b04.Image = null;
                    b05.Image = null;
                    b06.Image = null;
                    b08.Image = null;
                    break;
                case "b8":
                    b01.Image = null;
                    b02.Image = null;
                    b03.Image = null;
                    b04.Image = null;
                    b05.Image = null;
                    b06.Image = null;
                    b07.Image = null;
                    break;
            }
        }
   
        //ParkingRecord
        private string[] getVehicleRecord(string slot) {

            string query = "SELECT v_plate, v_type, model, driver, phone, arrivalDate, arrivalTime, status FROM Vehicle WHERE status = @status AND s_sloc = @sloc";        
            string[] VHdetails = new string[8];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@status", "PARKED");  
                command.Parameters.AddWithValue("@sloc", slot);  
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read()) 
                {
                    DateTime arrivalDate = (DateTime)reader["arrivalDate"];
                    TimeSpan arrivalTime = (TimeSpan)reader["arrivalTime"];
                    DateTime time = DateTime.Today.Add(arrivalTime);
                    VHdetails[0] = reader["v_plate"].ToString();
                    VHdetails[1] = reader["v_type"].ToString();
                    VHdetails[2] = reader["model"].ToString();
                    VHdetails[3] = reader["driver"].ToString();
                    VHdetails[4] = reader["phone"].ToString();
                    VHdetails[5] = arrivalDate.ToString("MM/dd/yyyy");
                    VHdetails[6] = time.ToString("hh:mm:ss tt");
                    VHdetails[7] = reader["status"].ToString();                
                }
                reader.Close();
            }
            return VHdetails;
        }

        private void handleParkAreaClick(string btn,string s_loc) {

           // handleParkingArea(btn);
            OccupiedArea();
            if (!isOccupied(s_loc))
            {
                setSloc(s_loc);
                pe1 = new ParkingEntry(flowLayoutPanel2);
                pe1.ParkingRecordAdded += ParkingRecordAddedHandler;
                pe1.ShowDialog();
            }
            else
            {
                Parkout pOut = new Parkout();
                pOut.Parking += ParkingRecordAddedHandler;
                FlowLayoutPanel f = pOut.getFlowVH();
                setFlowVH(f);
                flowPanelVH.Controls.Clear();

                string[] vehicleDetails = getVehicleRecord(s_loc);
                AddVehicleDetail("Plate No.", vehicleDetails[0]);
                AddVehicleDetail("Type", vehicleDetails[1]);
                AddVehicleDetail("Model", vehicleDetails[2]);
                AddVehicleDetail("Driver", vehicleDetails[3]);
                AddVehicleDetail("Phone", vehicleDetails[4]);
                AddVehicleDetail("Arrival Date", vehicleDetails[5]);
                AddVehicleDetail("Arrival Time", vehicleDetails[6]);

                pOut.getVHparkOutnType(vehicleDetails[0], vehicleDetails[1]);
                pOut.ShowDialog();
              
            }
        }

        private void AddVehicleDetail(string label, string value)
        {
            vehicleDetails detail = new vehicleDetails();
            detail.UpdateLabels(label, value);
            flowPanelVH.Controls.Add(detail);
        }


        private void b01_Click(object sender, EventArgs e)
        {

            handleParkAreaClick("b1", "BM-01");
        }

        private void b02_Click(object sender, EventArgs e)
        {

            handleParkAreaClick("b2", "BM-02");
        }

        private void b03_Click_1(object sender, EventArgs e)
        {
            handleParkAreaClick("b3", "BM-03");
        }

        private void b04_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("b4", "BM-04");
        }

        private void b05_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("b5", "BM-05");
        }

        private void b06_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("b6", "BM-06");
        }

        private void b07_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("b7", "BM-07");
        }

        private void b08_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("b8", "BM-08");
        }

        private void b09_Click(object sender, EventArgs e)
        {

        }

        private void b10_Click(object sender, EventArgs e)
        {

        }
    }
}
