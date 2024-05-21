using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class view : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

        public view()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void UpdateLabels(ParkingHistoyRecord parkingHistoy)
        {
            setPlateNUm.Text = parkingHistoy.PlateNumber;
            settype.Text = parkingHistoy.Type;
            setBrand.Text = parkingHistoy.Model;
            setArrivalDT.Text = parkingHistoy.ArrivalDate + " " + parkingHistoy.ArrivalTime;
            setParkoutDT.Text = parkingHistoy.DepartureDate + " " + parkingHistoy.DepartureTime;
            setAmt.Text = parkingHistoy.Amount + "";
            setHours.Text = parkingHistoy.Hours + "";
            setChanged.Text = parkingHistoy.Changed + "";
            setCash.Text = parkingHistoy.Cash + "";
            adminId.Text = getAdminId(parkingHistoy.v_id,connectionString) + "";

            if (parkingHistoy.Driver != null)
            {
                setDriver.Text = parkingHistoy.Driver;

            }
            if(parkingHistoy.Driver == "")
                setDriver.Text = "N/A";

            if (parkingHistoy.Phone != null)
            {
                setPhone.Text = parkingHistoy.Phone;
            }
            if (parkingHistoy.Phone == "")
                setPhone.Text = "N/A";

        }

        private int getAdminId(int v_id, string connectionString)
        {
            string query = "SELECT admin_id FROM Transactions WHERE v_id = @v_id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@v_id", v_id);

                    object result = command.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int adminId))
                    {
                        return adminId;
                    }
                    else
                    {
                         
                        return -1; 
                    }
                }
            }
          
        }

        private void view_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
