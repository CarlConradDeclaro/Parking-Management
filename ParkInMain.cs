using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/*using System.Data.SqlClient; 
using System.Data;*/
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OracleClient;
using System.Data;


using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Parking
{
    public class ParkingRecord
    {
        // Attributes
        public string PlateNumber { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Driver { get; set; }
        public string Phone { get; set; }
        public string ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        //public String DepartureDate { get; set; }
        //public String DepartureTime { get; set; }
       // public double Hours { get; set; }
       // public double Amount { get; set; }
        public string Status { get; set; }

        // Constructor
        public ParkingRecord()
        {
            // Default constructor
        }
        // Additional constructor with parameters
        public ParkingRecord(string plateNumber, string type, string model,
                             string driver, string phone, string arrivalDate, string arrivalTime, string status)
        {
            PlateNumber = plateNumber;
            Type = type;
            Model = model;
             Driver = driver;
            Phone = phone;
            ArrivalDate = arrivalDate;
            ArrivalTime = arrivalTime;
           // Hours = hours;
          //  Amount = amount;
            Status = status;
          //  DepartureDate = departureDate;
          //  DepartureTime = departureTime;
        }

      
    }
    public class ParkingHistoyRecord
    {
        // Attributes
         public string PlateNumber { get; set; }
         public string Type { get; set; }
         public string Model { get; set; }
         public string Driver { get; set; }
         public string Phone { get; set; }
         public string ArrivalDate { get; set; }
         public string ArrivalTime { get; set; }
         public String DepartureDate { get; set; }
         public String DepartureTime { get; set; }
         public double Hours { get; set; }
         public double Amount { get; set; }
        public double Cash { get; set; }
        public double Changed { get; set; }
        public ParkingHistoyRecord()
        {
             
        }        
        public ParkingHistoyRecord(string plateNumber, string type, string model,
                             string driver, string phone, string arrivalDate, string arrivalTime, string departureDate, string departureTime, double hours, double amount,double change,double cash)
        {
            PlateNumber = plateNumber;
            Type = type;
            Model = model;
            Driver = driver;
            Phone = phone;
            ArrivalDate = arrivalDate;
            ArrivalTime = arrivalTime;
            Hours = hours;
            Amount = amount;
            
            DepartureDate = departureDate;
            DepartureTime = departureTime;
            DepartureDate = departureDate;
            DepartureTime = departureTime;
            Hours = hours;
            Amount = amount;
            Cash = cash;
            Changed = change;
        }     
    }
    public class ParkingRecordsManager
    {
        private List<ParkingRecord> parkingRecords;
        private List<ParkingHistoyRecord> parkingHistoryRecords;
        private static ParkingRecordsManager instance;

        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";


        public static ParkingRecordsManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new ParkingRecordsManager();
                return instance;
            }
        }
        // Constructor
        public ParkingRecordsManager()
        {
            parkingRecords = new List<ParkingRecord>();
            parkingHistoryRecords = new List<ParkingHistoyRecord>();

            AddDefaultValues();         
        }
        private void AddDefaultValues()
        {

         /*      parkingRecords.Add(new ParkingRecord("423432", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("2124332", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("435345", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("354f45", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("534234dfg", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("34534df", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("354g456", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("234756gh", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("5642fgd", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("867ghj45", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("345fg56", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("456fg34", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("34gh67", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("3456f", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("456t56", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
               parkingRecords.Add(new ParkingRecord("564hg56", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
           */
         /*     parkingHistoryRecords.Add(new ParkingHistoyRecord("9807", "SUV", "ford", "carl conrad", "123456789", "3/9/2024", "8:54:12 PM", "3/9/2024", "10:54:12 PM", 0, 0));
             parkingHistoryRecords.Add(new ParkingHistoyRecord("9807", "SUV", "ford", "carl conrad", "123456789", "3/9/2024", "8:54:12 PM", "3/9/2024", "10:54:12 PM", 0, 0));
             parkingHistoryRecords.Add(new ParkingHistoyRecord("9807", "SUV", "ford", "carl conrad", "123456789", "3/9/2024", "8:54:12 PM", "3/9/2024", "10:54:12 PM", 0, 0));
             parkingHistoryRecords.Add(new ParkingHistoyRecord("9807", "SUV", "ford", "carl conrad", "123456789", "3/9/2024", "8:54:12 PM", "3/9/2024", "10:54:12 PM", 0, 0));
             parkingHistoryRecords.Add(new ParkingHistoyRecord("9807", "SUV", "ford", "carl conrad", "123456789", "3/9/2024", "8:54:12 PM", "3/9/2024", "10:54:12 PM", 0, 0));
             parkingHistoryRecords.Add(new ParkingHistoyRecord("9807", "SUV", "ford", "carl conrad", "123456789", "3/9/2024", "8:54:12 PM", "3/9/2024", "10:54:12 PM", 0, 0));
             parkingHistoryRecords.Add(new ParkingHistoyRecord("9807", "SUV", "ford", "carl conrad", "123456789", "3/9/2024", "8:54:12 PM", "3/9/2024", "10:54:12 PM", 0, 0));
             parkingHistoryRecords.Add(new ParkingHistoyRecord("9807", "SUV", "ford", "carl conrad", "123456789", "3/9/2024", "8:54:12 PM", "3/9/2024", "10:54:12 PM", 0, 0));
             parkingHistoryRecords.Add(new ParkingHistoyRecord("9807", "SUV", "ford", "carl conrad", "123456789", "3/9/2024", "8:54:12 PM", "3/9/2024", "10:54:12 PM", 0, 0));
             parkingHistoryRecords.Add(new ParkingHistoyRecord("9807", "SUV", "ford", "carl conrad", "123456789", "3/9/2024", "8:54:12 PM", "3/9/2024", "10:54:12 PM", 0, 0));
             parkingHistoryRecords.Add(new ParkingHistoyRecord("9807", "SUV", "ford", "carl conrad", "123456789", "3/9/2024", "8:54:12 PM", "3/9/2024", "10:54:12 PM", 0, 0));
        */
           
            
            // Connect to the database and retrieve parking records
 
           /* using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT v_plate, v_type FROM Vehicle"; 
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    
             
                    parkingRecords.Add(
                       new ParkingRecord(
                        reader["v_plate"].ToString(),
                        reader["v_type"].ToString(),
                        "ford", // Empty string for model
                        "John Doe", // Empty string for driver
                        "123456789", // Empty string for phone
                        "03/12/2024", // Empty string for arrivalDate
                        "06:00:00 AM", // Empty string for arrivalTime
                        "PARKED"  // Empty string for status
                    )
                        );
 
                }

                reader.Close();
            } */



        }
        public void AddParkingRecord(ParkingRecord parkingRecord)
        {
            // SQL query to insert a new record into the ParkingRecords table
            string query = @"INSERT INTO 
                     Vehicle (v_plate, v_type, model, driver, phone, arrivalDate, arrivalTime, status) 
                     VALUES (@v_plate, @v_type, @model, @driver, @phone, @arrivalDate, @arrivalTime, @status)";

            // Create a new SQL connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a new SQL command with the query and connection
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@v_plate", parkingRecord.PlateNumber);
                    command.Parameters.AddWithValue("@v_type", parkingRecord.Type);
                    command.Parameters.AddWithValue("@model", parkingRecord.Model);
                    command.Parameters.AddWithValue("@driver", string.IsNullOrEmpty(parkingRecord.Driver) ? (object)DBNull.Value : parkingRecord.Driver);
                    command.Parameters.AddWithValue("@phone", string.IsNullOrEmpty(parkingRecord.Phone) ? (object)DBNull.Value : parkingRecord.Phone);
                    command.Parameters.AddWithValue("@arrivalDate", parkingRecord.ArrivalDate);
                    command.Parameters.AddWithValue("@arrivalTime", parkingRecord.ArrivalTime);
                    command.Parameters.AddWithValue("@status", parkingRecord.Status);

                    // Open the connection
                    connection.Open();

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Parking record inserted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed to insert parking record.");
                    }
                }
            }
            //parkingRecords.Add(parkingRecord);
        }       
        public void RemoveParkingRecord(ParkingRecord parkingRecord)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Vehicle WHERE v_plate = @v_plate";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@v_plate", parkingRecord.PlateNumber); // Assuming Id is the property of ParkingRecord that corresponds to the id in the database

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Record successfully deleted.");
                            parkingRecords.Remove(parkingRecord);
                        }
                        else
                        {
                            Console.WriteLine("No record found with the specified id.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            //parkingRecords.Remove(parkingRecord);
        }
        public List<ParkingRecord> GetAllParkingRecords()
        {
            parkingRecords.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT v_plate, v_type, model, driver, phone, arrivalDate, arrivalTime, status FROM Vehicle";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DateTime arrivalDate = (DateTime)reader["arrivalDate"];
                    TimeSpan arrivalTime = (TimeSpan)reader["arrivalTime"];
                    DateTime time = DateTime.Today.Add(arrivalTime);
                    parkingRecords.Add(
                       new ParkingRecord(
                        reader["v_plate"].ToString(),
                        reader["v_type"].ToString(),
                        reader["model"].ToString(),
                        reader["driver"].ToString(),
                        reader["phone"].ToString(),
                        arrivalDate.ToString("MM/dd/yyyy"),
                        time.ToString("hh:mm:ss tt"),
                        reader["status"].ToString()
                    )
                        );

                }
                reader.Close();
            }

            return parkingRecords; 
        }
        public void AddParkingHistoryRecord(ParkingHistoyRecord parkinghistoryRecords)
        {
            parkingHistoryRecords.Add(parkinghistoryRecords);
        }
        public void RemoveParkingHistoryRecord(ParkingHistoyRecord parkinghistoryRecords)
        {
            parkingHistoryRecords.Remove(parkinghistoryRecords);
        }
        public List<ParkingHistoyRecord> GetAllParkingHistoryRecords() 
        {
            return parkingHistoryRecords;
        }


    }



    public class Vehicle {
        public string vehicleType { get; set; }   
        public double flagDown { get; set; }
        public double additionalAmtPerHour { get; set; }
       public Vehicle(string vType,double flagdown,double addAmtPerHOur)
        {
            vehicleType = vType;
            flagDown = flagdown;
            additionalAmtPerHour = addAmtPerHOur;
        }
    }

    public class VehicleManger {
        private List<Vehicle> vehiclePaymentMatrix;
        private static VehicleManger instance;
        public static VehicleManger Instance
        {
            get
            {
                if (instance == null)
                    instance = new VehicleManger();
                return instance;
            }
        }
        public VehicleManger()
        {
            vehiclePaymentMatrix = new List<Vehicle>();
            AddDefaultValues();
        }

       


        private void AddDefaultValues()
        {
            vehiclePaymentMatrix.Add(new Vehicle("MOTORBIKE", 20,5));
            vehiclePaymentMatrix.Add(new Vehicle("SUV",40,20));
            vehiclePaymentMatrix.Add(new Vehicle("VAN", 40, 20));
            vehiclePaymentMatrix.Add(new Vehicle("SEDAN", 30, 15));
        }
        public void addVPM(Vehicle vehicle)
        {
            vehiclePaymentMatrix.Add(vehicle);
        }
        public List<Vehicle> GetVPM()
        {
            return vehiclePaymentMatrix;
        }
    }

    public class VehicleBrand
    {
        public string vehicleType { get; set; }
        public string vBrand { get; set; }
        public VehicleBrand(string vType, string vehicleName)
        {
            vehicleType = vType;
            vBrand = vehicleName;        
        }
    }
    public class VehicleBrandMAnger
    {
        private List<VehicleBrand> vehicleBrand;
        private static VehicleBrandMAnger instance;
        public static VehicleBrandMAnger Instance
        {
            get
            {
                if (instance == null)
                    instance = new VehicleBrandMAnger();
                return instance;
            }
        }
        public VehicleBrandMAnger()
        {
            vehicleBrand = new List<VehicleBrand>();
            AddDefaultValues();
        }
        private void AddDefaultValues()
        {
            vehicleBrand.Add(new VehicleBrand("MOTORBIKE", "Honda"));
            vehicleBrand.Add(new VehicleBrand("MOTORBIKE", "Yamaha"));
            vehicleBrand.Add(new VehicleBrand("MOTORBIKE", "Suzuki"));
            vehicleBrand.Add(new VehicleBrand("MOTORBIKE", "Kawasaki"));
            vehicleBrand.Add(new VehicleBrand("SUV", "Toyota"));
            vehicleBrand.Add(new VehicleBrand("SUV", "Honda"));
            vehicleBrand.Add(new VehicleBrand("SUV", "Ford"));
            vehicleBrand.Add(new VehicleBrand("SUV", "Chevrolet"));
            vehicleBrand.Add(new VehicleBrand("VAN", "Ford"));
            vehicleBrand.Add(new VehicleBrand("VAN", "Chevrolet"));
            vehicleBrand.Add(new VehicleBrand("VAN", "Mercedes-Benz"));
            vehicleBrand.Add(new VehicleBrand("VAN", "Volkswagen"));
            vehicleBrand.Add(new VehicleBrand("SEDAN", "BMW"));
            vehicleBrand.Add(new VehicleBrand("SEDAN", "Mercedes-Benz"));
            vehicleBrand.Add(new VehicleBrand("SEDAN", "Audi"));
            vehicleBrand.Add(new VehicleBrand("SEDAN", "Lexus"));
        }
        public void addVB(VehicleBrand vbrand)
        {
            vehicleBrand.Add(vbrand);
        }
        public List<VehicleBrand> GetVB()
        {
            return vehicleBrand;
        }
        public void RemoveParkingHistoryRecord(VehicleBrand parkinghistoryRecords)
        {
            vehicleBrand.Remove(parkinghistoryRecords);
        }
    }
    internal class ParkInMain
    {
    }
}
