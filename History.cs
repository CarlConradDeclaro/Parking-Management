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
        public event EventHandler deleteHistoryV;
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
            DisplayTransactions();
        }
        private void DisplayTransactions() {
            flowPanelHistory.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingHistoryRecords = parkingRecordsManager.GetAllParkingHistoryRecords();

            for (int i = allParkingHistoryRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingHistoryRecords[i];
                HistoryList pL = new HistoryList();
                pL.UpdateLabels(record);
                flowPanelHistory.Controls.Add(pL);

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DisplayTransactions();
        }
        public void display()
        {
            DisplayTransactions();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayTransactions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            flowPanelHistory.Controls.Clear();
            var parkingRecordsManager = ParkingRecordsManager.Instance;
            var allParkingHistoryRecords = parkingRecordsManager.GetAllParkingHistoryRecords();
            bool foundRecord = false;
            for (int i = allParkingHistoryRecords.Count - 1; i >= 0; i--)
            {
                var record = allParkingHistoryRecords[i];
                if (searchVH.Text == record.PlateNumber) {
                    HistoryList pL = new HistoryList();
                    pL.deleteHistoryHandler += DeLeteHandler;
                    pL.UpdateLabels(record);
                    flowPanelHistory.Controls.Add(pL);
                    foundRecord = true;
                }            
            }
            if (!foundRecord)
            {
                Label noResultsLabel = new Label();
                noResultsLabel.Text = "No results found.";
                noResultsLabel.ForeColor = Color.White;
                flowPanelHistory.Controls.Add(noResultsLabel);
            }
        }


        private void DeLeteHandler(object sender, EventArgs e)
        {
            deleteHistoryV?.Invoke(this, EventArgs.Empty);
           
        }
    }
}
