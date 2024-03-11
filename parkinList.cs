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
{/// <summary>
/// ////
/// </summary>

    public partial class parkinList : UserControl
    {
        public event EventHandler ItemRemoved;
        private System.Windows.Forms.Label numV;
        private System.Windows.Forms.Label numCV;
        private System.Windows.Forms.Label numPV;
        edit edt;
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
            label1.Text = parkRecord.PlateNumber;
            label2.Text = parkRecord.Type;
            label3.Text = parkRecord.Status;
         //   label4.Text = parkRecord.DepartureDate;

            label7.Text = parkRecord.ArrivalDate;
            label8.Text = parkRecord.ArrivalTime;
         //   label9.Text = parkRecord.Hours.ToString();
         //   label10.Text = parkRecord.Amount.ToString();
            label11.Text = parkRecord.Model;
          //  label12.Text = parkRecord.DepartureTime;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void parkinList_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(label1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (string.Equals(record.PlateNumber, label1.Text))
                {
                    // Remove the record from the manager
                    parkingRecordsManager.RemoveParkingRecord(record);
                    MessageBox.Show($"Record with PlateNumber {record.PlateNumber} removed.");

                    // Remove the UserControl from the flowLayoutPanel2
                    Parent.Controls.Remove(this);

                    // Notify the parent that an item is removed
                    ItemRemoved?.Invoke(this, EventArgs.Empty);


                    var prm1 = ParkingRecordsManager.Instance;
                    numV.Text = prm1.GetAllParkingRecords().Count + "";


                    var prm2 = ParkingRecordsManager.Instance.GetAllParkingRecords();
                    int countCleareVehicle = 0;
                    foreach (var recordCV in prm2)
                        if (recordCV.Status == "Cleared")
                            countCleareVehicle++;
                    numCV.Text = countCleareVehicle + "";


                    var prm3 = ParkingRecordsManager.Instance.GetAllParkingRecords();
                    int countParkedVehicle = 0;
                    foreach (var recordCV in prm3)
                        if (recordCV.Status == "PARKED")
                            countParkedVehicle++;
                    numPV.Text = countParkedVehicle + "";


                    break;
                }
            }




        }


        private void EditSelectedRecord()
        {
            edt = new edit();

            edt.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
