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
    public partial class ParkOutList : UserControl
    {
        public event EventHandler ParkingRecordAdded;
        private ParkingRecord parkingRecord;
        private FlowLayoutPanel flowPanelVH;
        private Parkout titleLabel;
        private System.Windows.Forms.Label amtTxt;
        private System.Windows.Forms.Label statusTxt;



        public ParkOutList(FlowLayoutPanel flowPanelVH, Parkout titleLabel, System.Windows.Forms.Label amtTxt, System.Windows.Forms.Label statusTxt)
        {
            InitializeComponent();
            this.flowPanelVH = flowPanelVH;
            this.titleLabel = titleLabel;
            this.amtTxt = amtTxt;
            this.statusTxt = statusTxt;
        }

        private void ParkOutList_Load(object sender, EventArgs e)
        {

        }

        public void UpdateLabels(ParkingRecord parkRecord)
        {
            parkingRecord = parkRecord; // Store the ParkingRecord associated with this control
            plateNo.Text = parkRecord.PlateNumber;
            type.Text = parkRecord.Type;
            brand.Text = parkRecord.Model;
 
        }

       

        private void parkout_Click(object sender, EventArgs e)
        {
            //parkingRecord.Status = "Cleared";
            //  ParkingRecordAdded?.Invoke(this, EventArgs.Empty);

            

            titleLabel.getVHparkOutnType(parkingRecord.PlateNumber,parkingRecord.Type);
           // amtTxt.Text = parkingRecord.Amount+"";
            statusTxt.Text = "Not Paid";

            flowPanelVH.Controls.Clear();
          
            string selectedPlateNo = plateNo.Text;
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();

           
              foreach (var record in allParkingRecords)
             { 
                if(record.PlateNumber == selectedPlateNo)
                {
                    vehicleDetails Plate = new vehicleDetails();
                    Plate.UpdateLabels("Plate No.", record.PlateNumber);
                    flowPanelVH.Controls.Add(Plate);
                    


                    vehicleDetails Type = new vehicleDetails();
                    Type.UpdateLabels("Type", record.Type);
                    flowPanelVH.Controls.Add(Type);

                    vehicleDetails Model = new vehicleDetails();
                    Model.UpdateLabels("Model", record.Model);
                    flowPanelVH.Controls.Add(Model);

                    vehicleDetails Driver = new vehicleDetails();
                    Driver.UpdateLabels("Driver", record.Driver);
                    flowPanelVH.Controls.Add(Driver);

                    vehicleDetails Phone = new vehicleDetails();
                    Phone.UpdateLabels("Phone", record.Phone);
                    flowPanelVH.Controls.Add(Phone);

                    vehicleDetails ArrivalDate = new vehicleDetails();
                    ArrivalDate.UpdateLabels("Arrival Date", record.ArrivalDate);
                    flowPanelVH.Controls.Add(ArrivalDate);

                    vehicleDetails ArrivalTime = new vehicleDetails();
                    ArrivalTime.UpdateLabels("Arrival Time", record.ArrivalTime);
                    flowPanelVH.Controls.Add(ArrivalTime);

                   // vehicleDetails DepartureDate = new vehicleDetails();
                   // DepartureDate.UpdateLabels("Departure Date", record.DepartureDate);
                   // flowPanelVH.Controls.Add(DepartureDate);

                 //   vehicleDetails DepartureTime = new vehicleDetails();
                 //   DepartureTime.UpdateLabels("Departure Time", record.DepartureTime);
                 //   flowPanelVH.Controls.Add(DepartureTime);

                  //  vehicleDetails Hours = new vehicleDetails();
                //    Hours.UpdateLabels("Hours", record.Hours+"");
                  //  flowPanelVH.Controls.Add(Hours);

                    
                    return;
                }               
              }
        }
    }
}
