using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class HistoryList : UserControl
    {

        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

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
            Label8.Text = getLocation(parkHistoryRecord.s_id);
            Label9.Text = parkHistoryRecord.Amount + "";
        }

        private string getLocation(int s_id)
        {
            string sloc = "";
            string sql = "SELECT s_loc FROM V_Slots WHERE s_id = @s_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@s_id", s_id);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            sloc = reader["s_loc"].ToString();
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        MessageBox.Show("An error occurred while retrieving the location.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return sloc;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UpdateLabels
            view v = new view();
            v.UpdateLabels(parkinghistoyRecord);
            v.Show();
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }
    }
}
