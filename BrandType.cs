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
    public partial class BrandType : UserControl
    {
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

        FlowLayoutPanel flowPanelbrands;
        public event EventHandler brandDeleteHandler;
        string getvType;
        public BrandType()
        {
            InitializeComponent();
        }

        private void BrandType_Load(object sender, EventArgs e)
        {

        }

        public void UpdateLabels(VehicleBrand vbrand)
        {
            brandName.Text = vbrand.vBrand;
        }

        public void getVType(string getvtype, FlowLayoutPanel flowLayoutPanel)
        {
            getvType = getvtype;
            flowPanelbrands = flowLayoutPanel;
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            string brandToDelete = brandName.Text;

            // Construct the SQL DELETE query
            string sql = "DELETE FROM Vehicle_Brand WHERE vBrand = @BrandToDelete";
        
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@BrandToDelete", brandToDelete);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Trigger event or perform any other necessary actions
                            brandDeleteHandler?.Invoke(this, EventArgs.Empty);

                        }
                        else
                        {
                            MessageBox.Show("Brand name not found for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        MessageBox.Show("An error occurred while deleting the brand.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
       
    }
}
