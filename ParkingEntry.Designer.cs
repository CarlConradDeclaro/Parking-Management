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
            SuspendLayout();
            // 
            // palteNo
            // 
            palteNo.AutoSize = true;
            palteNo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            palteNo.ForeColor = Color.Ivory;
            palteNo.Location = new Point(246, 242);
            palteNo.Name = "palteNo";
            palteNo.Size = new Size(99, 28);
            palteNo.TabIndex = 0;
            palteNo.Text = "Plate No*";
            // 
            // plateNo
            // 
            plateNo.Font = new Font("Segoe UI", 13.8F);
            plateNo.Location = new Point(370, 232);
            plateNo.Name = "plateNo";
            plateNo.Size = new Size(352, 38);
            plateNo.TabIndex = 1;
            // 
            // type
            // 
            type.AutoSize = true;
            type.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            type.ForeColor = Color.White;
            type.Location = new Point(272, 324);
            type.Name = "type";
            type.Size = new Size(64, 28);
            type.TabIndex = 2;
            type.Text = "Type*";
            // 
            // model
            // 
            model.AutoSize = true;
            model.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            model.ForeColor = Color.White;
            model.Location = new Point(257, 410);
            model.Name = "model";
            model.Size = new Size(79, 28);
            model.TabIndex = 4;
            model.Text = "Model*";
            // 
            // comboBoxModel
            // 
            comboBoxModel.Font = new Font("Segoe UI", 13.8F);
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(370, 399);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(350, 39);
            comboBoxModel.TabIndex = 5;
            comboBoxModel.SelectedIndexChanged += comboBoxModel_SelectedIndexChanged;
            // 
            // driver
            // 
            driver.Font = new Font("Segoe UI", 13.8F);
            driver.Location = new Point(370, 486);
            driver.Name = "driver";
            driver.Size = new Size(350, 38);
            driver.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(270, 486);
            label5.Name = "label5";
            label5.Size = new Size(66, 28);
            label5.TabIndex = 8;
            label5.Text = "Driver";
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new Font("Segoe UI", 13.8F);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(370, 313);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(350, 39);
            comboBoxType.TabIndex = 10;
            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            // 
            // phoneNo
            // 
            phoneNo.Font = new Font("Segoe UI", 13.8F);
            phoneNo.Location = new Point(370, 573);
            phoneNo.Name = "phoneNo";
            phoneNo.Size = new Size(350, 38);
            phoneNo.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(232, 573);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 11;
            label1.Text = "Phone No";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Brown;
            button1.Location = new Point(370, 650);
            button1.Name = "button1";
            button1.Size = new Size(95, 34);
            button1.TabIndex = 16;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(64, 64, 64);
            button2.Location = new Point(624, 650);
            button2.Name = "button2";
            button2.Size = new Size(96, 34);
            button2.TabIndex = 17;
            button2.Text = "Add vehicle";
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
            title.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(479, 103);
            title.Name = "title";
            title.Size = new Size(83, 27);
            title.TabIndex = 18;
            title.Text = "Parkin";
            // 
            // inValidPN
            // 
            inValidPN.AutoSize = true;
            inValidPN.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            inValidPN.ForeColor = Color.Red;
            inValidPN.Location = new Point(370, 273);
            inValidPN.Name = "inValidPN";
            inValidPN.Size = new Size(0, 20);
            inValidPN.TabIndex = 19;
            // 
            // invalidT
            // 
            invalidT.AutoSize = true;
            invalidT.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            invalidT.ForeColor = Color.Red;
            invalidT.Location = new Point(370, 355);
            invalidT.Name = "invalidT";
            invalidT.Size = new Size(0, 20);
            invalidT.TabIndex = 20;
            // 
            // inValidM
            // 
            inValidM.AutoSize = true;
            inValidM.Font = new Font("Cambria", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            inValidM.ForeColor = Color.Red;
            inValidM.Location = new Point(370, 441);
            inValidM.Name = "inValidM";
            inValidM.Size = new Size(0, 20);
            inValidM.TabIndex = 21;
            // 
            // invalid
            // 
            invalid.AutoSize = true;
            invalid.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invalid.ForeColor = Color.Lime;
            invalid.Location = new Point(421, 181);
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
            button3.Location = new Point(498, 650);
            button3.Name = "button3";
            button3.Size = new Size(96, 34);
            button3.TabIndex = 24;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 57);
            panel1.TabIndex = 25;
            // 
            // ParkingEntry
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 22, 71);
            ClientSize = new Size(986, 717);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(invalid);
            Controls.Add(inValidM);
            Controls.Add(invalidT);
            Controls.Add(inValidPN);
            Controls.Add(title);
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
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "ParkingEntry";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ParikingEntry";
            Load += ParkingEntry_Load;
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
    }
}