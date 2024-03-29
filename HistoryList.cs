﻿using System;
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
    public partial class HistoryList : UserControl
    {

        public event EventHandler deleteHistoryHandler;
        private ParkingHistoyRecord parkinghistoyRecord;
        public HistoryList()
        {
            InitializeComponent();
        }

        private void HistoryList_Load(object sender, EventArgs e)
        {

        }

        public void UpdateLabels(ParkingHistoyRecord parkHistoryRecord)
        {
            parkinghistoyRecord = parkHistoryRecord;
            Label1.Text = parkHistoryRecord.PlateNumber;
            Label2.Text = parkHistoryRecord.Type;
            Label3.Text = parkHistoryRecord.Model;
            Label4.Text = parkHistoryRecord.ArrivalDate;
            Label5.Text = parkHistoryRecord.ArrivalTime;
            Label6.Text = parkHistoryRecord.DepartureDate;
            Label7.Text = parkHistoryRecord.DepartureTime;
            Label8.Text = parkHistoryRecord.Hours + "";
            Label9.Text = parkHistoryRecord.Amount + "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var parkingRecordsManager = ParkingRecordsManager.Instance;
                var allParkingRecords = parkingRecordsManager.GetAllParkingHistoryRecords();

                foreach (var record in allParkingRecords)
                {
                    if (record.PlateNumber == Label1.Text)
                    {
                        parkingRecordsManager.RemoveParkingHistoryRecord(record);
                        MessageBox.Show("The vehicle with plate number " + Label1.Text + " has been successfully removed.", "Vehicle Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Parent.Controls.Remove(this);
                        deleteHistoryHandler?.Invoke(this, EventArgs.Empty);
                        break;
                    }
                }

            }


            /*
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
             
             
             
             
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UpdateLabels
            view v = new view();
            v.UpdateLabels(parkinghistoyRecord);
            v.Show();
        }
    }
}
