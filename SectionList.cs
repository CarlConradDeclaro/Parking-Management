using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class SectionList : UserControl
    {
         
        public SectionList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int borderRadius = 20; // You can adjust the value to change the roundness of the corners
            int width = panel1.Width;
            int height = panel1.Height;
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); // Top-left corner
            path.AddArc(width - borderRadius, 0, borderRadius, borderRadius, 270, 90); // Top-right corner
            path.AddArc(width - borderRadius, height - borderRadius, borderRadius, borderRadius, 0, 90); // Bottom-right corner
            path.AddArc(0, height - borderRadius, borderRadius, borderRadius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            
            panel1.Region = new Region(path);
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SectionList_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int borderRadius = 20; // You can adjust the value to change the roundness of the corners
            int width = panel2.Width;
            int height = panel2.Height;
            path.AddArc(0, 0, borderRadius, borderRadius, 180, 90); // Top-left corner
            path.AddArc(width - borderRadius, 0, borderRadius, borderRadius, 270, 90); // Top-right corner
            path.AddArc(width - borderRadius, height - borderRadius, borderRadius, borderRadius, 0, 90); // Bottom-right corner
            path.AddArc(0, height - borderRadius, borderRadius, borderRadius, 90, 90); // Bottom-left corner
            path.CloseFigure();

            // Set the region of the panel to the rounded rectangle shape
            panel2.Region = new Region(path);
        }


        public void UpdateLabels(Section section)
        {
            label1.Text =  section.SectionName;
            label2.Text = $"{section.Capacity}";
            label3.Text = $"{section.Parked}";
            label4.Text = $"{section.Cleared}";
        }
    }
}
