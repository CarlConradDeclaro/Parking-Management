using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking
{
    public partial class VehiclesData : UserControl
    {
        public VehiclesData()
        {
            InitializeComponent();
            this.setRounded(15);
        }
        public void updateLabel(string type,string flagdown,string amtPH,string NumparkV) {
            typeLabel.Text = type;
            flagDownlabel.Text = flagdown;
            amtPerhHour.Text = amtPH;
            NumberParkVlabel.Text = NumparkV;
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
            this.Invalidate();
        }
    }
}
