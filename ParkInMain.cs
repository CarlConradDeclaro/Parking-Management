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
using System.Collections;



namespace Parking
{

    public class UserDetails
    {

        private string name;

        private static UserDetails instance;
        public static List<User> Usersdata = new List<User>();
        public static UserDetails Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserDetails();
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public UserDetails() 
        {
          /*  Usersdata.Add(new User("John", "Doe", 12345670, "Male", "john@example.com", "password"));
            Usersdata.Add(new User("Jane", "Doe", 98765210, "Female", "jane@example.com", "password"));*/
        }

        public void addUser(User user)
        {
            Usersdata.Add(user);
        }

        public string getName()
        {

            if (Usersdata.Count > 0)
            {
                return Usersdata[0].FirstName + ", " + Usersdata[0].LastName;
            }
            return null;
        }

        public int getId()
        {
            int x = 0;
            if (Usersdata.Count > 0)
            {
                x =  Usersdata[0].Id;
            }
            return x;
        }


        public void clearUser()
        {
            Usersdata.Clear();

        }
    }


    public class User {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pnumber { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User() { }

        public User(string firstName, string lastName, string pnumber, string gender, string email, string password)
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
        public string getPnumber() { return Pnumber; }
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
        public int adminId { get; set; }


        public ParkingRecord()
        {
          
        }
      
        public ParkingRecord(int Id,string plateNumber, string type, string model,
                             string driver, string phone, string arrivalDate,
                             string arrivalTime, string status,string s_location,int adminid)
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
            adminId = adminid;
         
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
                     Vehicle (v_plate, v_type, model, driver, phone, arrivalDate, arrivalTime, status,s_sloc,admin) 
                     VALUES (@v_plate, @v_type, @model, @driver, @phone, @arrivalDate, @arrivalTime, @status,@s_sloc,@admin)";


           
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
                    command.Parameters.AddWithValue("@admin", parkingRecord.adminId);


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
                string query = "SELECT id, v_plate, v_type, model, driver, phone, arrivalDate, arrivalTime, status,s_sloc,admin FROM Vehicle";
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
                        reader["s_sloc"].ToString(),
                        (int)reader["admin"]
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
                    command.Parameters.AddWithValue("@admin_id", UserDetails.Instance.getId());
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
         //   removeVehicle(parkinghistoryRecords.v_id);
        }

        public void removeVehicle(int id) {
             
          

           
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
              
                string query = "DELETE FROM Vehicle WHERE id = @id";

             
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                  
                    command.Parameters.AddWithValue("@id", id);

                     
                    connection.Open();

                
                    int rowsAffected = command.ExecuteNonQuery();
                      
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Vehicle deleted successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No vehicle found with the provided id.");
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
                                (double)reader["change"])
                              
                            );
                              
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
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

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
           // AddDefaultValues();
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
            string sqlQuery =
                "INSERT INTO Vehicle_Type (vType, flagdown, addAmtPerHOur) " +
                "VALUES (@vType, @flagdown, @addAmtPerHOur)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {            
                    command.Parameters.AddWithValue("@vType", vehicle.vehicleType);
                    command.Parameters.AddWithValue("@flagdown", vehicle.flagDown);
                    command.Parameters.AddWithValue("@addAmtPerHOur", vehicle.additionalAmtPerHour);
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

            //vehiclePaymentMatrix.Add(vehicle);
        }
        public List<Vehicle> GetVPM()
        {
            vehiclePaymentMatrix.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT vType, flagdown, addAmtPerHOur FROM Vehicle_Type";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        vehiclePaymentMatrix.Add(
                              new Vehicle(
                                    reader["vType"].ToString(),
                                    (int)reader["flagdown"],
                                    (int)reader["addAmtPerHOur"]));   
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);

                }
            }
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
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

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
           // AddDefaultValues();
        }
        private void AddDefaultValues()
        {
           /* vehicleBrand.Add(new VehicleBrand("MOTORBIKE", "Honda"));
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
            vehicleBrand.Add(new VehicleBrand("SEDAN", "Lexus"));*/
        }
        public void addVB(VehicleBrand vbrand)
        {
            string sqlQuery =
               "INSERT INTO Vehicle_Brand (vehicleType, vBrand) " +
               "VALUES (@vehicleType, @vBrand)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.Parameters.AddWithValue("@vehicleType", vbrand.vehicleType);
                    command.Parameters.AddWithValue("@vBrand", vbrand.vBrand);
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
          //  vehicleBrand.Add(vbrand);
        }
        public List<VehicleBrand> GetVB()
        {
            vehicleBrand.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT vehicleType,vBrand FROM Vehicle_Brand";
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        vehicleBrand.Add(
                              new VehicleBrand(
                                    reader["vehicleType"].ToString(),
                                    reader["vBrand"].ToString()));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }    
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
