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
    public partial class admin : UserControl
    {
        String connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\carlconrad\source\Parking-Management-System\DB\VehicleDB.mdf;Integrated Security=True";

        private static admin instance;
        public static admin Instance
        {
            get
            {
                if (instance == null)
                    instance = new admin();
                return instance;
            }
        }


        public admin()
        {
            InitializeComponent();
            display();
            selectTypeCB();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {


            flowLayoutBrands.Controls.Clear();
            string selecteditemType = this.selectedItemType.SelectedItem?.ToString();
            var vehicleBrand = VehicleBrandMAnger.Instance;
            var VB = vehicleBrand.GetVB();


            foreach (var record in VB)
            {
                if (selecteditemType == record.vehicleType)
                {
                    BrandType bt = new BrandType();
                    bt.brandDeleteHandler += displayBrands;
                    bt.UpdateLabels(record);
                    flowLayoutBrands.Controls.Add(bt);

                    BrandType pT = new BrandType();
                    pT.getVType(selecteditemType, flowLayoutBrands);
                }

            }

            var vehiclemanger = VehicleManger.Instance;
            var VPM = vehiclemanger.GetVPM();
            foreach (var record in VPM)
            {
                if (record.vehicleType == selecteditemType)
                {
                    typeName.Text = record.vehicleType;
                    flagDown.Value = (int)record.flagDown;
                    AAPH.Value = (int)record.additionalAmtPerHour; ;
                }
            }

            selectTypeCB();
        }

        private void selectedItemType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            editType(1);
            selectTypeCB();
        }



        public void editType(int attributes)
        {
            string selecteditemType = this.selectedItemType.SelectedItem?.ToString();

            var vehiclemanger = VehicleManger.Instance;
            var VPM = vehiclemanger.GetVPM();
            foreach (var record in VPM)
            {
                if (record.vehicleType == selecteditemType)
                {
                    if (attributes == 1)
                    {
                        editTypeName(typeName.Text, selecteditemType);
                    }
                    else if (attributes == 2)
                    {
                        editFlagdown((double)flagDown.Value, selecteditemType);
                    }
                    else if (attributes == 3)
                    {
                        editFAmtPerHour((double)AAPH.Value, selecteditemType);
                    }


                    var vehicleBrand = VehicleBrandMAnger.Instance;
                    var VB = vehicleBrand.GetVB();

                    foreach (var vbRecords in VB)
                    {
                        if (selecteditemType == vbRecords.vehicleType)
                        {
                            vbRecords.vehicleType = typeName.Text;
                        }

                    }
                }
            }
        }


        private void editTypeName(string changes, string selectedItemType)
        {



            string sql = "UPDATE Vehicle_Type SET vType = @changes WHERE vType = @SelectedItemType";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@changes", changes);
                    command.Parameters.AddWithValue("@SelectedItemType", selectedItemType);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfuly changed Type", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Type name not found for update.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }


        }
        private void editFlagdown(double changes, string selectedItemType)
        {
            string sql = "UPDATE Vehicle_Type SET flagdown = @changes WHERE vType = @SelectedItemType";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@changes", changes);
                    command.Parameters.AddWithValue("@SelectedItemType", selectedItemType);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfuly changed flagdown", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("flagdown not found for update.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        private void editFAmtPerHour(double changes, string selectedItemType)
        {
            string sql = "UPDATE Vehicle_Type SET addAmtPerHOur = @changes WHERE vType = @SelectedItemType";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@changes", changes);
                    command.Parameters.AddWithValue("@SelectedItemType", selectedItemType);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Successfuly changed AmtPerHour", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("AmtPerHour not found for update.", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            display();
        }

        public void display()
        {
            selectedItemType.Items.Clear();
            flowLayoutBrands.Controls.Clear();
            var vehiclemanger = VehicleManger.Instance;
            var VPM = vehiclemanger.GetVPM();
            foreach (var record in VPM)
            {
                selectedItemType.Items.Add(record.vehicleType);
            }

            selectedItemType.Text = "";

            typeName.Text = "";
            flagDown.Value = 0;
            AAPH.Value = 0;

        }

        public void displayBrands(object sender, EventArgs e)
        {
            flowLayoutBrands.Controls.Clear();
            var vehicleBrand = VehicleBrandMAnger.Instance;

            var VB = vehicleBrand.GetVB();

            string selecteditemType = selectedItemType.SelectedItem?.ToString();

            foreach (var record in VB)
            {
                if (record.vehicleType == selecteditemType)
                {
                    BrandType bt = new BrandType();
                    bt.brandDeleteHandler += displayBrands;
                    bt.UpdateLabels(record);
                    flowLayoutBrands.Controls.Add(bt);
                }

            }
        }

    


        private void button5_Click(object sender, EventArgs e)
        {
            editType(2);
            selectTypeCB();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            editType(3);
            selectTypeCB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vehiclemanager = VehicleManger.Instance;

            if (setTypeName.Text != "")
            {
                if (!isTypeInTheList(setTypeName.Text))
                {
                    vehiclemanager.addVPM(new Vehicle(setTypeName.Text, (double)setFlagDown.Value, (double)setAAPH.Value));
                    selectTypeCB();
                    display();
                    setTypeName.Text = "";
                    setAAPH.Value = 0;
                    setFlagDown.Value = 0;
                    MessageBox.Show("Successfuly Added Type", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Opps, The " + setTypeName.Text + " is already in the list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please input value", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool isTypeInTheList(string vtype)
        {
            bool isIntheList = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Vehicle_Type WHERE vType = @vType";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@vType", vtype);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        isIntheList = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return isIntheList;
        }


        public void selectTypeCB()
        {

            selectType.Items.Clear();
            var vehiclemanger = VehicleManger.Instance;
            var VPM = vehiclemanger.GetVPM();
            foreach (var record in VPM)
            {
                selectType.Items.Add(record.vehicleType);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selecttype = selectType.SelectedItem?.ToString();
            var vehicleBrand = VehicleBrandMAnger.Instance;
            if (setBrandName.Text != "")
            {
                if (!isBrandInTheList(setBrandName.Text))
                {
                    vehicleBrand.addVB(new VehicleBrand(selecttype, setBrandName.Text));
                    MessageBox.Show("Successfuly Added brand", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setBrandName.Text = "";
                    selectType.Text = "";
                }
                else
                    MessageBox.Show("Opps, The " + setBrandName.Text + " is already in the list!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Please input value", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool isBrandInTheList(string vBrand)
        {
            bool isIntheList = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Vehicle_Brand WHERE vBrand = @vBrand";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@vBrand", vBrand);
                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        isIntheList = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return isIntheList;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            selectTypeCB();

            setTypeName.Text = "";
            setBrandName.Text = "";
            setFlagDown.Value = 0;
            setAAPH.Value = 0;
            setBrandName.Text = "";
            selectType.Text = "";
        }

        private void flowLayoutBrands_Paint(object sender, PaintEventArgs e)
        {

        }

        /* private void button9_Click(object sender, EventArgs e)
         {
             //flowLayoutBrands


             flowLayoutBrands.Controls.Clear();
             string selecteditemType = this.selectedItemType.SelectedItem?.ToString();
             var vehicleBrand = VehicleBrandMAnger.Instance;
             if(newBrand.Text != "")
             vehicleBrand.addVB(new VehicleBrand(selecteditemType, newBrand.Text));
             else
             MessageBox.Show("Please enter value", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
             var VB = vehicleBrand.GetVB();
             flowLayoutBrands.Controls.Clear();
             foreach (var record in VB)
             {
                 if (selecteditemType == record.vehicleType)
                 {
                     BrandType bt = new BrandType();
                     bt.UpdateLabels(record);
                     flowLayoutBrands.Controls.Add(bt);

                     BrandType pT = new BrandType();
                     pT.getVType(selecteditemType, flowLayoutBrands);
                 }

             }
         }*/
    }
}