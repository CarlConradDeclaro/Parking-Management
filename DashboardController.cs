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

namespace Parking
{
    public partial class DashboardController : UserControl
    {
        string connectionString = ConnectionString.Instance.connectionString();
        public DashboardController()
        {
            InitializeComponent();
            panelProfile.SetRoundedCorners(15);

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
        }



        public void displayVehicleData()
        {
            flowLayoutPanel6.Controls.Clear();
            var vehiclemanger = VehicleManger.Instance;
            var VPM = vehiclemanger.GetVPM();

            foreach (var record in VPM)
            {
                VehiclesData vd = new VehiclesData();
                vd.updateLabel(record.vehicleType, record.flagDown + "", record.additionalAmtPerHour + "", countNumberTypeVehicle(record.vehicleType) + "");
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
            earningLabel.Text = amt.ToString("#,##0.00");
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

    }
}
