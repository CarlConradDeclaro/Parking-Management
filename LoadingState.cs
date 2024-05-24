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
    public partial class LoadingState : Form
    {
        public LoadingState()
        {
            InitializeComponent();

           
            textAnimationTimer = new System.Windows.Forms.Timer();
            textAnimationTimer.Interval = 500; 
            textAnimationTimer.Tick += textAnimationTimer_Tick_1;
            textAnimationTimer.Start();
            panelLoading.SetRoundedCorners(15);
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {
            panelLoading.Width += 8;
            int percentage = (panelLoading.Width * 100) / 950;
            percentageLabel.Text = $"{percentage}%";


            if (panelLoading.Width >= 950)
            {
                loadingTimer.Stop();
                textAnimationTimer.Stop();
                Form1 content = new Form1();
                content.Show();
                this.Hide();
            }
        }
 
        private int loadingStep = 0;
        
        private void textAnimationTimer_Tick_1(object sender, EventArgs e)
        {
            switch (loadingStep)
            {
                case 0:
                    loadingLabel.Text = "Loading";
                    break;
                case 1:
                    loadingLabel.Text = "Loading.";
                    break;
                case 2:
                    loadingLabel.Text = "Loading..";
                    break;
                case 3:
                    loadingLabel.Text = "Loading...";
                    break;
            }
            loadingStep = (loadingStep + 1) % 4;
        }
    }
}
