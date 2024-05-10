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

        string imagePath1 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car1.png";
        string imagePath2 = @"C:\Users\carlconrad\source\Parking-Management-System\img\Car2.png";
        string Sloc;
        ParkingEntry pe1;
        Parkout pOut;
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

        private void ParkingRecordAddedHandler(object sender, EventArgs e)
        {
            display();
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
            OccupiedArea();
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



        private void handletParkingArea(string btn)
        {
            handleParkingImage(btn);
            handleBool(btn);
            HandleNullImage(btn);
            handleLabel(btn);
        }

        private void handleParkingImage(string btn)
        {

            Image image = Image.FromFile(imagePath2);

            switch (btn)
            {
                case "b1":
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
                    break;
                case "b2":
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
                    break;
                case "b3":
                    if (b3)
                    {
                        b03.Image = image;
                        labelB3.Text = "";
                    }
                    else
                    {
                        b03.Image = null;
                        setSloc(null);
                        labelB3.Text = "BM-03";
                    }
                    b3 = !b3;
                    break;
                case "b4":
                    if (b4)
                    {
                        b04.Image = image;
                        labelB4.Text = "";
                    }
                    else
                    {
                        b04.Image = null;
                        setSloc(null);
                        labelB4.Text = "BM-04";
                    }
                    b4 = !b4;
                    break;
                case "b5":
                    if (b5)
                    {
                        b05.Image = image;
                        labelB5.Text = "";
                    }
                    else
                    {
                        b05.Image = null;
                        setSloc(null);
                        labelB5.Text = "BM-05";
                    }
                    b5 = !b5;
                    break;
                case "b6":
                    if (b6)
                    {
                        b06.Image = image;
                        labelB6.Text = "";
                    }
                    else
                    {
                        b06.Image = null;
                        setSloc(null);
                        labelB6.Text = "BM-06";
                    }
                    b6 = !b6;
                    break;
                case "b7":
                    if (b7)
                    {
                        b07.Image = image;
                        labelB7.Text = "";
                    }
                    else
                    {
                        b07.Image = null;
                        setSloc(null);
                        labelB7.Text = "BM-07";
                    }
                    b7 = !b7;
                    break;
                case "b8":
                    if (b8)
                    {
                        b08.Image = image;
                        labelB8.Text = "";
                    }
                    else
                    {
                        b08.Image = null;
                        setSloc(null);
                        labelB8.Text = "BM-08";
                    }
                    b8 = !b8;
                    break;
            }
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

        private void handleLabel(string btn)
        {
            switch (btn)
            {
                case "b1":
                    labelB2.Text = "BM-02";
                    labelB3.Text = "BM-03";
                    labelB4.Text = "BM-04";
                    labelB5.Text = "BM-05";
                    labelB6.Text = "BM-06";
                    labelB7.Text = "BM-07";
                    labelB8.Text = "BM-08";
                    break;
                case "b2":
                    labelB1.Text = "BM-01";
                    labelB3.Text = "BM-03";
                    labelB4.Text = "BM-04";
                    labelB5.Text = "BM-05";
                    labelB6.Text = "BM-06";
                    labelB7.Text = "BM-07";
                    labelB8.Text = "BM-08";
                    break;
                case "b3":
                    labelB1.Text = "BM-01";
                    labelB2.Text = "BM-02";
                    labelB4.Text = "BM-04";
                    labelB5.Text = "BM-05";
                    labelB6.Text = "BM-06";
                    labelB7.Text = "BM-07";
                    labelB8.Text = "BM-08";
                    break;
                case "b4":
                    labelB1.Text = "BM-01";
                    labelB2.Text = "BM-02";
                    labelB3.Text = "BM-03";
                    labelB5.Text = "BM-05";
                    labelB6.Text = "BM-06";
                    labelB7.Text = "BM-07";
                    labelB8.Text = "BM-08";
                    break;
                case "b5":
                    labelB1.Text = "BM-01";
                    labelB2.Text = "BM-02";
                    labelB3.Text = "BM-03";
                    labelB4.Text = "BM-04";
                    labelB6.Text = "BM-06";
                    labelB7.Text = "BM-07";
                    labelB8.Text = "BM-08";
                    break;
                case "b6":
                    labelB1.Text = "BM-01";
                    labelB2.Text = "BM-02";
                    labelB3.Text = "BM-03";
                    labelB4.Text = "BM-04";
                    labelB5.Text = "BM-05";
                    labelB7.Text = "BM-07";
                    labelB8.Text = "BM-08";
                    break;
                case "b7":
                    labelB1.Text = "BM-01";
                    labelB2.Text = "BM-02";
                    labelB3.Text = "BM-03";
                    labelB4.Text = "BM-04";
                    labelB5.Text = "BM-05";
                    labelB6.Text = "BM-06";
                    labelB8.Text = "BM-08";
                    break;
                case "b8":
                    labelB1.Text = "BM-01";
                    labelB2.Text = "BM-02";
                    labelB3.Text = "BM-03";
                    labelB4.Text = "BM-04";
                    labelB5.Text = "BM-05";
                    labelB6.Text = "BM-06";
                    labelB7.Text = "BM-07";
                    break;
            }

        }

        private void b01_Click(object sender, EventArgs e)
        {
            handletParkingArea("b1");
            OccupiedArea();
            if (!isOccupied("BM-01"))
                setSloc("BM-01");

        }
        private void b02_Click(object sender, EventArgs e)
        {
            handletParkingArea("b2");
            OccupiedArea();
            OccupiedArea();
            if (!isOccupied("BM-02"))
                setSloc("BM-02");
        }

        private void b03_Click_1(object sender, EventArgs e)
        {
            handletParkingArea("b3");
            OccupiedArea();
            OccupiedArea();
            if (!isOccupied("BM-03"))
                setSloc("BM-03");
        }

        private void b04_Click(object sender, EventArgs e)
        {
            handletParkingArea("b4");
            OccupiedArea();
            OccupiedArea();
            if (!isOccupied("BM-04"))
                setSloc("BM-04");
        }

        private void b05_Click(object sender, EventArgs e)
        {
            handletParkingArea("b5");
            OccupiedArea();
            OccupiedArea();
            if (!isOccupied("BM-05"))
                setSloc("BM-05");
        }

        private void b06_Click(object sender, EventArgs e)
        {
            handletParkingArea("b6");
            OccupiedArea();
            if (!isOccupied("BM-06"))
                setSloc("BM-06");
        }

        private void b07_Click(object sender, EventArgs e)
        {
            handletParkingArea("b7");
            OccupiedArea();
            if (!isOccupied("BM-07"))
                setSloc("BM-07");
        }

        private void b08_Click(object sender, EventArgs e)
        {
            handletParkingArea("b8");
            OccupiedArea();
            if (!isOccupied("BM-08"))
                setSloc("BM-08");
        }

        private void b09_Click(object sender, EventArgs e)
        {

        }

        private void b10_Click(object sender, EventArgs e)
        {

        }
    }
}
