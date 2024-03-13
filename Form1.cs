namespace Parking
{
    public partial class Form1 : Form
    {

        ParkingEntry pe1;
        Parkout pOut;
        public Form1()
        {
            InitializeComponent();



        }
        bool menuExpand = true;
        private void menuTransition_Tick(object sender, EventArgs e)
        {
        /*    if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 280)
                {
                    menuTransition.Stop();
                    menuExpand = true;

                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 65)
                {
                    menuTransition.Stop();
                    menuExpand = false;

                }
            }
        */
        }


        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
         /*   if (sidebarExpand)
            {
                sidebar.Width -= 5;

                if (sidebar.Width <= 68)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                }
            }
            else
            {
                sidebar.Width += 10;

                if (sidebar.Width >= 200)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();


                }
            }
         */
        }



        private void parkout_Click(object sender, EventArgs e)
        {


        }

        private void parkin_Click(object sender, EventArgs e)
        {

        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void parkOut1_Load(object sender, EventArgs e)
        {

        }

        private void menuContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void parkin1_Load(object sender, EventArgs e)
        {

        }




        private void sidebar_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void menu_Click_1(object sender, EventArgs e)
        {
          //  menuTransition.Start();
        }

        private void humBtn_Click_1(object sender, EventArgs e)
        {
         //   sidebarTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
