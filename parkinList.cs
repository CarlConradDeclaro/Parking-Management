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
using System.Drawing.Drawing2D;

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

        public parkinList(System.Windows.Forms.Label numV  ,System.Windows.Forms.Label numPV)
        {
            InitializeComponent();
            this.numV = numV;
        
            this.numPV = numPV;
            this.setRounded(8);
        }

        private void parkinList_Load(object sender, EventArgs e)
        {
           
        }

        public void UpdateLabels(ParkingRecord parkRecord)
        {
            vehicleRecord =  parkRecord;
            label1.Text = parkRecord.PlateNumber;
            label2.Text = parkRecord.Type;
            label3.Text = parkRecord.S_location;          
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

                      
                        var records = parkingRecordsManager.GetAllParkingRecords();
                        int countParkedVehicle = 0;
                        foreach (var vehicle in records)
                        {
                            if (vehicle.Status == "PARKED")
                                countParkedVehicle++;
                        }
                        numV.Text = (30 - countParkedVehicle) + "";
                        numPV.Text = parkingRecordsManager.GetAllParkingRecords().Count(r => r.Status == "PARKED").ToString();
                        break;
                    }
                }
            }

          /*  Parkin p = new Parkin();
            p.OccupiedArea();*/
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

        public  void setRounded( int borderRadius)
        {
            this.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
                int diameter = borderRadius * 2;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y + bounds.Height - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Y + bounds.Height - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                using (Pen pen = new Pen(this.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }
            };

            // Invalidate to ensure the panel is redrawn
            this.Invalidate();
        }
    }


   

}




 
