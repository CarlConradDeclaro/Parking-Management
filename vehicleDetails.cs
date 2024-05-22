using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            this.setRounded(8);
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

        public void setRounded(int borderRadius)
        {
            this.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
                int diameter = borderRadius * 2;
                GraphicsPath path = new GraphicsPath();
                path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
                path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y, diameter, diameter, 270, 90);
                path.AddArc(bounds.X + bounds.Width - diameter, bounds.Y + bounds.Height - diameter, diameter, diameter, 0, 90);
                path.AddArc(bounds.X, bounds.Y + bounds.Height - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                this.Region = new Region(path);

                using (Pen pen = new Pen(this.BackColor, 2))
                {
                    g.DrawPath(pen, path);
                }
            };

            // Invalidate to ensure the panel is redrawn
            this.Invalidate();
        }


    }
}
