using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Parking
{
    public partial class Parkout : Form
    {

       public event EventHandler ParkingRecordAdded;
        public event EventHandler Parking;
        private string palteNum, Type;
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";
 

        private static Parkout instance;

        public static Parkout Instance
        {
            get
            {
                if (instance == null)
                    instance = new Parkout();
                return instance;
            }
        }

        public FlowLayoutPanel getFlowVH() {
            return flowPanelVH;
        }




        public Parkout()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Parkout_Load(object sender, EventArgs e)
        {
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.Status == "PARKED")
                {
                    ParkOutList POL = new ParkOutList(flowPanelVH, this, setAmt, setStatus);
                    POL.UpdateLabels(record);
                    POL.ParkingRecordAdded += ParkOutList_ParkingRecordAdded;
                    listOfVehicle.Controls.Add(POL);
                }
            }
        }
        private void ParkOutList_ParkingRecordAdded(object sender, EventArgs e)
        {
            Parking?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
        private void parkOutList1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listOfVehicle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        public void getVHparkOutnType(string paltenum, string type)
        {
            palteNum = paltenum;
            Type = type;
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            //parkout
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

            if (palteNum == null || palteNum == "")
            {
                MessageBox.Show("Please select a vehicle", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];

                if (record.Status != "Cleared" && record.PlateNumber == palteNum)
                {
                    var parkingHistoryRecords = ParkingRecordsManager.Instance;

                 
                    if (enterAmt.Text != "")
                    {
                        if (!double.TryParse(enterAmt.Text, out double amt))
                        {
                            MessageBox.Show("Invalid input. Please enter a valid numeric amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            if (setAmt.Text != "" && double.Parse(enterAmt.Text) >= double.Parse(setAmt.Text))
                            {

                                record.Status = "Cleared";
                                setChange.Text = (double.Parse(enterAmt.Text) - double.Parse(setAmt.Text)).ToString();
                                setStatus.Text = "Successfully paid the amount";
                                setStatus.ForeColor = Color.GreenYellow;

                                ParkingHistoyRecord carDetails = new ParkingHistoyRecord(record.id, convertSlocToSId(record.S_location), record.PlateNumber,
                                                                                        record.Type, record.Model, record.Driver, record.Phone,
                                                                                        record.ArrivalDate, record.ArrivalTime, parkOutDate.Value.ToString("MM/dd/yyyy"),
                                                                                        parkOutTime.Value.ToString("hh:mm:ss tt"), setTIME, setHOURS, Double.Parse(setChange.Text),
                                                                                        Double.Parse(enterAmt.Text));
                                parkingRecordsManager.AddParkingHistoryRecord(carDetails);
                                UpdateVehicleFromList(record.PlateNumber);
                                updateAvailability_query(record.S_location);
                                palteNum = null;
                                return;
                            }
                            else
                            {
                                if (setHours.Text != "")
                                {
                                    MessageBox.Show("Insufficient amount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Please set Date/Time", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    } 
                        Parking?.Invoke(this, EventArgs.Empty);
                }
                
                  
            }
            Parkin parkin = new Parkin();
            parkin.setIsParkin(false);
            
        }


        private void updateAvailability_query(string selectedSlot)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string updateQuery = "UPDATE V_Slots SET availability = 1 WHERE s_loc = @s_loc";


                SqlCommand command = new SqlCommand(updateQuery, connection);

                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@s_loc", selectedSlot);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private int convertSlocToSId(string s_loc) {
            int s_id = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string getSlotIDQuery = "SELECT s_id FROM V_Slots WHERE s_loc = @s_loc";

                SqlCommand command = new SqlCommand(getSlotIDQuery, connection);
                command.Parameters.AddWithValue("@s_loc", s_loc);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        s_id = (int)result; 
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                     
                }
            }

            return s_id;
        }

        private void setTransaction(int vehicleId, int slotId, int admin_id)
        {

            string insertQuery = "INSERT INTO Transactions (v_id, s_id, transaction_date, admin_id) VALUES (@v_id, @s_id, @transaction_date, @admin_id)";

            DateTime transactionDate = DateTime.Now;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                  
                    command.Parameters.AddWithValue("@v_id", vehicleId);
                    command.Parameters.AddWithValue("@s_id", slotId);
                    command.Parameters.AddWithValue("@transaction_date", transactionDate);
                    command.Parameters.AddWithValue("@admin_id", admin_id);


                    try
                    {
                         
                        connection.Open();

                     
                        int rowsAffected = command.ExecuteNonQuery();

                        
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Data inserted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("No rows were affected.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        private void UpdateVehicleFromList(String PlateNumber)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE  Vehicle  SET status = 'cleared' WHERE v_plate = @v_plate";


                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@v_plate", PlateNumber);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Record successfully deleted.");
                        }
                        else
                        {
                            Console.WriteLine("No record found with the specified id.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Parking?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listOfVehicle.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            bool foundRecord = false;
            int count = 0;
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.Status != "cleared")
                {
                    ParkOutList POL = new ParkOutList(flowPanelVH, this, setAmt, setStatus);
                    POL.UpdateLabels(record);
                    POL.ParkingRecordAdded += ParkOutList_ParkingRecordAdded;
                    listOfVehicle.Controls.Add(POL);
                    count++;
                }
            }

            if (count == 0)
            {
                Label noResultsLabel = new Label();
                noResultsLabel.Text = "No results found.";
                listOfVehicle.Controls.Add(noResultsLabel);
            }

            flowPanelVH.Controls.Clear();
            setAmt.Text = "";
            setStatus.Text = "";
            setChange.Text = "";
            enterAmt.Text = "";
            searchVHTxt.Text = "";
            setHours.Text = "";
            invalidD.Text = "";
            invalidT.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listOfVehicle.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            bool foundRecord = false;
            if(searchVHTxt.Text != "")
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.Status != "cleared")
                {
                    if (record.PlateNumber.Contains(searchVHTxt.Text))
                    {
                        ParkOutList POL = new ParkOutList(flowPanelVH, this, setAmt, setStatus);
                        POL.UpdateLabels(record);
                        POL.ParkingRecordAdded += ParkOutList_ParkingRecordAdded;
                        listOfVehicle.Controls.Add(POL);
                        foundRecord = true;
                    }
                }

            }
            if (!foundRecord)
            {
                Label noResultsLabel = new Label();
                noResultsLabel.Text = "No results found.";
                listOfVehicle.Controls.Add(noResultsLabel);
            }
        }

        private void seeAll_Click(object sender, EventArgs e)
        {
            listOfVehicle.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            bool foundRecord = false;
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.Status != "cleared")
                {
                    ParkOutList POL = new ParkOutList(flowPanelVH, this, setAmt, setStatus);
                    POL.UpdateLabels(record);
                    POL.ParkingRecordAdded += ParkOutList_ParkingRecordAdded;
                    listOfVehicle.Controls.Add(POL);
                    foundRecord = true;
                }
            }

            if (!foundRecord)
            {
                Label noResultsLabel = new Label();
                noResultsLabel.Text = "No results found.";
                noResultsLabel.ForeColor = Color.White;
                listOfVehicle.Controls.Add(noResultsLabel);
            }


        }
        private void change_Click(object sender, EventArgs e)
        {

        }
        double setHOURS,setTIME;   
        private void button5_Click(object sender, EventArgs e)
        {
            //here to compute time/amt
            setStatus.Text = "Not Paid";
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            if(flowPanelVH.Controls.Count != 0)
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.PlateNumber == palteNum)
                {           
                        if (record.Status != "Cleared")
                        {

                        double flagDown = 0;
                        double succeedingAmt = 0;
                        var vehiclemanger = VehicleManger.Instance;
                        var VPM = vehiclemanger.GetVPM();
                        foreach (var vpm in VPM)
                        {
                            if (vpm.vehicleType == Type)
                            {
                                flagDown = vpm.flagDown;
                                succeedingAmt = vpm.additionalAmtPerHour;
                            }
                        }
                        // arrival dateTime
                        string arrivalDate = record.ArrivalDate;
                        string arrvalTime = record.ArrivalTime;
                        string arrivalDateTime = arrivalDate + " " + arrvalTime;
                        DateTime parkin = DateTime.Parse(arrivalDateTime);                 
                        // Park out time
                        DateTime selectedDate = parkOutDate.Value;
                        DateTime selectedTime = parkOutTime.Value;
                        string formattedDateTime = selectedDate.ToString("MM/dd/yyyy");
                        string time = selectedTime.ToString("hh:mm:ss tt");
                        string parkout = formattedDateTime + " " + time;
                        DateTime toPARKOUT = DateTime.Parse(parkout);
                        TimeSpan duration = toPARKOUT -  parkin;
                        int HOURS = 0;
                        int day = 0;
                        int year = toPARKOUT.Year - parkin.Year;

                        if (year >= 1)
                        {
                            day = (int)duration.TotalDays % 365;
                            HOURS = ((int)duration.TotalHours - year * 24 * 365) % 24;
                            Console.WriteLine("Parking Time: " + year + " Year/s " + day + " Day/s " + " and " + HOURS.ToString("0.00") + " Hour/s");
                        }
                        else if (duration.TotalHours > 23)
                        {
                            day = (int)duration.TotalDays;
                            HOURS = (int)duration.TotalHours % 24;
                            Console.WriteLine("Parking Time: " + day + " Day/s " + " and " + HOURS.ToString("0.00") + " Hour/s");
                        }
                        else
                        {
                            Console.WriteLine("Parking Time: " + duration.Hours.ToString("0.00") + " Hour/s");
                        }

                        HOURS =(int) duration.TotalHours;
                        double amount = flagDown;
                        double totalAmount = 0;

                        if (HOURS >= 1)
                        {
                            totalAmount = (int)(amount + succeedingAmt * HOURS);
                        }
                        else
                        {
                            totalAmount =amount;
                        }


                        int hours = HOURS;
                        int amt =(int) totalAmount;



                        if (toPARKOUT >= parkin)
                        {
                            setHOURS = amt;
                            setTIME = hours;
                            setAmt.Text = amt + "";
                            setHours.Text = hours + "";
                            invalidT.Text = "";
                            invalidD.Text = "";
                        }
                        else
                        {
                             DateTime p1 = DateTime.Parse(arrivalDate);
                            DateTime p2 = DateTime.Parse(arrvalTime);

                            if (parkOutDate.Value < p1 && parkOutTime.Value < p2)
                            {
                                invalidD.Text = "Cannot set on Past Date!";
                                invalidT.Text = "Invalid Time!";
                            }
                            else if (parkOutDate.Value < p1)
                                invalidD.Text = "Cannot set on PastDate!";
                            else if (parkOutTime.Value < p2)
                            {
                                invalidT.Text = "Invalid Time!";
                            }                                                    
                        }
                    }            
                }
            }           
        }
    }
}