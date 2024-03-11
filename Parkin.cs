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
    public partial class Parkin : UserControl
    {
        //

        ParkingEntry pe1;
        Parkout pOut;
        public Parkin()
        {
            InitializeComponent();
            //  display();
            filterDisplay("PARKED");
            numV.Text = countVehicle() + "";
            numPV.Text = countParkedVehicle() + "";
            numCV.Text = countClearedVehicle() + "";
            history1.Hide();
            admin1.Hide();
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

                if (sidebar.Width >= 200)
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
                // Assuming numV, numCV, numPV are defined elsewhere in your code
                parkinList pL = new parkinList(numV, numCV, numPV); // Adjust this according to your class constructor
                pL.UpdateLabels(record);
                flowLayoutPanel2.Controls.Add(pL);
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
            filterDisplay("Cleared");

        }

        private void btnParked_Click(object sender, EventArgs e)
        {
            filterDisplay("PARKED");
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            filterDisplay("ALL");
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
                    parkinList pL = new parkinList(numV, numCV, numPV);
                    pL.UpdateLabels(record);
                    flowLayoutPanel2.Controls.Add(pL);
                    foundRecord = true;
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

            admin1.Hide();
            history1.Hide();
            panel5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            history1.Show();
            admin1.Hide();
            var parkingRecordsManager = History.Instance;
            parkingRecordsManager.display();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            admin1.Show();


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

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;


            int width = panel11.Width;
            int height = panel11.Height;


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
    }
}
