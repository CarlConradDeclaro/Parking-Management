namespace Parking
{
    partial class ParkingEntry
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkingEntry));
            comboBoxType = new ComboBox();
            palteNo = new Label();
            plateNo = new TextBox();
            type = new Label();
            model = new Label();
            comboBoxModel = new ComboBox();
            driver = new TextBox();
            label5 = new Label();
            phoneNo = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            title = new Label();
            inValidPN = new Label();
            invalidT = new Label();
            inValidM = new Label();
            invalid = new Label();
            button3 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            invalidDriver = new Label();
            invalidPhone = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            b01 = new Button();
            b08 = new Button();
            b07 = new Button();
            b06 = new Button();
            b05 = new Button();
            b04 = new Button();
            b03 = new Button();
            b02 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            basementPanel = new Panel();
            labelB10 = new Label();
            labelB9 = new Label();
            b10 = new Button();
            b09 = new Button();
            labelB8 = new Label();
            labelB7 = new Label();
            labelB6 = new Label();
            labelB5 = new Label();
            labelB4 = new Label();
            labelB3 = new Label();
            labelB2 = new Label();
            labelB1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            secondFloorPanel = new Panel();
            labelbB10 = new Label();
            labelb09 = new Label();
            bb10 = new Button();
            bb09 = new Button();
            labelb08 = new Label();
            labelb07 = new Label();
            labelb06 = new Label();
            labelb05 = new Label();
            labelb04 = new Label();
            labelb03 = new Label();
            labelb02 = new Label();
            labelb01 = new Label();
            bb04 = new Button();
            bb03 = new Button();
            bb08 = new Button();
            bb07 = new Button();
            bb02 = new Button();
            bb01 = new Button();
            bb05 = new Button();
            bb06 = new Button();
            firstFloorPanel = new Panel();
            labela10 = new Label();
            labela9 = new Label();
            a10 = new Button();
            a09 = new Button();
            labela8 = new Label();
            labela7 = new Label();
            labela6 = new Label();
            labela5 = new Label();
            labela4 = new Label();
            labela3 = new Label();
            labela2 = new Label();
            labela1 = new Label();
            a04 = new Button();
            a03 = new Button();
            a08 = new Button();
            a07 = new Button();
            a02 = new Button();
            a01 = new Button();
            a05 = new Button();
            a06 = new Button();
            panel5 = new Panel();
            panel1.SuspendLayout();
            basementPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            secondFloorPanel.SuspendLayout();
            firstFloorPanel.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.White;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.DropDownWidth = 350;
            comboBoxType.Font = new Font("Segoe UI", 13.8F);
            comboBoxType.ForeColor = Color.Black;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(22, 254);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(350, 39);
            comboBoxType.TabIndex = 10;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // palteNo
            // 
            palteNo.AutoSize = true;
            palteNo.BackColor = Color.Transparent;
            palteNo.Font = new Font("NSimSun", 13.8F, FontStyle.Bold);
            palteNo.ForeColor = Color.WhiteSmoke;
            palteNo.Location = new Point(24, 111);
            palteNo.Name = "palteNo";
            palteNo.Size = new Size(127, 23);
            palteNo.TabIndex = 0;
            palteNo.Text = "Plate No*";
            // 
            // plateNo
            // 
            plateNo.BackColor = Color.White;
            plateNo.BorderStyle = BorderStyle.None;
            plateNo.Font = new Font("NSimSun", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            plateNo.ForeColor = Color.Black;
            plateNo.Location = new Point(24, 146);
            plateNo.Name = "plateNo";
            plateNo.Size = new Size(352, 35);
            plateNo.TabIndex = 1;
            // 
            // type
            // 
            type.AutoSize = true;
            type.BackColor = Color.Transparent;
            type.Font = new Font("NSimSun", 13.8F, FontStyle.Bold);
            type.ForeColor = Color.WhiteSmoke;
            type.Location = new Point(22, 223);
            type.Name = "type";
            type.Size = new Size(75, 23);
            type.TabIndex = 2;
            type.Text = "Type*";
            // 
            // model
            // 
            model.AutoSize = true;
            model.BackColor = Color.Transparent;
            model.Font = new Font("NSimSun", 13.8F, FontStyle.Bold);
            model.ForeColor = Color.WhiteSmoke;
            model.Location = new Point(22, 326);
            model.Name = "model";
            model.Size = new Size(88, 23);
            model.TabIndex = 4;
            model.Text = "Model*";
            // 
            // comboBoxModel
            // 
            comboBoxModel.BackColor = Color.White;
            comboBoxModel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModel.Font = new Font("Segoe UI", 13.8F);
            comboBoxModel.ForeColor = Color.Black;
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(22, 357);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(350, 39);
            comboBoxModel.TabIndex = 5;
            comboBoxModel.SelectedIndexChanged += comboBoxModel_SelectedIndexChanged;
            // 
            // driver
            // 
            driver.BackColor = Color.White;
            driver.Font = new Font("NSimSun", 16.2F);
            driver.ForeColor = Color.Black;
            driver.Location = new Point(19, 575);
            driver.Name = "driver";
            driver.Size = new Size(350, 38);
            driver.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("NSimSun", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(19, 544);
            label5.Name = "label5";
            label5.Size = new Size(88, 23);
            label5.TabIndex = 8;
            label5.Text = "Driver";
            // 
            // phoneNo
            // 
            phoneNo.BackColor = Color.White;
            phoneNo.Font = new Font("NSimSun", 16.2F);
            phoneNo.ForeColor = Color.Black;
            phoneNo.Location = new Point(19, 464);
            phoneNo.Name = "phoneNo";
            phoneNo.Size = new Size(350, 38);
            phoneNo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("NSimSun", 13.8F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(19, 433);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 11;
            label1.Text = "Phone No";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Brown;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(525, 627);
            button1.Name = "button1";
            button1.Size = new Size(106, 40);
            button1.TabIndex = 16;
            button1.Text = "      Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Lime;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(740, 627);
            button2.Name = "button2";
            button2.Size = new Size(91, 40);
            button2.TabIndex = 17;
            button2.Text = "     Add ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Bold);
            title.ForeColor = Color.White;
            title.Location = new Point(3, 9);
            title.Name = "title";
            title.Size = new Size(81, 32);
            title.TabIndex = 18;
            title.Text = "Parkin";
            // 
            // inValidPN
            // 
            inValidPN.AutoSize = true;
            inValidPN.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            inValidPN.ForeColor = Color.Red;
            inValidPN.Location = new Point(24, 187);
            inValidPN.Name = "inValidPN";
            inValidPN.Size = new Size(0, 20);
            inValidPN.TabIndex = 19;
            // 
            // invalidT
            // 
            invalidT.AutoSize = true;
            invalidT.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            invalidT.ForeColor = Color.Red;
            invalidT.Location = new Point(22, 296);
            invalidT.Name = "invalidT";
            invalidT.Size = new Size(0, 20);
            invalidT.TabIndex = 20;
            // 
            // inValidM
            // 
            inValidM.AutoSize = true;
            inValidM.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            inValidM.ForeColor = Color.Red;
            inValidM.Location = new Point(22, 399);
            inValidM.Name = "inValidM";
            inValidM.Size = new Size(0, 20);
            inValidM.TabIndex = 21;
            // 
            // invalid
            // 
            invalid.AutoSize = true;
            invalid.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invalid.ForeColor = Color.Lime;
            invalid.Location = new Point(24, 76);
            invalid.Name = "invalid";
            invalid.Size = new Size(0, 28);
            invalid.TabIndex = 23;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Yellow;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(637, 627);
            button3.Name = "button3";
            button3.Size = new Size(107, 40);
            button3.TabIndex = 24;
            button3.Text = "    Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 10, 60);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(title);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 43);
            panel1.TabIndex = 25;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button4.ForeColor = Color.Brown;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(809, 1);
            button4.Name = "button4";
            button4.Size = new Size(40, 40);
            button4.TabIndex = 59;
            button4.Text = "      Close";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // invalidDriver
            // 
            invalidDriver.AutoSize = true;
            invalidDriver.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            invalidDriver.ForeColor = Color.Red;
            invalidDriver.Location = new Point(19, 631);
            invalidDriver.Name = "invalidDriver";
            invalidDriver.Size = new Size(0, 20);
            invalidDriver.TabIndex = 26;
            // 
            // invalidPhone
            // 
            invalidPhone.AutoSize = true;
            invalidPhone.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            invalidPhone.ForeColor = Color.Red;
            invalidPhone.Location = new Point(19, 505);
            invalidPhone.Name = "invalidPhone";
            invalidPhone.Size = new Size(0, 20);
            invalidPhone.TabIndex = 27;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // b01
            // 
            b01.BackColor = Color.Transparent;
            b01.BackgroundImageLayout = ImageLayout.Stretch;
            b01.FlatAppearance.BorderSize = 0;
            b01.FlatStyle = FlatStyle.Flat;
            b01.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b01.Location = new Point(20, 27);
            b01.Name = "b01";
            b01.Size = new Size(163, 73);
            b01.TabIndex = 50;
            b01.Text = " ";
            b01.UseVisualStyleBackColor = false;
            b01.Click += b01_Click;
            // 
            // b08
            // 
            b08.BackColor = Color.Transparent;
            b08.BackgroundImageLayout = ImageLayout.Stretch;
            b08.FlatAppearance.BorderSize = 0;
            b08.FlatStyle = FlatStyle.Flat;
            b08.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            b08.Location = new Point(213, 199);
            b08.Name = "b08";
            b08.Size = new Size(163, 74);
            b08.TabIndex = 57;
            b08.Text = " ";
            b08.UseVisualStyleBackColor = false;
            b08.Click += b08_Click_1;
            // 
            // b07
            // 
            b07.BackColor = Color.Transparent;
            b07.BackgroundImageLayout = ImageLayout.Stretch;
            b07.FlatAppearance.BorderSize = 0;
            b07.FlatStyle = FlatStyle.Flat;
            b07.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            b07.Location = new Point(213, 112);
            b07.Name = "b07";
            b07.Size = new Size(163, 74);
            b07.TabIndex = 56;
            b07.Text = " ";
            b07.UseVisualStyleBackColor = false;
            b07.Click += b07_Click_1;
            // 
            // b06
            // 
            b06.BackColor = Color.Transparent;
            b06.BackgroundImageLayout = ImageLayout.Stretch;
            b06.FlatAppearance.BorderSize = 0;
            b06.FlatStyle = FlatStyle.Flat;
            b06.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            b06.Location = new Point(218, 27);
            b06.Name = "b06";
            b06.Size = new Size(163, 74);
            b06.TabIndex = 55;
            b06.Text = " ";
            b06.UseVisualStyleBackColor = false;
            b06.Click += b06_Click;
            // 
            // b05
            // 
            b05.BackColor = Color.Transparent;
            b05.BackgroundImageLayout = ImageLayout.Stretch;
            b05.FlatAppearance.BorderSize = 0;
            b05.FlatStyle = FlatStyle.Flat;
            b05.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            b05.Location = new Point(20, 371);
            b05.Name = "b05";
            b05.Size = new Size(163, 74);
            b05.TabIndex = 54;
            b05.Text = " ";
            b05.UseVisualStyleBackColor = false;
            b05.Click += b05_Click_1;
            // 
            // b04
            // 
            b04.BackColor = Color.Transparent;
            b04.BackgroundImageLayout = ImageLayout.Stretch;
            b04.FlatAppearance.BorderSize = 0;
            b04.FlatStyle = FlatStyle.Flat;
            b04.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            b04.Location = new Point(20, 289);
            b04.Name = "b04";
            b04.Size = new Size(163, 74);
            b04.TabIndex = 53;
            b04.UseVisualStyleBackColor = false;
            b04.Click += b04_Click;
            // 
            // b03
            // 
            b03.BackColor = Color.Transparent;
            b03.BackgroundImageLayout = ImageLayout.Stretch;
            b03.FlatAppearance.BorderSize = 0;
            b03.FlatStyle = FlatStyle.Flat;
            b03.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            b03.Location = new Point(20, 194);
            b03.Name = "b03";
            b03.Size = new Size(163, 74);
            b03.TabIndex = 52;
            b03.UseVisualStyleBackColor = false;
            b03.Click += b03_Click;
            // 
            // b02
            // 
            b02.BackColor = Color.Transparent;
            b02.BackgroundImageLayout = ImageLayout.Stretch;
            b02.FlatAppearance.BorderSize = 0;
            b02.FlatStyle = FlatStyle.Flat;
            b02.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            b02.Location = new Point(20, 114);
            b02.Name = "b02";
            b02.Size = new Size(163, 74);
            b02.TabIndex = 51;
            b02.Text = " ";
            b02.UseVisualStyleBackColor = false;
            b02.Click += button5_Click;
            // 
            // button12
            // 
            button12.Location = new Point(20, 8);
            button12.Name = "button12";
            button12.Size = new Size(116, 38);
            button12.TabIndex = 55;
            button12.Text = "Basement";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(142, 8);
            button13.Name = "button13";
            button13.Size = new Size(116, 38);
            button13.TabIndex = 56;
            button13.Text = " 1st Floor";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(266, 8);
            button14.Name = "button14";
            button14.Size = new Size(116, 38);
            button14.TabIndex = 57;
            button14.Text = "2nd Floor";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // basementPanel
            // 
            basementPanel.BackColor = Color.Transparent;
            basementPanel.BackgroundImage = Properties.Resources.parkingLot;
            basementPanel.BackgroundImageLayout = ImageLayout.Stretch;
            basementPanel.Controls.Add(labelB10);
            basementPanel.Controls.Add(labelB9);
            basementPanel.Controls.Add(b10);
            basementPanel.Controls.Add(b09);
            basementPanel.Controls.Add(labelB8);
            basementPanel.Controls.Add(labelB7);
            basementPanel.Controls.Add(labelB6);
            basementPanel.Controls.Add(labelB5);
            basementPanel.Controls.Add(labelB4);
            basementPanel.Controls.Add(labelB3);
            basementPanel.Controls.Add(labelB2);
            basementPanel.Controls.Add(labelB1);
            basementPanel.Controls.Add(b04);
            basementPanel.Controls.Add(b03);
            basementPanel.Controls.Add(b08);
            basementPanel.Controls.Add(b07);
            basementPanel.Controls.Add(b02);
            basementPanel.Controls.Add(b01);
            basementPanel.Controls.Add(b05);
            basementPanel.Controls.Add(b06);
            basementPanel.Dock = DockStyle.Fill;
            basementPanel.Location = new Point(0, 0);
            basementPanel.Name = "basementPanel";
            basementPanel.Size = new Size(398, 463);
            basementPanel.TabIndex = 49;
            // 
            // labelB10
            // 
            labelB10.AutoSize = true;
            labelB10.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB10.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB10.Location = new Point(317, 397);
            labelB10.Name = "labelB10";
            labelB10.Size = new Size(64, 23);
            labelB10.TabIndex = 72;
            labelB10.Text = "BM-10";
            labelB10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB9
            // 
            labelB9.AutoSize = true;
            labelB9.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB9.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB9.Location = new Point(318, 308);
            labelB9.Name = "labelB9";
            labelB9.Size = new Size(64, 23);
            labelB9.TabIndex = 71;
            labelB9.Text = "BM-09";
            labelB9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // b10
            // 
            b10.BackColor = Color.Transparent;
            b10.BackgroundImageLayout = ImageLayout.Stretch;
            b10.FlatAppearance.BorderSize = 0;
            b10.FlatStyle = FlatStyle.Flat;
            b10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            b10.Location = new Point(220, 362);
            b10.Name = "b10";
            b10.Size = new Size(163, 74);
            b10.TabIndex = 70;
            b10.Text = " ";
            b10.UseVisualStyleBackColor = false;
            b10.Click += b10_Click;
            // 
            // b09
            // 
            b09.BackColor = Color.Transparent;
            b09.BackgroundImageLayout = ImageLayout.Stretch;
            b09.FlatAppearance.BorderSize = 0;
            b09.FlatStyle = FlatStyle.Flat;
            b09.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            b09.Location = new Point(218, 282);
            b09.Name = "b09";
            b09.Size = new Size(163, 74);
            b09.TabIndex = 69;
            b09.Text = " ";
            b09.UseVisualStyleBackColor = false;
            b09.Click += b09_Click;
            // 
            // labelB8
            // 
            labelB8.AutoSize = true;
            labelB8.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB8.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB8.Location = new Point(319, 223);
            labelB8.Name = "labelB8";
            labelB8.Size = new Size(64, 23);
            labelB8.TabIndex = 66;
            labelB8.Text = "BM-08";
            labelB8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB7
            // 
            labelB7.AutoSize = true;
            labelB7.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB7.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB7.Location = new Point(319, 138);
            labelB7.Name = "labelB7";
            labelB7.Size = new Size(64, 23);
            labelB7.TabIndex = 65;
            labelB7.Text = "BM-07";
            labelB7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB6
            // 
            labelB6.AutoSize = true;
            labelB6.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB6.Location = new Point(325, 51);
            labelB6.Name = "labelB6";
            labelB6.Size = new Size(64, 23);
            labelB6.TabIndex = 64;
            labelB6.Text = "BM-06";
            labelB6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB5
            // 
            labelB5.AutoSize = true;
            labelB5.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB5.ForeColor = Color.Yellow;
            labelB5.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB5.Location = new Point(20, 397);
            labelB5.Name = "labelB5";
            labelB5.Size = new Size(64, 23);
            labelB5.TabIndex = 63;
            labelB5.Text = "BM-05";
            labelB5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB4
            // 
            labelB4.AutoSize = true;
            labelB4.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB4.ForeColor = Color.Yellow;
            labelB4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB4.Location = new Point(20, 315);
            labelB4.Name = "labelB4";
            labelB4.Size = new Size(64, 23);
            labelB4.TabIndex = 62;
            labelB4.Text = "BM-04";
            labelB4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB3
            // 
            labelB3.AutoSize = true;
            labelB3.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB3.ForeColor = Color.Yellow;
            labelB3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB3.Location = new Point(20, 225);
            labelB3.Name = "labelB3";
            labelB3.Size = new Size(64, 23);
            labelB3.TabIndex = 61;
            labelB3.Text = "BM-03";
            labelB3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB2
            // 
            labelB2.AutoSize = true;
            labelB2.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB2.ForeColor = Color.Yellow;
            labelB2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB2.Location = new Point(20, 131);
            labelB2.Name = "labelB2";
            labelB2.Size = new Size(64, 23);
            labelB2.TabIndex = 60;
            labelB2.Text = "BM-02";
            labelB2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB1
            // 
            labelB1.AutoSize = true;
            labelB1.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB1.ForeColor = Color.Yellow;
            labelB1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB1.Location = new Point(20, 53);
            labelB1.Name = "labelB1";
            labelB1.Size = new Size(64, 23);
            labelB1.TabIndex = 59;
            labelB1.Text = "BM-01";
            labelB1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button14);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button13);
            panel2.Location = new Point(9, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(408, 52);
            panel2.TabIndex = 58;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 0, 64);
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(invalid);
            panel3.Controls.Add(type);
            panel3.Controls.Add(model);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(comboBoxModel);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(driver);
            panel3.Controls.Add(plateNo);
            panel3.Controls.Add(invalidPhone);
            panel3.Controls.Add(palteNo);
            panel3.Controls.Add(invalidDriver);
            panel3.Controls.Add(comboBoxType);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(phoneNo);
            panel3.Controls.Add(inValidM);
            panel3.Controls.Add(invalidT);
            panel3.Controls.Add(inValidPN);
            panel3.Location = new Point(3, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(847, 676);
            panel3.TabIndex = 59;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("NSimSun", 13.8F, FontStyle.Bold);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(96, 22);
            label2.Name = "label2";
            label2.Size = new Size(218, 23);
            label2.TabIndex = 61;
            label2.Text = "Vehicle Details:";
            // 
            // panel4
            // 
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(label3);
            panel4.Controls.Add(secondFloorPanel);
            panel4.Controls.Add(firstFloorPanel);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel2);
            panel4.Location = new Point(410, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(421, 599);
            panel4.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("NSimSun", 13.8F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(139, 7);
            label3.Name = "label3";
            label3.Size = new Size(179, 23);
            label3.TabIndex = 63;
            label3.Text = "Parking Area:";
            // 
            // secondFloorPanel
            // 
            secondFloorPanel.BackColor = Color.Transparent;
            secondFloorPanel.BackgroundImage = Properties.Resources.parkingLot;
            secondFloorPanel.BackgroundImageLayout = ImageLayout.Stretch;
            secondFloorPanel.Controls.Add(labelbB10);
            secondFloorPanel.Controls.Add(labelb09);
            secondFloorPanel.Controls.Add(bb10);
            secondFloorPanel.Controls.Add(bb09);
            secondFloorPanel.Controls.Add(labelb08);
            secondFloorPanel.Controls.Add(labelb07);
            secondFloorPanel.Controls.Add(labelb06);
            secondFloorPanel.Controls.Add(labelb05);
            secondFloorPanel.Controls.Add(labelb04);
            secondFloorPanel.Controls.Add(labelb03);
            secondFloorPanel.Controls.Add(labelb02);
            secondFloorPanel.Controls.Add(labelb01);
            secondFloorPanel.Controls.Add(bb04);
            secondFloorPanel.Controls.Add(bb03);
            secondFloorPanel.Controls.Add(bb08);
            secondFloorPanel.Controls.Add(bb07);
            secondFloorPanel.Controls.Add(bb02);
            secondFloorPanel.Controls.Add(bb01);
            secondFloorPanel.Controls.Add(bb05);
            secondFloorPanel.Controls.Add(bb06);
            secondFloorPanel.Location = new Point(868, 131);
            secondFloorPanel.Name = "secondFloorPanel";
            secondFloorPanel.Size = new Size(395, 460);
            secondFloorPanel.TabIndex = 62;
            // 
            // labelbB10
            // 
            labelbB10.AutoSize = true;
            labelbB10.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelbB10.ForeColor = SystemColors.InactiveCaption;
            labelbB10.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelbB10.Location = new Point(326, 397);
            labelbB10.Name = "labelbB10";
            labelbB10.Size = new Size(48, 23);
            labelbB10.TabIndex = 68;
            labelbB10.Text = "B-10";
            labelbB10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelb09
            // 
            labelb09.AutoSize = true;
            labelb09.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelb09.ForeColor = SystemColors.InactiveCaption;
            labelb09.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelb09.Location = new Point(326, 312);
            labelb09.Name = "labelb09";
            labelb09.Size = new Size(48, 23);
            labelb09.TabIndex = 67;
            labelb09.Text = "B-09";
            labelb09.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bb10
            // 
            bb10.BackColor = Color.Transparent;
            bb10.BackgroundImageLayout = ImageLayout.Stretch;
            bb10.FlatAppearance.BorderSize = 0;
            bb10.FlatStyle = FlatStyle.Flat;
            bb10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            bb10.Location = new Point(212, 371);
            bb10.Name = "bb10";
            bb10.Size = new Size(163, 74);
            bb10.TabIndex = 69;
            bb10.Text = " ";
            bb10.UseVisualStyleBackColor = false;
            bb10.Click += bb10_Click;
            // 
            // bb09
            // 
            bb09.BackColor = Color.Transparent;
            bb09.BackgroundImageLayout = ImageLayout.Stretch;
            bb09.FlatAppearance.BorderSize = 0;
            bb09.FlatStyle = FlatStyle.Flat;
            bb09.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            bb09.Location = new Point(216, 289);
            bb09.Name = "bb09";
            bb09.Size = new Size(163, 74);
            bb09.TabIndex = 69;
            bb09.Text = " ";
            bb09.UseVisualStyleBackColor = false;
            bb09.Click += bb09_Click;
            // 
            // labelb08
            // 
            labelb08.AutoSize = true;
            labelb08.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelb08.ForeColor = SystemColors.InactiveCaption;
            labelb08.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelb08.Location = new Point(328, 225);
            labelb08.Name = "labelb08";
            labelb08.Size = new Size(48, 23);
            labelb08.TabIndex = 66;
            labelb08.Text = "B-08";
            labelb08.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelb07
            // 
            labelb07.AutoSize = true;
            labelb07.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelb07.ForeColor = SystemColors.InactiveCaption;
            labelb07.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelb07.Location = new Point(328, 140);
            labelb07.Name = "labelb07";
            labelb07.Size = new Size(48, 23);
            labelb07.TabIndex = 65;
            labelb07.Text = "B-07";
            labelb07.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelb06
            // 
            labelb06.AutoSize = true;
            labelb06.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelb06.ForeColor = SystemColors.InactiveCaption;
            labelb06.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelb06.Location = new Point(334, 53);
            labelb06.Name = "labelb06";
            labelb06.Size = new Size(48, 23);
            labelb06.TabIndex = 64;
            labelb06.Text = "B-06";
            labelb06.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelb05
            // 
            labelb05.AutoSize = true;
            labelb05.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelb05.ForeColor = Color.Orange;
            labelb05.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelb05.Location = new Point(20, 397);
            labelb05.Name = "labelb05";
            labelb05.Size = new Size(48, 23);
            labelb05.TabIndex = 63;
            labelb05.Text = "B-05";
            labelb05.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelb04
            // 
            labelb04.AutoSize = true;
            labelb04.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelb04.ForeColor = Color.Orange;
            labelb04.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelb04.Location = new Point(20, 315);
            labelb04.Name = "labelb04";
            labelb04.Size = new Size(48, 23);
            labelb04.TabIndex = 62;
            labelb04.Text = "B-04";
            labelb04.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelb03
            // 
            labelb03.AutoSize = true;
            labelb03.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelb03.ForeColor = Color.Orange;
            labelb03.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelb03.Location = new Point(20, 225);
            labelb03.Name = "labelb03";
            labelb03.Size = new Size(48, 23);
            labelb03.TabIndex = 61;
            labelb03.Text = "B-03";
            labelb03.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelb02
            // 
            labelb02.AutoSize = true;
            labelb02.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelb02.ForeColor = Color.Orange;
            labelb02.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelb02.Location = new Point(20, 131);
            labelb02.Name = "labelb02";
            labelb02.Size = new Size(48, 23);
            labelb02.TabIndex = 60;
            labelb02.Text = "B-02";
            labelb02.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelb01
            // 
            labelb01.AutoSize = true;
            labelb01.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelb01.ForeColor = Color.Orange;
            labelb01.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelb01.Location = new Point(20, 53);
            labelb01.Name = "labelb01";
            labelb01.Size = new Size(48, 23);
            labelb01.TabIndex = 59;
            labelb01.Text = "B-01";
            labelb01.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bb04
            // 
            bb04.BackColor = Color.Transparent;
            bb04.BackgroundImageLayout = ImageLayout.Stretch;
            bb04.FlatAppearance.BorderSize = 0;
            bb04.FlatStyle = FlatStyle.Flat;
            bb04.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            bb04.Location = new Point(20, 289);
            bb04.Name = "bb04";
            bb04.Size = new Size(163, 74);
            bb04.TabIndex = 53;
            bb04.UseVisualStyleBackColor = false;
            bb04.Click += bb04_Click;
            // 
            // bb03
            // 
            bb03.BackColor = Color.Transparent;
            bb03.BackgroundImageLayout = ImageLayout.Stretch;
            bb03.FlatAppearance.BorderSize = 0;
            bb03.FlatStyle = FlatStyle.Flat;
            bb03.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            bb03.Location = new Point(20, 194);
            bb03.Name = "bb03";
            bb03.Size = new Size(163, 74);
            bb03.TabIndex = 52;
            bb03.UseVisualStyleBackColor = false;
            bb03.Click += bb03_Click;
            // 
            // bb08
            // 
            bb08.BackColor = Color.Transparent;
            bb08.BackgroundImageLayout = ImageLayout.Stretch;
            bb08.FlatAppearance.BorderSize = 0;
            bb08.FlatStyle = FlatStyle.Flat;
            bb08.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            bb08.Location = new Point(213, 199);
            bb08.Name = "bb08";
            bb08.Size = new Size(163, 74);
            bb08.TabIndex = 57;
            bb08.Text = " ";
            bb08.UseVisualStyleBackColor = false;
            bb08.Click += bb08_Click;
            // 
            // bb07
            // 
            bb07.BackColor = Color.Transparent;
            bb07.BackgroundImageLayout = ImageLayout.Stretch;
            bb07.FlatAppearance.BorderSize = 0;
            bb07.FlatStyle = FlatStyle.Flat;
            bb07.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            bb07.Location = new Point(213, 112);
            bb07.Name = "bb07";
            bb07.Size = new Size(163, 74);
            bb07.TabIndex = 56;
            bb07.Text = " ";
            bb07.UseVisualStyleBackColor = false;
            bb07.Click += bb07_Click;
            // 
            // bb02
            // 
            bb02.BackColor = Color.Transparent;
            bb02.BackgroundImageLayout = ImageLayout.Stretch;
            bb02.FlatAppearance.BorderSize = 0;
            bb02.FlatStyle = FlatStyle.Flat;
            bb02.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            bb02.Location = new Point(20, 114);
            bb02.Name = "bb02";
            bb02.Size = new Size(163, 74);
            bb02.TabIndex = 51;
            bb02.Text = " ";
            bb02.UseVisualStyleBackColor = false;
            bb02.Click += bb02_Click;
            // 
            // bb01
            // 
            bb01.BackColor = Color.Transparent;
            bb01.BackgroundImageLayout = ImageLayout.Stretch;
            bb01.FlatAppearance.BorderSize = 0;
            bb01.FlatStyle = FlatStyle.Flat;
            bb01.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bb01.Location = new Point(20, 27);
            bb01.Name = "bb01";
            bb01.Size = new Size(163, 74);
            bb01.TabIndex = 50;
            bb01.Text = " ";
            bb01.UseVisualStyleBackColor = false;
            bb01.Click += bb01_Click;
            // 
            // bb05
            // 
            bb05.BackColor = Color.Transparent;
            bb05.BackgroundImageLayout = ImageLayout.Stretch;
            bb05.FlatAppearance.BorderSize = 0;
            bb05.FlatStyle = FlatStyle.Flat;
            bb05.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            bb05.Location = new Point(20, 371);
            bb05.Name = "bb05";
            bb05.Size = new Size(163, 74);
            bb05.TabIndex = 54;
            bb05.Text = " ";
            bb05.UseVisualStyleBackColor = false;
            bb05.Click += bb05_Click;
            // 
            // bb06
            // 
            bb06.BackColor = Color.Transparent;
            bb06.BackgroundImageLayout = ImageLayout.Stretch;
            bb06.FlatAppearance.BorderSize = 0;
            bb06.FlatStyle = FlatStyle.Flat;
            bb06.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            bb06.Location = new Point(212, 27);
            bb06.Name = "bb06";
            bb06.Size = new Size(163, 74);
            bb06.TabIndex = 55;
            bb06.Text = " ";
            bb06.UseVisualStyleBackColor = false;
            bb06.Click += bb06_Click;
            // 
            // firstFloorPanel
            // 
            firstFloorPanel.BackColor = Color.Transparent;
            firstFloorPanel.BackgroundImage = Properties.Resources.parkingLot;
            firstFloorPanel.BackgroundImageLayout = ImageLayout.Stretch;
            firstFloorPanel.Controls.Add(labela10);
            firstFloorPanel.Controls.Add(labela9);
            firstFloorPanel.Controls.Add(a10);
            firstFloorPanel.Controls.Add(a09);
            firstFloorPanel.Controls.Add(labela8);
            firstFloorPanel.Controls.Add(labela7);
            firstFloorPanel.Controls.Add(labela6);
            firstFloorPanel.Controls.Add(labela5);
            firstFloorPanel.Controls.Add(labela4);
            firstFloorPanel.Controls.Add(labela3);
            firstFloorPanel.Controls.Add(labela2);
            firstFloorPanel.Controls.Add(labela1);
            firstFloorPanel.Controls.Add(a04);
            firstFloorPanel.Controls.Add(a03);
            firstFloorPanel.Controls.Add(a08);
            firstFloorPanel.Controls.Add(a07);
            firstFloorPanel.Controls.Add(a02);
            firstFloorPanel.Controls.Add(a01);
            firstFloorPanel.Controls.Add(a05);
            firstFloorPanel.Controls.Add(a06);
            firstFloorPanel.Location = new Point(467, 131);
            firstFloorPanel.Name = "firstFloorPanel";
            firstFloorPanel.Size = new Size(395, 460);
            firstFloorPanel.TabIndex = 61;
            // 
            // labela10
            // 
            labela10.AutoSize = true;
            labela10.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labela10.ForeColor = SystemColors.AppWorkspace;
            labela10.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labela10.Location = new Point(326, 397);
            labela10.Name = "labela10";
            labela10.Size = new Size(49, 23);
            labela10.TabIndex = 68;
            labela10.Text = "A-10";
            labela10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labela9
            // 
            labela9.AutoSize = true;
            labela9.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labela9.ForeColor = SystemColors.AppWorkspace;
            labela9.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labela9.Location = new Point(326, 312);
            labela9.Name = "labela9";
            labela9.Size = new Size(49, 23);
            labela9.TabIndex = 67;
            labela9.Text = "A-09";
            labela9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // a10
            // 
            a10.BackColor = Color.Transparent;
            a10.BackgroundImageLayout = ImageLayout.Stretch;
            a10.FlatAppearance.BorderSize = 0;
            a10.FlatStyle = FlatStyle.Flat;
            a10.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            a10.Location = new Point(212, 371);
            a10.Name = "a10";
            a10.Size = new Size(163, 74);
            a10.TabIndex = 69;
            a10.Text = " ";
            a10.UseVisualStyleBackColor = false;
            a10.Click += a10_Click;
            // 
            // a09
            // 
            a09.BackColor = Color.Transparent;
            a09.BackgroundImageLayout = ImageLayout.Stretch;
            a09.FlatAppearance.BorderSize = 0;
            a09.FlatStyle = FlatStyle.Flat;
            a09.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            a09.Location = new Point(216, 289);
            a09.Name = "a09";
            a09.Size = new Size(163, 74);
            a09.TabIndex = 69;
            a09.Text = " ";
            a09.UseVisualStyleBackColor = false;
            a09.Click += a09_Click;
            // 
            // labela8
            // 
            labela8.AutoSize = true;
            labela8.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labela8.ForeColor = SystemColors.AppWorkspace;
            labela8.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labela8.Location = new Point(328, 225);
            labela8.Name = "labela8";
            labela8.Size = new Size(49, 23);
            labela8.TabIndex = 66;
            labela8.Text = "A-08";
            labela8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labela7
            // 
            labela7.AutoSize = true;
            labela7.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labela7.ForeColor = SystemColors.AppWorkspace;
            labela7.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labela7.Location = new Point(328, 140);
            labela7.Name = "labela7";
            labela7.Size = new Size(49, 23);
            labela7.TabIndex = 65;
            labela7.Text = "A-07";
            labela7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labela6
            // 
            labela6.AutoSize = true;
            labela6.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labela6.ForeColor = SystemColors.AppWorkspace;
            labela6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labela6.Location = new Point(334, 53);
            labela6.Name = "labela6";
            labela6.Size = new Size(49, 23);
            labela6.TabIndex = 64;
            labela6.Text = "A-06";
            labela6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labela5
            // 
            labela5.AutoSize = true;
            labela5.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labela5.ForeColor = Color.Khaki;
            labela5.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labela5.Location = new Point(20, 397);
            labela5.Name = "labela5";
            labela5.Size = new Size(49, 23);
            labela5.TabIndex = 63;
            labela5.Text = "A-05";
            labela5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labela4
            // 
            labela4.AutoSize = true;
            labela4.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labela4.ForeColor = Color.Khaki;
            labela4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labela4.Location = new Point(20, 315);
            labela4.Name = "labela4";
            labela4.Size = new Size(49, 23);
            labela4.TabIndex = 62;
            labela4.Text = "A-04";
            labela4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labela3
            // 
            labela3.AutoSize = true;
            labela3.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labela3.ForeColor = Color.Khaki;
            labela3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labela3.Location = new Point(20, 225);
            labela3.Name = "labela3";
            labela3.Size = new Size(49, 23);
            labela3.TabIndex = 61;
            labela3.Text = "A-03";
            labela3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labela2
            // 
            labela2.AutoSize = true;
            labela2.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labela2.ForeColor = Color.Khaki;
            labela2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labela2.Location = new Point(20, 131);
            labela2.Name = "labela2";
            labela2.Size = new Size(49, 23);
            labela2.TabIndex = 60;
            labela2.Text = "A-02";
            labela2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labela1
            // 
            labela1.AutoSize = true;
            labela1.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labela1.ForeColor = Color.Khaki;
            labela1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labela1.Location = new Point(20, 53);
            labela1.Name = "labela1";
            labela1.Size = new Size(49, 23);
            labela1.TabIndex = 59;
            labela1.Text = "A-01";
            labela1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // a04
            // 
            a04.BackColor = Color.Transparent;
            a04.BackgroundImageLayout = ImageLayout.Stretch;
            a04.FlatAppearance.BorderSize = 0;
            a04.FlatStyle = FlatStyle.Flat;
            a04.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            a04.Location = new Point(20, 279);
            a04.Name = "a04";
            a04.Size = new Size(163, 74);
            a04.TabIndex = 53;
            a04.UseVisualStyleBackColor = false;
            a04.Click += a04_Click;
            // 
            // a03
            // 
            a03.BackColor = Color.Transparent;
            a03.BackgroundImageLayout = ImageLayout.Stretch;
            a03.FlatAppearance.BorderSize = 0;
            a03.FlatStyle = FlatStyle.Flat;
            a03.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            a03.Location = new Point(20, 194);
            a03.Name = "a03";
            a03.Size = new Size(163, 74);
            a03.TabIndex = 52;
            a03.UseVisualStyleBackColor = false;
            a03.Click += a03_Click;
            // 
            // a08
            // 
            a08.BackColor = Color.Transparent;
            a08.BackgroundImageLayout = ImageLayout.Stretch;
            a08.FlatAppearance.BorderSize = 0;
            a08.FlatStyle = FlatStyle.Flat;
            a08.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            a08.Location = new Point(213, 199);
            a08.Name = "a08";
            a08.Size = new Size(163, 74);
            a08.TabIndex = 57;
            a08.Text = " ";
            a08.UseVisualStyleBackColor = false;
            a08.Click += a08_Click;
            // 
            // a07
            // 
            a07.BackColor = Color.Transparent;
            a07.BackgroundImageLayout = ImageLayout.Stretch;
            a07.FlatAppearance.BorderSize = 0;
            a07.FlatStyle = FlatStyle.Flat;
            a07.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            a07.Location = new Point(213, 112);
            a07.Name = "a07";
            a07.Size = new Size(163, 74);
            a07.TabIndex = 56;
            a07.Text = " ";
            a07.UseVisualStyleBackColor = false;
            a07.Click += button8_Click;
            // 
            // a02
            // 
            a02.BackColor = Color.Transparent;
            a02.BackgroundImageLayout = ImageLayout.Stretch;
            a02.FlatAppearance.BorderSize = 0;
            a02.FlatStyle = FlatStyle.Flat;
            a02.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            a02.Location = new Point(20, 114);
            a02.Name = "a02";
            a02.Size = new Size(163, 74);
            a02.TabIndex = 51;
            a02.Text = " ";
            a02.UseVisualStyleBackColor = false;
            a02.Click += a02_Click;
            // 
            // a01
            // 
            a01.BackColor = Color.Transparent;
            a01.BackgroundImageLayout = ImageLayout.Stretch;
            a01.FlatAppearance.BorderSize = 0;
            a01.FlatStyle = FlatStyle.Flat;
            a01.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            a01.Location = new Point(20, 27);
            a01.Name = "a01";
            a01.Size = new Size(163, 74);
            a01.TabIndex = 50;
            a01.Text = " ";
            a01.UseVisualStyleBackColor = false;
            a01.Click += a01_Click;
            // 
            // a05
            // 
            a05.BackColor = Color.Transparent;
            a05.BackgroundImageLayout = ImageLayout.Stretch;
            a05.FlatAppearance.BorderSize = 0;
            a05.FlatStyle = FlatStyle.Flat;
            a05.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            a05.Location = new Point(20, 371);
            a05.Name = "a05";
            a05.Size = new Size(163, 74);
            a05.TabIndex = 54;
            a05.Text = " ";
            a05.UseVisualStyleBackColor = false;
            a05.Click += a05_Click;
            // 
            // a06
            // 
            a06.BackColor = Color.Transparent;
            a06.BackgroundImageLayout = ImageLayout.Stretch;
            a06.FlatAppearance.BorderSize = 0;
            a06.FlatStyle = FlatStyle.Flat;
            a06.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            a06.Location = new Point(212, 27);
            a06.Name = "a06";
            a06.Size = new Size(163, 74);
            a06.TabIndex = 55;
            a06.Text = " ";
            a06.UseVisualStyleBackColor = false;
            a06.Click += a06_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(basementPanel);
            panel5.Location = new Point(9, 122);
            panel5.Name = "panel5";
            panel5.Size = new Size(398, 463);
            panel5.TabIndex = 59;
            // 
            // ParkingEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 0, 64);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(855, 732);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "ParkingEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParikingEntry";
            Load += ParkingEntry_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            basementPanel.ResumeLayout(false);
            basementPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            secondFloorPanel.ResumeLayout(false);
            secondFloorPanel.PerformLayout();
            firstFloorPanel.ResumeLayout(false);
            firstFloorPanel.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label palteNo;
        private TextBox plateNo;
        private Label type;
        private Label model;
        private ComboBox comboBoxModel;
        private TextBox driver;
        private Label label5;
        private ComboBox comboBoxType;
        private TextBox phoneNo;
        private Label label1;
        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer sidebarTransition;
        private Label title;
        private Label inValidPN;
        private Label invalidT;
        private Label inValidM;
        private Label invalid;
        private Button button3;
        private Panel panel1;
        private Label invalidDriver;
        private Label invalidPhone;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private Button b01;
        private Button b05;
        private Button b04;
        private Button b03;
        private Button b02;
        private Button b08;
        private Button b07;
        private Button b06;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button4;
        private Panel basementPanel;
        private Panel panel2;
        private Label labelB1;
        private Label labelB8;
        private Label labelB7;
        private Label labelB6;
        private Label labelB5;
        private Label labelB4;
        private Label labelB3;
        private Label labelB2;
        private Panel panel3;
        private Panel panel4;
        private Panel firstFloorPanel;
        private Label labela10;
        private Label labela9;
        private Label labela8;
        private Label labela7;
        private Label labela6;
        private Label labela5;
        private Label labela4;
        private Label labela3;
        private Label labela2;
        private Label labela1;
        private Button a04;
        private Button a03;
        private Button a08;
        private Button a07;
        private Button a02;
        private Button a01;
        private Button a05;
        private Button a06;
        private Button a10;
        private Button a09;
        private Panel panel5;
        private Panel secondFloorPanel;
        private Label labelbB10;
        private Label labelb09;
        private Button bb10;
        private Button bb09;
        private Label labelb08;
        private Label labelb07;
        private Label labelb06;
        private Label labelb05;
        private Label labelb04;
        private Label labelb03;
        private Label labelb02;
        private Label labelb01;
        private Button bb04;
        private Button bb03;
        private Button bb08;
        private Button bb07;
        private Button bb02;
        private Button bb01;
        private Button bb05;
        private Button bb06;
        private Label label2;
        private Label label3;
        private Label labelB10;
        private Label labelB9;
        private Button b10;
        private Button b09;
    }
}