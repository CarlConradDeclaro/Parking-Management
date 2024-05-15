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

namespace Parking
    {
    public partial class Parkin : UserControl
    {
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";
        string imagePath1 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car2.png";
        string imagePath2 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car1.png";
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

            panel5.Show();
            /*  history1.Hide();
             admin1.Hide();     */

            parkingView.Hide();
            OccupiedArea();

        }
        public void setFlowVH(FlowLayoutPanel flowPanelVH)
        {
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
        public void setIsParkin(bool isPark)
        {
            isParkin = isPark;
        }
        private void ParkingRecordAddedHandler(object sender, EventArgs e)
        {
            display();



            refreshParkingArea();

            numV.Text = countVehicle() + "";
            numPV.Text = countParkedVehicle() + "";

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
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.Status == "PARKED")
                {
                    parkinList pL = new parkinList(numV, numPV);
                    pL.UpdateLabels(record);
                    pL.EditParking += ParkingRecordAddedHandler;
                    flowLayoutPanel2.Controls.Add(pL);
                }

            }
        }
        public void refreshParkingArea()
        {
            Button[] button = [b01, b02, b03, b04, b05, b06, b07, b08,b09,b10,
                               button28, button27, button26, button25, button24, button23, button22, button21, button20, button19,
                              button38, button37, button36, button35, button34, button33, button32, button31, button30, button29];
            for (int i = 0; i < 30; i++)
                button[i].Image = null;
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
                    parkinList pL = new parkinList(numV, numPV);
                    pL.UpdateLabels(record);
                    flowLayoutPanel2.Controls.Add(pL);
                }
                else if (category == "ALL")
                {
                    parkinList pL = new parkinList(numV, numPV);
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
                        parkinList pL = new parkinList(numV, numPV);
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

            Image motorbikeImage1 = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\motorbike2.png");
            Image motorbikeImage2 = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\motorbike1.png");
            Image carImage1 = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\Car2.png");
            Image carImage2 = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\Car1.png");

            Button[] button = [b01, b02, b03, b04, b05, b06, b07, b08,b09,b10,
                               button28, button27, button26, button25, button24, button23, button22, button21, button20, button19,
                               button38, button37, button36, button35, button34, button33, button32, button31, button30, button29];
            Label[] labels = [labelB1, labelB2, labelB3, labelB4, labelB5, labelB6, labelB7, labelB8, labelB9, labelB10,
                              labela1, labela2,labela3,labela4,labela5,labela6,labela7,labela8,labela9,labela10,
                              label29, label30, label31, label32, label33,label22,label34, label35, label36,label37];
            string[] labelNames = ["BM-01", "BM-02", "BM-03", "BM-04", "BM-05", "BM-06", "BM-07", "BM-08", "BM-09", "BM-10",
                                    "A-01","A-02","A-03","A-04","A-05","A-06","A-07","A-08","A-09","A-10",
                                    "B-01","B-02","B-03","B-04","B-05","B-06","B-07","B-08","B-09","B-10"];

            for (int i = 0; i < labelNames.Length; i++)
                if (isOccupied(labelNames[i]))
                {
                    bool ismotorbike = isMotorbike(labelNames[i]);
                    button[i].Image = ismotorbike ? (i >= 0 && i < 5) || (i >= 10 && i <= 14) || (i >= 19 && i <= 23) ? motorbikeImage1 : motorbikeImage2
                                       : (i >= 0 && i < 5) || (i >= 10 && i <= 14) || (i >= 19 && i <= 23) ? carImage1 : carImage2;
                    labels[i].Hide();
                }
                else
                    labels[i].Show();
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

        private void setSloc(string sloc)
        {
            Sloc = sloc;
        }
        private string getSloc()
        {
            return Sloc;
        }

        //ParkingRecord
        private string[] getVehicleRecord(string slot)
        {

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

        private void handleParkAreaClick(string btn, string s_loc, int floor)
        {


            OccupiedArea();
            if (!isOccupied(s_loc))
            {
                setSloc(s_loc);
                pe1 = new ParkingEntry(flowLayoutPanel2);
                pe1.ParkingRecordAdded += ParkingRecordAddedHandler;
                pe1.setLocationArea(s_loc, floor);
                pe1.setSelectedArea(true);
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

            handleParkAreaClick("b1", "BM-01", 1);
        }

        private void b02_Click(object sender, EventArgs e)
        {

            handleParkAreaClick("b2", "BM-02", 1);
        }

        private void b03_Click_1(object sender, EventArgs e)
        {
            handleParkAreaClick("b3", "BM-03", 1);
        }

        private void b04_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("b4", "BM-04", 1);
        }

        private void b05_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("b5", "BM-05", 1);
        }

        private void b06_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("b6", "BM-06", 1);
        }

        private void b07_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("b7", "BM-07", 1);
        }

        private void b08_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("b8", "BM-08", 1);
        }

        private void b09_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("b9", "BM-08", 1);
        }

        private void b10_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("b10", "BM-10", 1);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("a1", "A-01", 2);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("a2", "A-02", 2);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("a3", "A-03", 2);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("a4", "A-04", 2);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("a5", "A-05", 2);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("a6", "A-06", 2);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("a7", "A-07", 2);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("a8", "A-08", 2);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("a9", "A-09", 2);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("a10", "A-10", 2);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("bb01", "B-01", 3);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("bb02", "B-02", 3);
        }
        private void button36_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("bb03", "B-03", 3);
        }
        private void button35_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("bb04", "B-04", 3);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("bb05", "B-05", 3);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("bb06", "B-06", 3);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("bb07", "B-07", 3);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("bb08", "B-08", 3);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("bb09", "B-09", 3);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            handleParkAreaClick("bb_10", "B-10", 3);
        }

        private void btnViewParkLot_MouseHover(object sender, EventArgs e)
        {


        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Content.Controls.Add(vehicleListPanel);
            vehicleListPanel.Dock = DockStyle.Fill;
            vehicleListPanel.Show();
            parkingView.Dock = DockStyle.None;
            Content.Controls.Remove(parkingView);
            parkingView.Hide();
            refreshParkingArea();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pe1 = new ParkingEntry(flowLayoutPanel2);
            pe1.ParkingRecordAdded += ParkingRecordAddedHandler;
            pe1.ShowDialog();
        }
    }
}
