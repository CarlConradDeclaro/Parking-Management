using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class vehicleDetails : UserControl
    {
        public vehicleDetails()
        {
            InitializeComponent();
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        public void UpdateLabels(string data1, string data2)
        {    
            vLabel1.Text = data1;
            vLabel1Data.Text = data2; 
          
         
        }

        private void vehicleDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
