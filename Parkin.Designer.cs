namespace Parking
{
    partial class Parkin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parkin));
            panel1 = new Panel();
            humBtn = new PictureBox();
            sidebar = new Panel();
            menuContainer = new FlowLayoutPanel();
            panel6 = new Panel();
            menu = new Button();
            button6 = new Button();
            button5 = new Button();
            button7 = new Button();
            menuTransition = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel3 = new Panel();
            label1 = new Label();
            label12 = new Label();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel11 = new Panel();
            button3 = new Button();
            panel15 = new Panel();
            numCV = new Label();
            label14 = new Label();
            panel12 = new Panel();
            button1 = new Button();
            searchVH = new TextBox();
            panel7 = new Panel();
            button2 = new Button();
            panel8 = new Panel();
            parkout = new Button();
            panel9 = new Panel();
            logo = new Button();
            panel13 = new Panel();
            numV = new Label();
            label5 = new Label();
            panel10 = new Panel();
            label9 = new Label();
            button8 = new Button();
            panel14 = new Panel();
            numPV = new Label();
            panel4 = new Panel();
            btnCleared = new Button();
            panel5 = new Panel();
            admin1 = new admin();
            history1 = new History();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)humBtn).BeginInit();
            sidebar.SuspendLayout();
            menuContainer.SuspendLayout();
            panel6.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel11.SuspendLayout();
            panel15.SuspendLayout();
            panel12.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel13.SuspendLayout();
            panel10.SuspendLayout();
            panel14.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(humBtn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1851, 57);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // humBtn
            // 
            humBtn.Image = (Image)resources.GetObject("humBtn.Image");
            humBtn.Location = new Point(6, 12);
            humBtn.Name = "humBtn";
            humBtn.Size = new Size(59, 39);
            humBtn.TabIndex = 2;
            humBtn.TabStop = false;
            humBtn.Click += humBtn_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(22, 19, 75);
            sidebar.Controls.Add(menuContainer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 57);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(261, 1252);
            sidebar.TabIndex = 6;
            // 
            // menuContainer
            // 
            menuContainer.Controls.Add(panel6);
            menuContainer.Controls.Add(button6);
            menuContainer.Controls.Add(button5);
            menuContainer.Controls.Add(button7);
            menuContainer.Location = new Point(6, 3);
            menuContainer.Name = "menuContainer";
            menuContainer.Size = new Size(255, 395);
            menuContainer.TabIndex = 7;
            // 
            // panel6
            // 
            panel6.BackgroundImageLayout = ImageLayout.None;
            panel6.Controls.Add(menu);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(249, 66);
            panel6.TabIndex = 4;
            // 
            // menu
            // 
            menu.BackColor = Color.FromArgb(31, 28, 75);
            menu.BackgroundImageLayout = ImageLayout.None;
            menu.Cursor = Cursors.Hand;
            menu.FlatAppearance.BorderSize = 0;
            menu.FlatStyle = FlatStyle.Flat;
            menu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menu.ForeColor = Color.White;
            menu.Image = (Image)resources.GetObject("menu.Image");
            menu.ImageAlign = ContentAlignment.MiddleLeft;
            menu.Location = new Point(-3, -9);
            menu.Name = "menu";
            menu.Size = new Size(252, 75);
            menu.TabIndex = 3;
            menu.Text = "Menu";
            menu.UseVisualStyleBackColor = false;
            menu.Click += menu_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(31, 28, 75);
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 75);
            button6.Name = "button6";
            button6.Size = new Size(249, 68);
            button6.TabIndex = 13;
            button6.Text = "Home";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(31, 28, 75);
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 149);
            button5.Name = "button5";
            button5.Size = new Size(249, 68);
            button5.TabIndex = 3;
            button5.Text = "History";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(31, 28, 75);
            button7.BackgroundImageLayout = ImageLayout.None;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 223);
            button7.Name = "button7";
            button7.Size = new Size(249, 68);
            button7.TabIndex = 14;
            button7.Text = "     Vehicle Setting";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // menuTransition
            // 
            menuTransition.Interval = 10;
            menuTransition.Tick += menuTransition_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Location = new Point(50, 367);
            panel2.Name = "panel2";
            panel2.Size = new Size(1520, 843);
            panel2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top;
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Location = new Point(79, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(1330, 809);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.Click += flowLayoutPanel2_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(129, 300);
            panel3.Name = "panel3";
            panel3.Size = new Size(1330, 61);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(884, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 11;
            label1.Text = "Time";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1043, 19);
            label12.Name = "label12";
            label12.Size = new Size(67, 28);
            label12.TabIndex = 10;
            label12.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(652, 19);
            label8.Name = "label8";
            label8.Size = new Size(54, 28);
            label8.TabIndex = 6;
            label8.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(405, 19);
            label4.Name = "label4";
            label4.Size = new Size(70, 28);
            label4.TabIndex = 2;
            label4.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(222, 19);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 1;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 19);
            label2.Name = "label2";
            label2.Size = new Size(95, 28);
            label2.TabIndex = 0;
            label2.Text = "Plate No.";
            label2.Click += label2_Click;
            // 
            // panel11
            // 
            panel11.Anchor = AnchorStyles.Top;
            panel11.BackColor = Color.FromArgb(22, 19, 75);
            panel11.Controls.Add(button3);
            panel11.Controls.Add(panel15);
            panel11.Controls.Add(label14);
            panel11.Location = new Point(903, 24);
            panel11.Name = "panel11";
            panel11.Size = new Size(260, 125);
            panel11.TabIndex = 10;
            panel11.Paint += panel11_Paint;
            // 
            // button3
            // 
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(6, 17);
            button3.Name = "button3";
            button3.Size = new Size(87, 48);
            button3.TabIndex = 16;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel15
            // 
            panel15.Controls.Add(numCV);
            panel15.Location = new Point(6, 75);
            panel15.Name = "panel15";
            panel15.Size = new Size(251, 42);
            panel15.TabIndex = 15;
            // 
            // numCV
            // 
            numCV.AutoSize = true;
            numCV.Dock = DockStyle.Right;
            numCV.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numCV.ForeColor = Color.White;
            numCV.Location = new Point(217, 0);
            numCV.Name = "numCV";
            numCV.Size = new Size(34, 37);
            numCV.TabIndex = 0;
            numCV.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.White;
            label14.Location = new Point(99, 29);
            label14.Name = "label14";
            label14.Size = new Size(146, 28);
            label14.TabIndex = 14;
            label14.Text = "Cleared Vihicle";
            // 
            // panel12
            // 
            panel12.Anchor = AnchorStyles.Top;
            panel12.Controls.Add(button1);
            panel12.Controls.Add(searchVH);
            panel12.Location = new Point(129, 258);
            panel12.Name = "panel12";
            panel12.Size = new Size(387, 36);
            panel12.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(302, 3);
            button1.Name = "button1";
            button1.Size = new Size(70, 32);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // searchVH
            // 
            searchVH.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchVH.Location = new Point(0, 3);
            searchVH.Name = "searchVH";
            searchVH.PlaceholderText = "Search Plate No.";
            searchVH.Size = new Size(296, 32);
            searchVH.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top;
            panel7.BackgroundImageLayout = ImageLayout.None;
            panel7.Controls.Add(button2);
            panel7.Location = new Point(1201, 241);
            panel7.Name = "panel7";
            panel7.Size = new Size(122, 53);
            panel7.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(31, 28, 75);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, -12);
            button2.Name = "button2";
            button2.Size = new Size(179, 65);
            button2.TabIndex = 3;
            button2.Text = "Parkin";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top;
            panel8.BackgroundImageLayout = ImageLayout.None;
            panel8.Controls.Add(parkout);
            panel8.Location = new Point(1329, 241);
            panel8.Name = "panel8";
            panel8.Size = new Size(127, 53);
            panel8.TabIndex = 5;
            // 
            // parkout
            // 
            parkout.BackColor = Color.FromArgb(31, 28, 75);
            parkout.BackgroundImageLayout = ImageLayout.None;
            parkout.Cursor = Cursors.Hand;
            parkout.FlatAppearance.BorderSize = 0;
            parkout.FlatStyle = FlatStyle.Flat;
            parkout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkout.ForeColor = Color.White;
            parkout.Image = (Image)resources.GetObject("parkout.Image");
            parkout.ImageAlign = ContentAlignment.MiddleLeft;
            parkout.Location = new Point(0, -17);
            parkout.Name = "parkout";
            parkout.Size = new Size(173, 71);
            parkout.TabIndex = 3;
            parkout.Text = "Parkout";
            parkout.UseVisualStyleBackColor = false;
            parkout.Click += parkout_Click;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top;
            panel9.BackColor = Color.FromArgb(22, 19, 75);
            panel9.Controls.Add(logo);
            panel9.Controls.Add(panel13);
            panel9.Controls.Add(label5);
            panel9.Location = new Point(298, 21);
            panel9.Name = "panel9";
            panel9.Size = new Size(261, 125);
            panel9.TabIndex = 9;
            panel9.Paint += panel9_Paint;
            // 
            // logo
            // 
            logo.BackgroundImageLayout = ImageLayout.None;
            logo.FlatAppearance.BorderSize = 0;
            logo.FlatStyle = FlatStyle.Flat;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(54, 12);
            logo.Name = "logo";
            logo.Size = new Size(48, 48);
            logo.TabIndex = 0;
            logo.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(numV);
            panel13.Location = new Point(8, 66);
            panel13.Name = "panel13";
            panel13.Size = new Size(238, 42);
            panel13.TabIndex = 12;
            // 
            // numV
            // 
            numV.AutoSize = true;
            numV.Dock = DockStyle.Right;
            numV.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numV.ForeColor = Color.White;
            numV.Location = new Point(204, 0);
            numV.Name = "numV";
            numV.Size = new Size(34, 37);
            numV.TabIndex = 0;
            numV.Text = "0";
            numV.Click += numV_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(137, 24);
            label5.Name = "label5";
            label5.Size = new Size(77, 28);
            label5.TabIndex = 1;
            label5.Text = "Vehicle";
            // 
            // panel10
            // 
            panel10.Anchor = AnchorStyles.Top;
            panel10.BackColor = Color.FromArgb(22, 19, 75);
            panel10.Controls.Add(label9);
            panel10.Controls.Add(button8);
            panel10.Controls.Add(panel14);
            panel10.Location = new Point(600, 21);
            panel10.Name = "panel10";
            panel10.Size = new Size(261, 125);
            panel10.TabIndex = 13;
            panel10.Paint += panel10_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(106, 27);
            label9.Name = "label9";
            label9.Size = new Size(145, 28);
            label9.TabIndex = 14;
            label9.Text = "Parked Vehicle";
            // 
            // button8
            // 
            button8.BackgroundImageLayout = ImageLayout.None;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.Location = new Point(13, 17);
            button8.Name = "button8";
            button8.Size = new Size(87, 48);
            button8.TabIndex = 16;
            button8.UseVisualStyleBackColor = true;
            // 
            // panel14
            // 
            panel14.Controls.Add(numPV);
            panel14.Location = new Point(13, 75);
            panel14.Name = "panel14";
            panel14.Size = new Size(238, 42);
            panel14.TabIndex = 15;
            // 
            // numPV
            // 
            numPV.AutoSize = true;
            numPV.Dock = DockStyle.Right;
            numPV.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numPV.ForeColor = Color.White;
            numPV.Location = new Point(204, 0);
            numPV.Name = "numPV";
            numPV.Size = new Size(34, 37);
            numPV.TabIndex = 0;
            numPV.Text = "0";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top;
            panel4.Controls.Add(btnCleared);
            panel4.Location = new Point(1058, 241);
            panel4.Name = "panel4";
            panel4.Size = new Size(137, 52);
            panel4.TabIndex = 14;
            // 
            // btnCleared
            // 
            btnCleared.Anchor = AnchorStyles.Top;
            btnCleared.FlatAppearance.BorderSize = 0;
            btnCleared.FlatStyle = FlatStyle.Flat;
            btnCleared.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCleared.ForeColor = Color.White;
            btnCleared.Image = (Image)resources.GetObject("btnCleared.Image");
            btnCleared.ImageAlign = ContentAlignment.MiddleLeft;
            btnCleared.Location = new Point(0, 7);
            btnCleared.Name = "btnCleared";
            btnCleared.Size = new Size(134, 42);
            btnCleared.TabIndex = 9;
            btnCleared.Text = "           Clear list";
            btnCleared.UseVisualStyleBackColor = true;
            btnCleared.Click += btnCleared_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(admin1);
            panel5.Controls.Add(history1);
            panel5.Controls.Add(panel4);
            panel5.Controls.Add(panel10);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel12);
            panel5.Controls.Add(panel11);
            panel5.Controls.Add(panel3);
            panel5.Controls.Add(panel2);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(261, 57);
            panel5.Name = "panel5";
            panel5.Size = new Size(1590, 1252);
            panel5.TabIndex = 9;
            // 
            // admin1
            // 
            admin1.BackColor = Color.FromArgb(22, 19, 64);
            admin1.Dock = DockStyle.Fill;
            admin1.Location = new Point(0, 0);
            admin1.Name = "admin1";
            admin1.Size = new Size(1590, 1252);
            admin1.TabIndex = 16;
            // 
            // history1
            // 
            history1.BackColor = Color.FromArgb(22, 19, 64);
            history1.Dock = DockStyle.Fill;
            history1.Location = new Point(0, 0);
            history1.Name = "history1";
            history1.Size = new Size(1590, 1252);
            history1.TabIndex = 15;
            // 
            // Parkin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(22, 19, 64);
            Controls.Add(panel5);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            Name = "Parkin";
            Size = new Size(1851, 1309);
            Load += Parkin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)humBtn).EndInit();
            sidebar.ResumeLayout(false);
            menuContainer.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel sidebar;
        private FlowLayoutPanel menuContainer;
        private Panel panel6;
        private Button menu;
        private PictureBox humBtn;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button button5;
        private Button button6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button7;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel3;
        private Label label1;
        private Label label12;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel11;
        private Button button3;
        private Panel panel15;
        private Label numCV;
        private Label label14;
        private Panel panel12;
        private Button button1;
        private TextBox searchVH;
        private Panel panel7;
        private Button button2;
        private Panel panel8;
        private Button parkout;
        private Panel panel9;
        private Button logo;
        private Panel panel13;
        private Label numV;
        private Label label5;
        private Panel panel10;
        private Label label9;
        private Button button8;
        private Panel panel14;
        private Label numPV;
        private Panel panel4;
        private Button btnCleared;
        private Panel panel5;
        private History history1;
        private admin admin1;
    }
}
