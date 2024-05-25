using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class admin : UserControl
    {
        String connectionString = ConnectionString.Instance.connectionString();


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
            panel1.SetRounded(10);
            panel4.SetRounded(10);
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (selectedItemType.SelectedItem?.ToString() == null)
            {
                errorSelectedType.Text = "Please select a Vehicle Type";
                return;
            }

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

            errorSelectedType.Text = "";
        }

        private void selectedItemType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //errorEditName
            if (string.IsNullOrEmpty(typeName.Text))
            {
                errorEditName.Text = "Cannot be empty";
                return;
            }
            editType(1);
            selectTypeCB();
            display();
            errorEditName.Text = "";
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
            errorSelectedType.Text = "";
            errorEditFlagdown.Text = "";
            errorEditName.Text = "";
            errorAAPH.Text = "";

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
            if ((double)flagDown.Value <= 0)
            {
                errorEditFlagdown.Text = "Invalid Flagdown";
                return;
            }

            editType(2);
            selectTypeCB();
            display();
            errorEditFlagdown.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((double)AAPH.Value <= 0)
            {
                errorAAPH.Text = "Invalid Amount per hour!";
                return;
            }

            editType(3);
            selectTypeCB();
            display();
            errorAAPH.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vehiclemanager = VehicleManger.Instance;
            int proceedAddItem = 0;

            if (!string.IsNullOrWhiteSpace(setTypeName.Text))
            {
                proceedAddItem++;
                errorName.Text = "";
            }
            else
            {
                errorName.Text = "Please enter Type name.";
            }

            if ((double)setFlagDown.Value != 0)
            {
                if ((double)setFlagDown.Value > 0)
                {
                    proceedAddItem++;
                    errorFlagDown.Text = "";
                }
                else
                    errorFlagDown.Text = "Invalid Flagdown.";
            }
            else
            {
                errorFlagDown.Text = "Please enter Flagdown amount.";
            }

            //errorAmtPH

            if ((double)setAAPH.Value != 0)
            {
                if ((double)setAAPH.Value > 0)
                {
                    proceedAddItem++;
                    errorAmtPH.Text = "";
                }
                else
                {
                    errorAmtPH.Text = "Invalid Amount Per Hour.";
                }
            }
            else
            {
                errorAmtPH.Text = "Please enter Amount Per Hour.";
            }



            if (proceedAddItem == 3)
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
            int proceedAddItem = 0;

            if (!string.IsNullOrWhiteSpace(setBrandName.Text))
            {
                proceedAddItem++;
                errorBrandName.Text = "";
            }
            else
            {
                errorBrandName.Text = "Please enter Type name.";
            }

            if (selectType.SelectedItem?.ToString() != null)
            {
                proceedAddItem++;
                errorType.Text = "";
            }
            else
            {
                errorType.Text = "Please select a model.";
            }

            if (proceedAddItem == 2)
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
            errorName.Text = "";
            errorFlagDown.Text = "";
            errorAmtPH.Text = "";
            errorBrandName.Text = "";
            errorType.Text = "";
        }

        private void flowLayoutBrands_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            string selectedItemType = this.selectedItemType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedItemType))
            {
                MessageBox.Show("Please select a vehicle type to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(typeName.Text))
            {

                errorEditName.Text = "Cannot be empty";
                return;
            }


            string query = "DELETE FROM Vehicle_Type WHERE vType = @vType";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@vType", selectedItemType);
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Vehicle type deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            display();
                            errorEditName.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("No matching vehicle type found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

public static class RoundedExtensions
{
    public static void SetRounded(this Panel panel, int borderRadius)
    {
        panel.Paint += (sender, e) =>
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
            int diameter = borderRadius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y + bounds.Height - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);

            using (Pen pen = new Pen(panel.BackColor, 2))
            {
                g.DrawPath(pen, path);
            }
        };


        panel.Invalidate();
    }
}