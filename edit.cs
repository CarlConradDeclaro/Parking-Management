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
    public partial class edit : Form
    {

        private string plateNum;


        public event EventHandler editHandler;



        public edit(ParkingRecord record)
        {
            InitializeComponent();
           
            plateValue.Text = record.PlateNumber;
            typeValue.Text = record.Type;
            brandValue.Text = record.Model;
            driverValue.Text = record.Driver;
            phoneValue.Text = record.Phone;
            plateNum = record.PlateNumber;
           
        }
        public edit() { }

        private void edit_Load(object sender, EventArgs e)
        {

        }
  


        

        private void button2_Click(object sender, EventArgs e)
        {
            // how can i use the display() from parkin it should refresh the flowpane freom parkin
            
            EditVehicle(plateNum);
        
            this.Close();

        }

    

        private void EditVehicle(String plateNumber) {
            // edit vehicle details
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingRecords = parkingRecordsManager.GetAllParkingRecords();
            for (int i = allParkingRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingRecords[i];
                if (record.PlateNumber == plateNumber)
                {
                    record.PlateNumber = plateValue.Text;               
                    record.Type = typeValue.Text;
                    record.Model = brandValue.Text;
                    record.Driver = driverValue.Text;
                    record.Phone = phoneValue.Text;




                     editHandler?.Invoke(this, EventArgs.Empty);


                    return;

                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
