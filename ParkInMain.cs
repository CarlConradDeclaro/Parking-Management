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
using System.Transactions;
using System.Globalization;



namespace Parking
{
    public static class UserStore
    {
        public static List<User> Users = new List<User>();
    }
    public class User {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Pnumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string firstName, string lastName, int pnumber, string gender, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Pnumber = pnumber;
            Gender = gender;
            Email = email;
            Password = password;
        }

        public string getFirstname() { return FirstName; }
        public string getLastname() { return LastName; }
        public int getPnumber() { return Pnumber; }
        public string getGender() { return Gender; }
        public string getEmail() { return Email; }
        public string getPassword() { return Password; }


    }

    public class ParkingRecord
    {
        // Attributes
        public int id { get; set; }
        public string PlateNumber { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Driver { get; set; }
        public string Phone { get; set; }
        public string ArrivalDate { get; set; }
        public string ArrivalTime { get; set; }
        
        public string Status { get; set; }
        public string S_location { get; set; }

       
        public ParkingRecord()
        {
          
        }
      
        public ParkingRecord(int Id,string plateNumber, string type, string model,
                             string driver, string phone, string arrivalDate,
                             string arrivalTime, string status,string s_location)
        {
            id = Id;
            PlateNumber = plateNumber;
            Type = type;
            Model = model;
             Driver = driver;
            Phone = phone;
            ArrivalDate = arrivalDate;
            ArrivalTime = arrivalTime;
         
            Status = status;
            S_location = s_location;
         
        }

      
    }
    public class ParkingHistoyRecord
    {
      
          public int v_id { get; set; }
          public int s_id { get; set; }
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
        public ParkingHistoyRecord(int v_ID,int s_ID, string plateNumber, string type, string model,
                             string driver, string phone, string arrivalDate, string arrivalTime, string departureDate, string departureTime, double hours, double amount,double change,double cash)
        {
                v_id = v_ID;
                s_id = s_ID;
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
      
        public ParkingRecordsManager()
        {
            parkingRecords = new List<ParkingRecord>();
            parkingHistoryRecords = new List<ParkingHistoyRecord>();

            AddDefaultValues();         
        }
        private void AddDefaultValues()
        {

        


        }
        public void AddParkingRecord(ParkingRecord parkingRecord)
        {
         
            string query = @"INSERT INTO 
                     Vehicle (v_plate, v_type, model, driver, phone, arrivalDate, arrivalTime, status,s_sloc) 
                     VALUES (@v_plate, @v_type, @model, @driver, @phone, @arrivalDate, @arrivalTime, @status,@s_sloc)";



           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               
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
                    command.Parameters.AddWithValue("@s_sloc", parkingRecord.S_location);

                  
                    connection.Open();

                 
                    int rowsAffected = command.ExecuteNonQuery();

                
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
            
        }       
        public void RemoveParkingRecord(ParkingRecord parkingRecord)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Vehicle WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", parkingRecord.id);  
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
            updateAvailability_query(parkingRecord.S_location);
        }


        private void updateAvailability_query(string selectedSlot)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string updateQuery = "UPDATE V_Slots SET availability = 1 WHERE s_loc = @s_loc";
                SqlCommand command = new SqlCommand(updateQuery, connection);
                try
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@s_loc", selectedSlot);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        public List<ParkingRecord> GetAllParkingRecords()
        {
            parkingRecords.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT id, v_plate, v_type, model, driver, phone, arrivalDate, arrivalTime, status,s_sloc FROM Vehicle";
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
                        (int)reader["id"],
                        reader["v_plate"].ToString(),
                        reader["v_type"].ToString(),
                        reader["model"].ToString(),
                        reader["driver"].ToString(),
                        reader["phone"].ToString(),
                        arrivalDate.ToString("MM/dd/yyyy"),
                        time.ToString("hh:mm:ss tt"),
                        reader["status"].ToString(),
                        reader["s_sloc"].ToString()
                    )
                        );

                }
                reader.Close();
            }

            return parkingRecords; 
        }
        public void AddParkingHistoryRecord(ParkingHistoyRecord parkinghistoryRecords)
        {
            string query = "insert into Transactions" +
                "(v_id, s_id,admin_id,departureDate,departureTime,hours,amount ,change,cash )" +
                " values (@v_id, @s_id,@admin_id,@departureDate,@departureTime,@hours,@amount ,@change,@cash ) ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
              
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                 
                    command.Parameters.AddWithValue("@v_id", parkinghistoryRecords.v_id);
                    command.Parameters.AddWithValue("@s_id", parkinghistoryRecords.s_id);       
                    command.Parameters.AddWithValue("@admin_id", 1010);
                    command.Parameters.AddWithValue("@departureDate", parkinghistoryRecords.DepartureDate);
                    command.Parameters.AddWithValue("@departureTime", parkinghistoryRecords.DepartureTime);
                    command.Parameters.AddWithValue("@hours", parkinghistoryRecords.Hours);
                    command.Parameters.AddWithValue("@amount", parkinghistoryRecords.Amount);
                    command.Parameters.AddWithValue("@change", parkinghistoryRecords.Changed);
                    command.Parameters.AddWithValue("@cash", parkinghistoryRecords.Cash);

        
                    connection.Open();

               
                    int rowsAffected = command.ExecuteNonQuery();

                   
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
 
         
        }
        public void RemoveParkingHistoryRecord(ParkingHistoyRecord parkinghistoryRecords)
        {
            parkingHistoryRecords.Remove(parkinghistoryRecords);
        }
        public List<ParkingHistoyRecord> GetAllParkingHistoryRecords() 
        {
            parkingHistoryRecords.Clear();
 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {         
                string query = @"SELECT t.v_id, t.s_id, t.departureDate, t.departureTime, t.hours, t.amount, t.change, t.cash,
                         v.v_plate, v.v_type, v.model, v.driver, v.phone,
                         v.arrivalDate, v.arrivalTime
                         FROM Transactions t
                         JOIN Vehicle v ON t.v_id = v.id
                         JOIN V_Slots s ON t.s_id = s.s_id";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        
                        parkingHistoryRecords.Add(
                            new ParkingHistoyRecord(
                                (int)reader["v_id"],
                                (int)reader["s_id"],
                                reader["v_plate"].ToString(), 
                                reader["v_type"].ToString(),
                                reader["model"].ToString(),
                                reader["driver"].ToString(),
                                reader["phone"].ToString(),
                                reader["arrivalDate"].ToString(), 
                                reader["arrivalTime"].ToString(), 
                                reader["departureDate"].ToString(),
                                reader["departureTime"].ToString(),
                                (double)reader["hours"],
                                (double)reader["amount"], 
                                (double)reader["cash"],
                                (double)reader["change"]));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    
                }
            }

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
