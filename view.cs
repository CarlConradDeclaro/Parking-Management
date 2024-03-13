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
    public partial class view : Form
    {
        public view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateLabels(ParkingHistoyRecord parkingHistoy)
        {
            setPlateNUm.Text = parkingHistoy.PlateNumber;
            settype.Text = parkingHistoy.Type;
            setBrand.Text = parkingHistoy.Model;
            setArrivalDT.Text = parkingHistoy.ArrivalDate + " " + parkingHistoy.ArrivalTime;
            setParkoutDT.Text = parkingHistoy.DepartureDate + " " + parkingHistoy.DepartureTime;
            setAmt.Text = parkingHistoy.Amount + "";
            setHours.Text = parkingHistoy.Hours+"";
            setChanged.Text = parkingHistoy.Changed+"";
            setCash.Text = parkingHistoy.Cash+"";

            if (parkingHistoy.Driver != null)
            {
                setDriver.Text = parkingHistoy.Driver;

            }
            else
                setDriver.Text = "N/A";

            if (parkingHistoy.Phone != null)
            {
                setPhone.Text = parkingHistoy.Phone;
            }
            else
                setPhone.Text = "N/A";

        }

        private void view_Load(object sender, EventArgs e)
        {

        }
    }
}
