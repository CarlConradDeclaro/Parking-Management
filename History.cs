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
    public partial class History : UserControl
    {

        private static History instance;
        public static History Instance
        {
            get
            {
                if (instance == null)
                    instance = new History();
                return instance;
            }
        }




        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            flowPanelHistory.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingHistoryRecords = parkingRecordsManager.GetAllParkingHistoryRecords(); // Add a semicolon here

            foreach (var record in allParkingHistoryRecords)
            {
                HistoryList pL = new HistoryList();
                pL.UpdateLabels(record);
                flowPanelHistory.Controls.Add(pL);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowPanelHistory.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingHistoryRecords = parkingRecordsManager.GetAllParkingHistoryRecords(); // Add a semicolon here

            foreach (var record in allParkingHistoryRecords)
            {
                HistoryList pL = new HistoryList();
                pL.UpdateLabels(record);
                flowPanelHistory.Controls.Add(pL);
            }
        }


        public void display() {

            flowPanelHistory.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingHistoryRecords = parkingRecordsManager.GetAllParkingHistoryRecords(); // Add a semicolon here

            foreach (var record in allParkingHistoryRecords)
            {
                HistoryList pL = new HistoryList();
                pL.UpdateLabels(record);
                flowPanelHistory.Controls.Add(pL);
            }


        }
    }
}
