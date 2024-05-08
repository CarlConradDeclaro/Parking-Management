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
            palteNo = new Label();
            plateNo = new TextBox();
            type = new Label();
            model = new Label();
            comboBoxModel = new ComboBox();
            driver = new TextBox();
            label5 = new Label();
            comboBoxType = new ComboBox();
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
            AdminLabel = new Label();
            button4 = new Button();
            invalidDriver = new Label();
            invalidPhone = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            comboBoxS_slots = new ComboBox();
            S_loc_Label = new Label();
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
            panel2 = new Panel();
            labelB1 = new Label();
            labelB2 = new Label();
            labelB3 = new Label();
            labelB4 = new Label();
            labelB5 = new Label();
            labelB6 = new Label();
            labelB7 = new Label();
            labelB8 = new Label();
            labelB9 = new Label();
            labelB10 = new Label();
            panel1.SuspendLayout();
            basementPanel.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // palteNo
            // 
            palteNo.AutoSize = true;
            palteNo.BackColor = Color.Transparent;
            palteNo.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Bold);
            palteNo.ForeColor = Color.Red;
            palteNo.Location = new Point(62, 245);
            palteNo.Name = "palteNo";
            palteNo.Size = new Size(109, 32);
            palteNo.TabIndex = 0;
            palteNo.Text = "Plate No*";
            // 
            // plateNo
            // 
            plateNo.Font = new Font("Segoe UI", 13.8F);
            plateNo.Location = new Point(64, 276);
            plateNo.Name = "plateNo";
            plateNo.Size = new Size(352, 38);
            plateNo.TabIndex = 1;
            // 
            // type
            // 
            type.AutoSize = true;
            type.BackColor = Color.Transparent;
            type.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Bold);
            type.ForeColor = Color.Red;
            type.Location = new Point(62, 463);
            type.Name = "type";
            type.Size = new Size(74, 32);
            type.TabIndex = 2;
            type.Text = "Type*";
            // 
            // model
            // 
            model.AutoSize = true;
            model.BackColor = Color.Transparent;
            model.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Bold);
            model.ForeColor = Color.Red;
            model.Location = new Point(62, 355);
            model.Name = "model";
            model.Size = new Size(86, 32);
            model.TabIndex = 4;
            model.Text = "Model*";
            // 
            // comboBoxModel
            // 
            comboBoxModel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModel.Font = new Font("Segoe UI", 13.8F);
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(62, 386);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(350, 39);
            comboBoxModel.TabIndex = 5;
            comboBoxModel.SelectedIndexChanged += comboBoxModel_SelectedIndexChanged;
            // 
            // driver
            // 
            driver.Font = new Font("Segoe UI", 13.8F);
            driver.Location = new Point(526, 387);
            driver.Name = "driver";
            driver.Size = new Size(350, 38);
            driver.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(526, 356);
            label5.Name = "label5";
            label5.Size = new Size(77, 32);
            label5.TabIndex = 8;
            label5.Text = "Driver";
            // 
            // comboBoxType
            // 
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.Font = new Font("Segoe UI", 13.8F);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(62, 494);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(350, 39);
            comboBoxType.TabIndex = 10;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // phoneNo
            // 
            phoneNo.Font = new Font("Segoe UI", 13.8F);
            phoneNo.Location = new Point(526, 276);
            phoneNo.Name = "phoneNo";
            phoneNo.Size = new Size(350, 38);
            phoneNo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sans Serif Collection", 7.8F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(526, 245);
            label1.Name = "label1";
            label1.Size = new Size(114, 32);
            label1.TabIndex = 11;
            label1.Text = "Phone No";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Brown;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(526, 494);
            button1.Name = "button1";
            button1.Size = new Size(108, 40);
            button1.TabIndex = 16;
            button1.Text = "      Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(780, 494);
            button2.Name = "button2";
            button2.Size = new Size(96, 40);
            button2.TabIndex = 17;
            button2.Text = "     Add vehicle";
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
            title.ForeColor = SystemColors.InfoText;
            title.Location = new Point(426, 110);
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
            inValidPN.Location = new Point(64, 317);
            inValidPN.Name = "inValidPN";
            inValidPN.Size = new Size(0, 20);
            inValidPN.TabIndex = 19;
            // 
            // invalidT
            // 
            invalidT.AutoSize = true;
            invalidT.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            invalidT.ForeColor = Color.Red;
            invalidT.Location = new Point(62, 536);
            invalidT.Name = "invalidT";
            invalidT.Size = new Size(0, 20);
            invalidT.TabIndex = 20;
            // 
            // inValidM
            // 
            inValidM.AutoSize = true;
            inValidM.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            inValidM.ForeColor = Color.Red;
            inValidM.Location = new Point(62, 428);
            inValidM.Name = "inValidM";
            inValidM.Size = new Size(0, 20);
            inValidM.TabIndex = 21;
            // 
            // invalid
            // 
            invalid.AutoSize = true;
            invalid.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invalid.ForeColor = Color.Lime;
            invalid.Location = new Point(64, 196);
            invalid.Name = "invalid";
            invalid.Size = new Size(0, 28);
            invalid.TabIndex = 23;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Green;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(654, 494);
            button3.Name = "button3";
            button3.Size = new Size(105, 40);
            button3.TabIndex = 24;
            button3.Text = "    Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(AdminLabel);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1372, 46);
            panel1.TabIndex = 25;
            // 
            // AdminLabel
            // 
            AdminLabel.AutoSize = true;
            AdminLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AdminLabel.ForeColor = Color.White;
            AdminLabel.Location = new Point(12, 9);
            AdminLabel.Name = "AdminLabel";
            AdminLabel.Size = new Size(72, 28);
            AdminLabel.TabIndex = 59;
            AdminLabel.Text = "Admin";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientInactiveCaption;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button4.ForeColor = Color.Brown;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(1296, 6);
            button4.Name = "button4";
            button4.Size = new Size(40, 40);
            button4.TabIndex = 59;
            button4.Text = "      Close";
            button4.UseVisualStyleBackColor = false;
            // 
            // invalidDriver
            // 
            invalidDriver.AutoSize = true;
            invalidDriver.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            invalidDriver.ForeColor = Color.Red;
            invalidDriver.Location = new Point(526, 428);
            invalidDriver.Name = "invalidDriver";
            invalidDriver.Size = new Size(0, 20);
            invalidDriver.TabIndex = 26;
            // 
            // invalidPhone
            // 
            invalidPhone.AutoSize = true;
            invalidPhone.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            invalidPhone.ForeColor = Color.Red;
            invalidPhone.Location = new Point(526, 317);
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
            // comboBoxS_slots
            // 
            comboBoxS_slots.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxS_slots.FormattingEnabled = true;
            comboBoxS_slots.Location = new Point(876, 73);
            comboBoxS_slots.Name = "comboBoxS_slots";
            comboBoxS_slots.Size = new Size(10, 28);
            comboBoxS_slots.TabIndex = 30;
            comboBoxS_slots.SelectedIndexChanged += comboBoxS_slots_SelectedIndexChanged;
            // 
            // S_loc_Label
            // 
            S_loc_Label.AutoSize = true;
            S_loc_Label.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            S_loc_Label.ForeColor = Color.White;
            S_loc_Label.Location = new Point(773, 73);
            S_loc_Label.Name = "S_loc_Label";
            S_loc_Label.Size = new Size(103, 28);
            S_loc_Label.TabIndex = 31;
            S_loc_Label.Text = "S_location";
            // 
            // b01
            // 
            b01.BackColor = Color.Transparent;
            b01.FlatAppearance.BorderSize = 0;
            b01.FlatStyle = FlatStyle.Flat;
            b01.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            b01.Location = new Point(20, 27);
            b01.Name = "b01";
            b01.Size = new Size(163, 74);
            b01.TabIndex = 50;
            b01.Text = " ";
            b01.UseVisualStyleBackColor = false;
            b01.Click += b01_Click;
            // 
            // b08
            // 
            b08.BackColor = Color.Transparent;
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
            b06.FlatAppearance.BorderSize = 0;
            b06.FlatStyle = FlatStyle.Flat;
            b06.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            b06.Location = new Point(212, 27);
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
            // 
            // button13
            // 
            button13.Location = new Point(142, 8);
            button13.Name = "button13";
            button13.Size = new Size(116, 38);
            button13.TabIndex = 56;
            button13.Text = " 1st Floor";
            button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.Location = new Point(266, 8);
            button14.Name = "button14";
            button14.Size = new Size(116, 38);
            button14.TabIndex = 57;
            button14.Text = "2nd Floor";
            button14.UseVisualStyleBackColor = true;
            // 
            // basementPanel
            // 
            basementPanel.BackColor = Color.Transparent;
            basementPanel.BackgroundImage = Properties.Resources.parkingLot;
            basementPanel.BackgroundImageLayout = ImageLayout.Stretch;
            basementPanel.Controls.Add(labelB10);
            basementPanel.Controls.Add(labelB9);
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
            basementPanel.Location = new Point(923, 185);
            basementPanel.Name = "basementPanel";
            basementPanel.Size = new Size(398, 472);
            basementPanel.TabIndex = 49;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button14);
            panel2.Controls.Add(button12);
            panel2.Controls.Add(button13);
            panel2.Location = new Point(923, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(398, 52);
            panel2.TabIndex = 58;
            // 
            // labelB1
            // 
            labelB1.AutoSize = true;
            labelB1.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB1.ForeColor = Color.Yellow;
            labelB1.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB1.Location = new Point(20, 53);
            labelB1.Name = "labelB1";
            labelB1.Size = new Size(48, 23);
            labelB1.TabIndex = 59;
            labelB1.Text = "B-01";
            labelB1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB2
            // 
            labelB2.AutoSize = true;
            labelB2.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB2.ForeColor = Color.Yellow;
            labelB2.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB2.Location = new Point(20, 131);
            labelB2.Name = "labelB2";
            labelB2.Size = new Size(48, 23);
            labelB2.TabIndex = 60;
            labelB2.Text = "B-02";
            labelB2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB3
            // 
            labelB3.AutoSize = true;
            labelB3.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB3.ForeColor = Color.Yellow;
            labelB3.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB3.Location = new Point(20, 225);
            labelB3.Name = "labelB3";
            labelB3.Size = new Size(48, 23);
            labelB3.TabIndex = 61;
            labelB3.Text = "B-03";
            labelB3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB4
            // 
            labelB4.AutoSize = true;
            labelB4.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB4.ForeColor = Color.Yellow;
            labelB4.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB4.Location = new Point(20, 315);
            labelB4.Name = "labelB4";
            labelB4.Size = new Size(48, 23);
            labelB4.TabIndex = 62;
            labelB4.Text = "B-04";
            labelB4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB5
            // 
            labelB5.AutoSize = true;
            labelB5.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB5.ForeColor = Color.Yellow;
            labelB5.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB5.Location = new Point(20, 397);
            labelB5.Name = "labelB5";
            labelB5.Size = new Size(48, 23);
            labelB5.TabIndex = 63;
            labelB5.Text = "B-05";
            labelB5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB6
            // 
            labelB6.AutoSize = true;
            labelB6.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB6.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB6.Location = new Point(334, 53);
            labelB6.Name = "labelB6";
            labelB6.Size = new Size(48, 23);
            labelB6.TabIndex = 64;
            labelB6.Text = "B-06";
            labelB6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB7
            // 
            labelB7.AutoSize = true;
            labelB7.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB7.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB7.Location = new Point(328, 140);
            labelB7.Name = "labelB7";
            labelB7.Size = new Size(48, 23);
            labelB7.TabIndex = 65;
            labelB7.Text = "B-07";
            labelB7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB8
            // 
            labelB8.AutoSize = true;
            labelB8.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB8.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB8.Location = new Point(328, 225);
            labelB8.Name = "labelB8";
            labelB8.Size = new Size(48, 23);
            labelB8.TabIndex = 66;
            labelB8.Text = "B-08";
            labelB8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB9
            // 
            labelB9.AutoSize = true;
            labelB9.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB9.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB9.Location = new Point(328, 315);
            labelB9.Name = "labelB9";
            labelB9.Size = new Size(48, 23);
            labelB9.TabIndex = 67;
            labelB9.Text = "B-09";
            labelB9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelB10
            // 
            labelB10.AutoSize = true;
            labelB10.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelB10.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            labelB10.Location = new Point(327, 397);
            labelB10.Name = "labelB10";
            labelB10.Size = new Size(48, 23);
            labelB10.TabIndex = 68;
            labelB10.Text = "B-10";
            labelB10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ParkingEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 22, 71);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1372, 675);
            Controls.Add(title);
            Controls.Add(panel2);
            Controls.Add(basementPanel);
            Controls.Add(S_loc_Label);
            Controls.Add(comboBoxS_slots);
            Controls.Add(invalidPhone);
            Controls.Add(invalidDriver);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(invalid);
            Controls.Add(inValidM);
            Controls.Add(invalidT);
            Controls.Add(inValidPN);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(phoneNo);
            Controls.Add(label1);
            Controls.Add(comboBoxType);
            Controls.Add(palteNo);
            Controls.Add(plateNo);
            Controls.Add(driver);
            Controls.Add(label5);
            Controls.Add(comboBoxModel);
            Controls.Add(model);
            Controls.Add(type);
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
            ResumeLayout(false);
            PerformLayout();
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
        private ComboBox comboBoxS_slots;
        private Label S_loc_Label;
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
        private Label AdminLabel;
        private Panel basementPanel;
        private Panel panel2;
        private Label labelB1;
        private Label labelB10;
        private Label labelB9;
        private Label labelB8;
        private Label labelB7;
        private Label labelB6;
        private Label labelB5;
        private Label labelB4;
        private Label labelB3;
        private Label labelB2;
    }
}