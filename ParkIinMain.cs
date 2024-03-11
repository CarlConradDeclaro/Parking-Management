using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
       

       
        public ParkingHistoyRecord()
        {
             
        }

         
        public ParkingHistoyRecord(string plateNumber, string type, string model,
                             string driver, string phone, string arrivalDate, string arrivalTime, string departureDate, string departureTime, double hours, double amount)
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
        }

       
    }

    public class ParkingRecordsManager
    {

        private List<ParkingRecord> parkingRecords;
        private List<ParkingHistoyRecord> parkingHistoryRecords;


        private static ParkingRecordsManager instance;
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
         
            parkingRecords.Add(new ParkingRecord("423432", "SUV", "ford", "John Doe", "123456789", "03/12/2024", "06:00:00 AM", "PARKED"));
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






            /* parkingHistoryRecords.Add(new ParkingHistoyRecord("9807", "SUV", "ford", "carl conrad", "123456789", "3/9/2024", "8:54:12 PM", "3/9/2024", "10:54:12 PM", 0, 0));
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
        }

        // Method to add a parking record
        public void AddParkingRecord(ParkingRecord parkingRecord)
        {
            parkingRecords.Add(parkingRecord);
        }       
        // Method to remove a parking record
        public void RemoveParkingRecord(ParkingRecord parkingRecord)
        {
            parkingRecords.Remove(parkingRecord);
        }
        // Method to get all parking records
        public List<ParkingRecord> GetAllParkingRecords()
        {
          return parkingRecords; 
        }



        // Method to add a parking history record
        public void AddParkingHistoryRecord(ParkingHistoyRecord parkinghistoryRecords)
        {
            parkingHistoryRecords.Add(parkinghistoryRecords);
        }
        // Method to remove a parking history record
        public void RemoveParkingHistoryRecord(ParkingHistoyRecord parkinghistoryRecords)
        {
            parkingHistoryRecords.Remove(parkinghistoryRecords);
        }
        // Method to get all parking history record
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











    internal class ParkIinMain
    {
    }
}
