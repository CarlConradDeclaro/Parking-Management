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
using System.Drawing.Drawing2D;

namespace Parking
    {
    public partial class Parkin : UserControl
    {
        String connectionString = ConnectionString.Instance.connectionString();
        string imagePath1 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car2.png";
        string imagePath2 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car1.png";
        string Sloc;
        ParkingEntry pe1;
        Parkout pOut;
        private FlowLayoutPanel flowPanelVH;
        private bool isParkin;
        public string username;
        public int userID;

        Image maleAdmin = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\maleAdmin.png");
        Image femaleAdmin = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\femaleAdmin.png");


        private Dashboard _dashboard;
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
            countSlots();
            numPV.Text = countParkedVehicle() + "";
            panel5.Show();
            parkingView.Hide();
            profilePanel.Hide();
            PanelDashboard.Hide();
            OccupiedArea();

            var c = UserDetails.Instance;

            adminIcon.Image = c.getGender() == "MALE" ? maleAdmin : femaleAdmin;
            adminName.Text = c.getFirstname();
            displayProfileDetails();
            adminPanel.SetRoundedCorners(20);
            panel7.SetRoundedCorners(10);
            panel8.SetRoundedCorners(10);
            panel9.SetRoundedCorners(10);
            panel10.SetRoundedCorners(10);
            panel20.SetRoundedCorners(10);
            panel4.SetRoundedCorners(10);
            panel3.SetRoundedCorners(8);

            panel16.SetRoundedCorners(10);
            panel17.SetRoundedCorners(10);
            panel18.SetRoundedCorners(10);

            panel27.SetRoundedCorners(15);
            profileDetailsPanel.SetRoundedCorners(15);


            _dashboard = new Dashboard();

            if (countParkedVehicle() == 0)
                flowLayoutPanel6.Controls.Add(NoVehicleDatapanel);
            if (countParkedVehicle() > 0)
                flowLayoutPanel6.Controls.Remove(NoVehicleDatapanel);


        }
     


        private void isParkEmpty(bool isEmpty)
        {
            if (isEmpty)
                flowLayoutPanel2.Controls.Add(emptyPark);

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

        bool sidebarExpand = false;

        private void expandSiderbar_Tick(object sender, EventArgs e)
        {
            sidebar.Width += 10;
            if (sidebar.Width >= 230)
            {
                sidebarExpand = true;
                expandSiderbar.Stop();
            }
        }
        private void expandMenu_Tick(object sender, EventArgs e)
        {
            menuContainer.Height += 10;
            if (menuContainer.Height >= 500)
            {
                expandMenu.Stop();
                menuExpand = true;
            }
        }




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
        bool menuExpand = false;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 500)
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
        private void YourForm_VehicleParked(object sender, EventArgs e)
        {

           // dashboard1.Display();
         //   Dashboard.Instance.Display();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pe1 = new ParkingEntry(flowLayoutPanel2);
            pe1.ParkingRecordAdded += ParkingRecordAddedHandler;
            pe1.VehicleParked += YourForm_VehicleParked;
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
            numPV.Text = countParkedVehicle() + "";

        }

        private void parkout_Click(object sender, EventArgs e)
        {
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

            if (allParkingRecords.Count(r => r.Status == "PARKED") != 0)
            {
                pOut = new Parkout();
                pOut.Parking += ParkingRecordAddedHandler;

                pOut.ShowDialog();

            }
            else
                MessageBox.Show("Opps, there are no vehicles to parkout.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



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
            refreshSearcHighlights();
            countSlots();


            if (countParkedVehicle() == 0)
                isParkEmpty(true);
            else
                isParkEmpty(false);
        }

        public void countSlots()
        {
            numV.Text = 30 - countParkedVehicle() + "";
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
                    pL.EditParking += ParkingRecordAddedHandler;
                    flowLayoutPanel2.Controls.Add(pL);
                }
                else if (category == "ALL")
                {
                    parkinList pL = new parkinList(numV, numPV);
                    pL.UpdateLabels(record);
                    flowLayoutPanel2.Controls.Add(pL);
                }
            }

            if (countParkedVehicle() == 0)
                isParkEmpty(true);
            else
                isParkEmpty(false);
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
                    if (record.Status != "cleared")
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

        private void button49_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Add(PanelDashboard);
            PanelDashboard.Dock = DockStyle.Fill;
            PanelDashboard.Show();
            panelProfile.SetRoundedCorners(10);
            panelAvailSlot.SetRoundedCorners(10);
            panelUsers.SetRoundedCorners(10);
            panelOccupied.SetRoundedCorners(10);
            flowLayoutParkedV.SetRoundedCorners(10);
            flowLayoutPanel6.SetRoundedCorners(10);
            panel2.SetRoundedCorners(10);
            Display();
            DisplayTotalEarnings();
            DisplayAdmin();
            displayOccupiedSlot();
            dispayAvailableSlot();
            displayTotalVehicleParked();
            displayVehicleData();

            panelContent.Controls.Remove(panel5);
            panel5.Dock = DockStyle.None;
            panel5.Hide();

            history1.Dock = DockStyle.None;
            panelContent.Controls.Remove(history1);
            history1.Hide();

            admin1.Dock = DockStyle.None;
            panelContent.Controls.Remove(admin1);
            admin1.Hide();

            panelContent.Controls.Remove(profilePanel);
            profilePanel.Dock = DockStyle.None;
            profilePanel.Hide();

            PanelDashboard.VisibleChanged += Dashboard1_VisibleChanged;

        }
        private void Dashboard1_VisibleChanged(object sender, EventArgs e)
        {
             if (PanelDashboard.Visible)
            {
               Display();
               DisplayTotalEarnings();
              DisplayAdmin();
               displayOccupiedSlot();
                dispayAvailableSlot();
                displayTotalVehicleParked();
                displayVehicleData();

                if (countParkedVehicle() == 0)
                    flowLayoutPanel6.Controls.Add(NoVehicleDatapanel);
                if (countParkedVehicle() >0)
                    flowLayoutPanel6.Controls.Remove(NoVehicleDatapanel);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Remove(PanelDashboard);
            PanelDashboard.Dock = DockStyle.None;
            PanelDashboard.Hide();

            panelContent.Controls.Add(panel5);
            panel5.Dock = DockStyle.Fill;
            panel5.Show();


            history1.Dock = DockStyle.None;
            panelContent.Controls.Remove(history1);
            history1.Hide();

            admin1.Dock = DockStyle.None;
            panelContent.Controls.Remove(admin1);
            admin1.Hide();

            panelContent.Controls.Remove(profilePanel);
            profilePanel.Dock = DockStyle.None;
            profilePanel.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Remove(PanelDashboard);
            PanelDashboard.Dock = DockStyle.None;
            PanelDashboard.Hide();

            panelContent.Controls.Remove(panel5);
            panel5.Dock = DockStyle.None;
            panel5.Hide();

            panelContent.Controls.Add(history1);
            history1.Dock = DockStyle.Fill;
            history1.Show();

            admin1.Dock = DockStyle.None;
            panelContent.Controls.Remove(admin1);
            admin1.Hide();

            panelContent.Controls.Remove(profilePanel);
            profilePanel.Dock = DockStyle.None;
            profilePanel.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Remove(PanelDashboard);
            PanelDashboard.Dock = DockStyle.None;
            PanelDashboard.Hide();

            panelContent.Controls.Remove(panel5);
            panel5.Dock = DockStyle.None;
            panel5.Hide();

            panelContent.Controls.Remove(history1);
            history1.Dock = DockStyle.None;
            history1.Hide();

            admin1.Dock = DockStyle.Fill;
            panelContent.Controls.Add(admin1);
            admin1.Show();

            panelContent.Controls.Remove(profilePanel);
            profilePanel.Dock = DockStyle.None;
            profilePanel.Hide();



        }

        private void button12_Click(object sender, EventArgs e)
        {
            //profilePanel
            panelContent.Controls.Remove(PanelDashboard);
            PanelDashboard.Dock = DockStyle.None;
            PanelDashboard.Hide();

            panelContent.Controls.Remove(panel5);
            panel5.Dock = DockStyle.None;
            panel5.Hide();

            panelContent.Controls.Remove(history1);
            history1.Dock = DockStyle.None;
            history1.Hide();

            panelContent.Controls.Remove(admin1);
            admin1.Dock = DockStyle.None;
            admin1.Hide();

            panelContent.Controls.Add(profilePanel);
            profilePanel.Dock = DockStyle.Fill;
            profilePanel.Show();

        }
        public void displayVehicleData()
        {
            flowLayoutPanel6.Controls.Clear();
            var vehiclemanger = VehicleManger.Instance;
            var VPM = vehiclemanger.GetVPM();

            foreach (var record in VPM)
            {
                VehiclesData vd = new VehiclesData();
                vd.updateLabel(record.vehicleType, record.flagDown + "", "+"+record.additionalAmtPerHour + "", countNumberTypeVehicle(record.vehicleType) + "");
                flowLayoutPanel6.Controls.Add(vd);
            }
        }

        private int countNumberTypeVehicle(string type)
        {
            int numOfVehicles = 0;
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingHistoryRecords = parkingRecordsManager.GetAllParkingHistoryRecords();

            foreach (var record in allParkingHistoryRecords)
            {
                if (record.Type == type)
                    numOfVehicles++;
            }
            return numOfVehicles;
        }


        public void Display()
        {
            flowLayoutParkedV.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.Status == "PARKED")
                {
                    ParkedVehicles pv = new ParkedVehicles();
                    pv.updateLabel(record.PlateNumber, record.S_location);
                    flowLayoutParkedV.Controls.Add(pv);
                }
            }

            firstname.Text = UserDetails.Instance.getFirstname();
            lastname.Text = UserDetails.Instance.getLastname();


            if (UserDetails.Instance.getGender() == "MALE")
                dashboardProfilePanel.BackgroundImage = maleAdmin;
            if (UserDetails.Instance.getGender() == "FEMALE")
                dashboardProfilePanel.BackgroundImage = femaleAdmin;


        }

        public void DisplayTotalEarnings()
        {


            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingHistoryRecords = parkingRecordsManager.GetAllParkingHistoryRecords();
            double amt = 0;
            for (int i = allParkingHistoryRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingHistoryRecords[i];
                amt += record.Amount;
            }
            earningLabel.Text = amt.ToString("₱ #,##0.00");
        }

        public void DisplayAdmin()
        {
            string query = "SELECT COUNT(*) FROM UsersData";


            int userCount = 0;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(query, connection))
                {


                    try
                    {

                        connection.Open();


                        userCount = (int)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            adminLabel.Text = userCount.ToString("#,##0");
        }


        public void displayOccupiedSlot()
        {
            occSlotLabel.Text = countParkedVehicle().ToString("#,##0");
        }
        public void dispayAvailableSlot()
        {
            availSlot.Text = (30 - countParkedVehicle()).ToString("#,##0");
        }
        public void displayTotalVehicleParked()
        {
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingHistoryRecords = parkingRecordsManager.GetAllParkingHistoryRecords();
            totalVehicle.Text = allParkingHistoryRecords.Count.ToString("#,##0"); ;

        }
       

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            /* Graphics g = e.Graphics;
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
             }*/
        }
        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            /* Graphics g = e.Graphics;
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
             }*/
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




        private void btnViewParkLot_Click(object sender, EventArgs e)
        {

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
            handleParkAreaClick("b9", "BM-09", 1);
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
            refreshSearcHighlights();
        }




        private void refreshSearcHighlights()
        {
            Button[] button = [b01, b02, b03, b04, b05, b06, b07, b08,b09,b10,
                               button28, button27, button26, button25, button24, button23, button22, button21, button20, button19,
                              button38, button37, button36, button35, button34, button33, button32, button31, button30, button29];
            for (int i = 0; i < 30; i++)
                button[i].BackColor = Color.Transparent;
            searchPlateNo.Text = "";
            noFoundLabel.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pe1 = new ParkingEntry(flowLayoutPanel2);
            pe1.ParkingRecordAdded += ParkingRecordAddedHandler;
            pe1.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void logOut()
        {
            var c = UserDetails.Instance;
            c.clearUser();

            Form mainForm = this.FindForm();
            mainForm.Close();

            login login = new login();
            login.Show();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sLoc = "";
            string plateNumber = searchPlateNo.Text.ToUpper();
            string query = "SELECT s_sloc FROM Vehicle WHERE v_plate = @platenumber AND status = 'PARKED'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@platenumber", plateNumber);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sLoc = reader["s_sloc"].ToString();
                    Console.WriteLine(sLoc);
                }
            }


            Button[] button = [b01, b02, b03, b04, b05, b06, b07, b08,b09,b10,
                               button28, button27, button26, button25, button24, button23, button22, button21, button20, button19,
                              button38, button37, button36, button35, button34, button33, button32, button31, button30, button29];
            string[] labelNames = { "BM-01", "BM-02", "BM-03", "BM-04", "BM-05", "BM-06", "BM-07", "BM-08", "BM-09", "BM-10",
                            "A-01", "A-02", "A-03", "A-04", "A-05", "A-06", "A-07", "A-08", "A-09", "A-10",
                            "B-01", "B-02", "B-03", "B-04", "B-05", "B-06", "B-07", "B-08", "B-09", "B-10" };

            for (int i = 0; i < 30; i++)
                if (labelNames[i] == sLoc)
                {
                    button[i].BackColor = Color.YellowGreen;
                    noFoundLabel.Text = "";
                    break;
                }
                else
                {
                    button[i].BackColor = Color.Transparent;
                    noFoundLabel.Text = "Not Found!";

                }
        }



        private void All_Click(object sender, EventArgs e)
        {
            display();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            if (allParkingRecords.Count(r => r.Status == "PARKED") != 0)
            {
                pOut = new Parkout();
                pOut.Parking += ParkingRecordAddedHandler;
                pOut.ShowDialog();
            }
            else
                MessageBox.Show("Opps, there are no vehicles to parkout.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void button11_Click(object sender, EventArgs e)
        {
            logOut();
        }

        private void adminName_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void profilePanel_Paint(object sender, PaintEventArgs e)
        {
            displayProfileDetails();
        }

        public void displayProfileDetails()
        {
            var userData = UserDetails.Instance;
            profileName.Text = userData.getName();
            profileEmail.Text = userData.getEmail();
            profileNum.Text = userData.getPhoneNum();
            profileGender.Text = userData.getGender();
            Image MaleIcon = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\defaultBoy.png");
            Image FemaleIcon = Image.FromFile(@"C:\Users\carlconrad\source\Parking-Management-System\img\defaultGirl.png");
            profileIcon.BackgroundImage = profileGender.Text == "MALE" ? MaleIcon : FemaleIcon;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var userData = UserDetails.Instance;
            editProfile edit = new editProfile(
                userData.getId(),
                profileIcon,
                adminIcon,
                adminName,
                profileName,
                profileEmail,
                profileNum,
                profileGender,
                userData.getFirstname(),
                userData.getLastname(),
                userData.getEmail(),
                userData.getPhoneNum(),
                userData.getGender())
                ;
            edit.ShowDialog();
        }

        bool view = false;
        private void btnViewPass_Click(object sender, EventArgs e)
        {
            togglePassword();
        }

        private void togglePassword()
        {
            view = !view;

            if (view)
            {
                passLabel.Text = UserDetails.Instance.getPassword();
            }
            else
            {
                passLabel.Text = "*****************";
            }
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(newPass.Text))
            {
                MessageBox.Show("Password field can't be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            updatePassword(newPass.Text, UserDetails.Instance.getId());
            newPass.Text = "";
        }

        private void updatePassword(string newPass, int id)
        {
            string sqlQuery = "UPDATE UsersData SET uPassword = @uPassword  WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var userDatails = UserDetails.Instance;
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@uPassword", newPass);
                    command.Parameters.AddWithValue("@id", id);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UserDetails.Instance.setPassword(newPass);
                        togglePassword();
                    }
                    else
                    {
                        MessageBox.Show("No data was updated. Please check the ID and try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void sectionList1_Load(object sender, EventArgs e)
        {

        }
    }
}


public static class PanelExtensions
{
    public static void SetRoundedCorners(this Panel panel, int borderRadius)
    {
        panel.Paint += (sender, e) =>
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
            int diameter = borderRadius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y + bounds.Height - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);

            using (Pen pen = new Pen(panel.BackColor, 2))
            {
                g.DrawPath(pen, path);
            }
        };

        
        panel.Invalidate();
    }
}
