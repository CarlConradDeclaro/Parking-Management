using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class parkinList : UserControl
    {
        public event EventHandler EditParking;
        private System.Windows.Forms.Label numV;
        private System.Windows.Forms.Label numCV;
        private System.Windows.Forms.Label numPV;
        ParkingRecord vehicleRecord;
        edit edt;
        public event EventHandler  editHandler;

        public parkinList(System.Windows.Forms.Label numV, System.Windows.Forms.Label numCV, System.Windows.Forms.Label numPV)
        {
            InitializeComponent();
            this.numV = numV;
            this.numCV = numCV;
            this.numPV = numPV;
        }

        private void parkinList_Load(object sender, EventArgs e)
        {

        }

        public void UpdateLabels(ParkingRecord parkRecord)
        {
            vehicleRecord =  parkRecord;
            label1.Text = parkRecord.PlateNumber;
            label2.Text = parkRecord.Type;
            label3.Text = parkRecord.Status;          
            label7.Text = parkRecord.ArrivalDate;
            label8.Text = parkRecord.ArrivalTime;          
            label11.Text = parkRecord.Model;             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void parkinList_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewParkinVH vph = new viewParkinVH();
            vph.UpdateLabels(vehicleRecord);
            vph.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var parkingRecordsManager = ParkingRecordsManager.Instance;
                var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

                for (int i = allParkingRecords.Count - 1; i >= 0; i--)
                {
                    var record = allParkingRecords[i];
                    if (string.Equals(record.PlateNumber, label1.Text))
                    {
                        parkingRecordsManager.RemoveParkingRecord(record);
                        MessageBox.Show("The vehicle with plate number " + label1.Text + " has been successfully removed.", "Vehicle Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Parent.Controls.Remove(this);                   
                        numV.Text = parkingRecordsManager.GetAllParkingRecords().Count.ToString();
                        numCV.Text = parkingRecordsManager.GetAllParkingRecords().Count(r => r.Status == "Cleared").ToString();
                        numPV.Text = parkingRecordsManager.GetAllParkingRecords().Count(r => r.Status == "PARKED").ToString();
                        break;
                    }
                }
            }
        }    
        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void ParkOutList_ParkingRecordAdded(object sender, EventArgs e)
        {
            EditParking?.Invoke(this, EventArgs.Empty);        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit editVehicle = new edit(vehicleRecord);
            editVehicle.editHandler += ParkOutList_ParkingRecordAdded;
            editVehicle.Show();
        }
    }
}
