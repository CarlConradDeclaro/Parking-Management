﻿using System;
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
            else {
                proccedAddItem++;
                invalidPhone.Text = "";
            }
             

            if (proccedAddItem == 4)
            {
                ParkingRecord carDetails = new ParkingRecord(platenum.ToUpper(), type, model, driverName, phoneNUm, ArrivalDate, ArrivalTime, "PARKED");
                var parkingRecordsManager = ParkingRecordsManager.Instance;
                var records = parkingRecordsManager.GetAllParkingRecords();

                bool isAlreadyInList = false;

                foreach (var record in records)
                {
                    // Assuming Platenum uniquely identifies a parking record
                    if (record.PlateNumber.ToUpper() == platenum.ToUpper())
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
