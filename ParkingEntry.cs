using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        public ParkingEntry(FlowLayoutPanel flowLayoutPanel2)
        {
            InitializeComponent();
            this.flowLayoutPanel2 = flowLayoutPanel2;
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
            string driverName = driver.Text;
            string phoneNUm = phoneNo.Text;
            DateTime currentDateTime = DateTime.Now;
            string ArrivalDate = currentDateTime.ToString("MM/dd/yyyy");
            string ArrivalTime = currentDateTime.ToString("hh:mm:ss tt");



          
          //  DateTime selectedDateTime = dateDepart.Value;
          //  string formattedDateTime = selectedDateTime.ToString("MM/dd/yyyy");
           // string time = selectedDateTime.ToString("hh:mm:ss tt");   
            /*

            double flagdown = 0;
            double succeedingAmt = 0;
            var vehiclemanger = VehicleManger.Instance;
            var VPM = vehiclemanger.GetVPM();
            foreach (var record in VPM)
            {
                if (record.vehicleType == type)
                {
                    flagdown = record.flagDown;
                    succeedingAmt = record.additionalAmtPerHour;
                }

            }

            string parkout = formattedDateTime + " " + time;
            DateTime toPARKOUT = DateTime.Parse(parkout);


            TimeSpan duration = toPARKOUT - currentDateTime;
            double hour = 0;
            int day = 0;
            int year = toPARKOUT.Year - currentDateTime.Year;

            if (year >= 1)
            {
                day = (int)duration.TotalDays % 365;
                hour = (duration.TotalHours - year * 24 * 365) % 24;
                Console.WriteLine("Parking Time: " + year + " Year/s " + day + " Day/s " + " and " + hour.ToString("0.00") + " Hour/s");
            }
            else if (duration.TotalHours > 23)
            {
                day = (int)duration.TotalDays;
                hour = duration.TotalHours % 24;
                Console.WriteLine("Parking Time: " + day + " Day/s " + " and " + hour.ToString("0.00") + " Hour/s");
            }
            else
            {
                Console.WriteLine("Parking Time: " + duration.Hours.ToString("0.00") + " Hour/s");
            }
            hour = duration.TotalHours;
            double amount = flagdown;
            double totalAmount = 0;

            if (hour >= 1)
            {
                totalAmount = amount + succeedingAmt * hour;
            }
            else
            {
                totalAmount = amount;
            }


            double hours = Math.Round(hour, 1);
            double amt = Math.Round(totalAmount, 2);
            */

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

        


            if (proccedAddItem == 3)
            {
                ParkingRecord carDatails = new ParkingRecord(platenum, type, model, driverName, phoneNUm, ArrivalDate, ArrivalTime, "PARKED");
                var parkingRecordsManager = ParkingRecordsManager.Instance;
                parkingRecordsManager.AddParkingRecord(carDatails);
                ParkingRecordAdded?.Invoke(this, EventArgs.Empty);
                invalid.Text = "Succesfully added new Vehicle!";
                invalid.ForeColor = Color.Chartreuse;

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
    }





}
