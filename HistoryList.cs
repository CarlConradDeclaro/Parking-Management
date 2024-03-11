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
    public partial class HistoryList : UserControl
    {
        public HistoryList()
        {
            InitializeComponent();
        }

        private void HistoryList_Load(object sender, EventArgs e)
        {

        }

        public void UpdateLabels(ParkingHistoyRecord parkHistoryRecord)
        {
            Label1.Text = parkHistoryRecord.PlateNumber;
            Label2.Text = parkHistoryRecord.Type;
            Label3.Text = parkHistoryRecord.Model;
            Label4.Text = parkHistoryRecord.ArrivalDate;
            Label5.Text = parkHistoryRecord.ArrivalTime;
            Label6.Text = parkHistoryRecord.DepartureDate;
            Label7.Text = parkHistoryRecord.DepartureTime;
            Label8.Text = parkHistoryRecord.Hours+"";
            Label9.Text = parkHistoryRecord.Amount+"";     
        }

    }
}
