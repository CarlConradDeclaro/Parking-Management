using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class edit : Form
    {
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

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
            EditVehicle(plateNum);
            this.Close();
        }
        private void EditVehicle(String plateNumber)
        {
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
                    UpdateVehicleInDatabase(plateValue.Text, typeValue.Text, brandValue.Text, driverValue.Text, phoneValue.Text, plateNumber);
                    editHandler?.Invoke(this, EventArgs.Empty);
                    return;
                }

            }

        }
        private void UpdateVehicleInDatabase(string newPlateNo, string newTpe, string newModel, string newDriveName, string newPhoneNo, string plateNo)
        {

            string updateQuery = @"
        UPDATE Vehicle
        SET v_plate = @v_plate, 
            v_type = @v_type, 
            model = @model, 
            driver = @driver, 
            phone = @phone
        WHERE v_plate = @original_v_plate AND status = 'PARKED'";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                SqlCommand command = new SqlCommand(updateQuery, connection);


                command.Parameters.AddWithValue("@v_plate", newPlateNo);
                command.Parameters.AddWithValue("@v_type", newTpe);
                command.Parameters.AddWithValue("@model", newModel);
                command.Parameters.AddWithValue("@driver", newDriveName);
                command.Parameters.AddWithValue("@phone", newPhoneNo);
                command.Parameters.AddWithValue("@original_v_plate", plateNo);


                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
