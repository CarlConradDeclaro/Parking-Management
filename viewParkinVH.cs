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
    public partial class viewParkinVH : Form
    {
        public viewParkinVH()
        {
            InitializeComponent();
        }

        private void viewParkinVH_Load(object sender, EventArgs e)
        {

        }
        public void UpdateLabels(ParkingRecord parkingRecords)
        {
            setPlateNUm.Text = parkingRecords.PlateNumber;
            settype.Text = parkingRecords.Type;
            setBrand.Text = parkingRecords.Model;
            setArrivalDT.Text = parkingRecords.ArrivalDate + " " + parkingRecords.ArrivalTime;


            if (parkingRecords.Driver != null)
            {
                setDriver.Text = parkingRecords.Driver;
            }
            else
                setDriver.Text = "N/A";

            if (parkingRecords.Phone != null)
            {
                setPhone.Text = parkingRecords.Phone;
            }
            else
                setPhone.Text = "N/A";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
