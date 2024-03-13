using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class admin : UserControl
    {
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
                        record.vehicleType = typeName.Text;
                        MessageBox.Show("Successfuly changed Type", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (attributes == 2)
                    {
                        record.flagDown = (double)flagDown.Value;
                        MessageBox.Show("Successfuly changed flagdown", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (attributes == 3)
                    {
                        record.additionalAmtPerHour = (double)AAPH.Value;
                        MessageBox.Show("Successfuly changed amount per/hour ", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void button7_Click(object sender, EventArgs e)
        {
            display();
        }

        public void display()
        {
            selectedItemType.Items.Clear();
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
     
        private void displayBrands(object sender, EventArgs e)
        {
            flowLayoutBrands.Controls.Clear();
            var vehicleBrand = VehicleBrandMAnger.Instance;
 
            var VB = vehicleBrand.GetVB();
           
            string selecteditemType = this.selectedItemType.SelectedItem?.ToString();

            foreach (var record in VB)
            {
                if (record.vehicleType == selecteditemType) {
                    BrandType bt = new BrandType();
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
            vehiclemanager.addVPM(new Vehicle(setTypeName.Text, (double)setFlagDown.Value, (double)setAAPH.Value));
            selectTypeCB();
            display();
            MessageBox.Show("Successfuly Added Type", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            vehicleBrand.addVB(new VehicleBrand(selecttype, setBrandName.Text));
            MessageBox.Show("Successfuly Added brand", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void button9_Click(object sender, EventArgs e)
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
        }
    }
}