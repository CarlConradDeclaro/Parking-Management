using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class edit : Form
    {
        String connectionString = ConnectionString.Instance.connectionString();
        string vType = "";
        string vBrand = "";
        private string plateNum;
        public event EventHandler editHandler;

        public edit(ParkingRecord record)
        {
            InitializeComponent();
            plateValue.Text = record.PlateNumber;
            vType = record.Type;
            vBrand = record.Model;
            driverValue.Text = record.Driver;
            phoneValue.Text = record.Phone;
            plateNum = record.PlateNumber;
        }
        public edit() { }

        private void edit_Load(object sender, EventArgs e)
        {
            
            var vehiclemanger = VehicleManger.Instance;
            var VPM = vehiclemanger.GetVPM();
            foreach (var record in VPM)
            {
                typeValue.Items.Add(record.vehicleType);
            }

            editHandler?.Invoke(this, EventArgs.Empty);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            int proceedAddItem = 0;

            if (!string.IsNullOrWhiteSpace(plateValue.Text) && plateValue.Text.All(char.IsLetterOrDigit))
            {
                proceedAddItem++;
            }
            else
            {
                errorPlateNum.Text = "Please enter a valid plate number.";
            }


            if (typeValue.SelectedItem?.ToString() != null )
            {
                proceedAddItem++;
            }
            else
            {
                errorType.Text = "Please select a type.";
            }


            if (brandValue.SelectedItem?.ToString() != null)
            {
                proceedAddItem++;
            }
            else
            {
                errorBrand.Text = "Please select a model.";
            }

            if (string.IsNullOrWhiteSpace(driverValue.Text) || !double.TryParse(driverValue.Text, out _))
            {
                proceedAddItem++;
            }
            else
            {
                erroDriveName.Text = "Invalid name. Name should not be numeric.";
            }


            if (string.IsNullOrWhiteSpace(phoneValue.Text) || double.TryParse(phoneValue.Text, out _))
            {
                proceedAddItem++;
            }
            else
            {
                erroPhoneNum.Text = "Please enter a valid numeric phone number.";
            }



            if (proceedAddItem == 5) {
                EditVehicle(plateNum);
                this.Close();
            }
               
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
                command.Parameters.AddWithValue("@v_type", typeValue.SelectedItem?.ToString() == null ? vType : typeValue.SelectedItem?.ToString());
                command.Parameters.AddWithValue("@model", brandValue.SelectedItem?.ToString() == null ? vBrand : brandValue.SelectedItem?.ToString());
                command.Parameters.AddWithValue("@driver", newDriveName);
                command.Parameters.AddWithValue("@phone", newPhoneNo);
                command.Parameters.AddWithValue("@original_v_plate", plateNo);
                editHandler?.Invoke(this, EventArgs.Empty);

                connection.Open();
                command.ExecuteNonQuery();

                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            editHandler?.Invoke(this, EventArgs.Empty);
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void typeValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            brandValue.Items.Clear();
            string selectedItem = typeValue.SelectedItem?.ToString();
            var vehicleBrand = VehicleBrandMAnger.Instance;
            var VB = vehicleBrand.GetVB();
            foreach (var record in VB)
            {
                if (record.vehicleType == selectedItem)
                    brandValue.Items.Add(record.vBrand);
            }

        }
    }
}
