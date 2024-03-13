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
    public partial class BrandType : UserControl
    {
        FlowLayoutPanel flowPanelbrands;
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
            var vehicleBrand = VehicleBrandMAnger.Instance;
            var VB = vehicleBrand.GetVB();
            foreach (var record in VB)
            {
                if (brandName.Text == record.vBrand)
                {
                    vehicleBrand.RemoveParkingHistoryRecord(record);
                    MessageBox.Show("Deleted Succesfully", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   break;
               }
            }
         
            foreach (var record in VB)
            {
                if (getvType == record.vehicleType)
                {
                    BrandType bt = new BrandType();
                    bt.UpdateLabels(record);
                    flowPanelbrands.Controls.Add(bt);
                }

            }
        }
    }
}
