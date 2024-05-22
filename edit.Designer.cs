namespace Parking
{
    partial class edit
    {
     
        private System.ComponentModel.IContainer components = null;
  
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit));
            label1 = new Label();
            plateValue = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            driverValue = new TextBox();
            label4 = new Label();
            phoneValue = new TextBox();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            typeValue = new ComboBox();
            brandValue = new ComboBox();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            errorPlateNum = new Label();
            erroDriveName = new Label();
            erroPhoneNum = new Label();
            errorType = new Label();
            errorBrand = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("NSimSun", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 121);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Plate No:";
            label1.Click += label1_Click;
            // 
            // plateValue
            // 
            plateValue.BackColor = Color.FromArgb(26, 22, 71);
            plateValue.CharacterCasing = CharacterCasing.Upper;
            plateValue.Font = new Font("NSimSun", 12F);
            plateValue.ForeColor = Color.White;
            plateValue.Location = new Point(142, 120);
            plateValue.Name = "plateValue";
            plateValue.Size = new Size(314, 30);
            plateValue.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("NSimSun", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 202);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 2;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("NSimSun", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 291);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Brand:";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(26, 22, 71);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(220, 518);
            button1.Name = "button1";
            button1.Size = new Size(123, 34);
            button1.TabIndex = 6;
            button1.Text = "        Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(26, 22, 71);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(351, 517);
            button2.Name = "button2";
            button2.Size = new Size(118, 34);
            button2.TabIndex = 7;
            button2.Text = "        Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // driverValue
            // 
            driverValue.BackColor = Color.FromArgb(26, 22, 71);
            driverValue.Font = new Font("NSimSun", 12F);
            driverValue.ForeColor = Color.White;
            driverValue.Location = new Point(142, 379);
            driverValue.Name = "driverValue";
            driverValue.Size = new Size(314, 30);
            driverValue.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("NSimSun", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 383);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 8;
            label4.Text = "Driver:";
            // 
            // phoneValue
            // 
            phoneValue.BackColor = Color.FromArgb(26, 22, 71);
            phoneValue.Font = new Font("NSimSun", 12F);
            phoneValue.ForeColor = Color.White;
            phoneValue.Location = new Point(142, 459);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(314, 30);
            phoneValue.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("NSimSun", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 462);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 10;
            label5.Text = "Phone No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(196, 42);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 12;
            label6.Text = "Edit Vehicle*";
            // 
            // panel1
            // 
            panel1.Location = new Point(135, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(12, 27);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Location = new Point(452, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(12, 27);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Location = new Point(135, 113);
            panel3.Name = "panel3";
            panel3.Size = new Size(333, 10);
            panel3.TabIndex = 15;
            // 
            // panel10
            // 
            panel10.Location = new Point(132, 379);
            panel10.Name = "panel10";
            panel10.Size = new Size(12, 27);
            panel10.TabIndex = 16;
            // 
            // panel11
            // 
            panel11.Location = new Point(452, 370);
            panel11.Name = "panel11";
            panel11.Size = new Size(16, 37);
            panel11.TabIndex = 17;
            // 
            // panel12
            // 
            panel12.Location = new Point(132, 371);
            panel12.Name = "panel12";
            panel12.Size = new Size(333, 10);
            panel12.TabIndex = 18;
            // 
            // panel13
            // 
            panel13.Location = new Point(132, 451);
            panel13.Name = "panel13";
            panel13.Size = new Size(333, 10);
            panel13.TabIndex = 19;
            // 
            // panel14
            // 
            panel14.Location = new Point(136, 461);
            panel14.Name = "panel14";
            panel14.Size = new Size(12, 27);
            panel14.TabIndex = 17;
            // 
            // panel15
            // 
            panel15.Location = new Point(451, 450);
            panel15.Name = "panel15";
            panel15.Size = new Size(12, 40);
            panel15.TabIndex = 17;
            // 
            // typeValue
            // 
            typeValue.BackColor = Color.FromArgb(26, 22, 71);
            typeValue.DropDownStyle = ComboBoxStyle.DropDownList;
            typeValue.FlatStyle = FlatStyle.Flat;
            typeValue.Font = new Font("NSimSun", 12F);
            typeValue.ForeColor = Color.White;
            typeValue.FormattingEnabled = true;
            typeValue.Location = new Point(148, 201);
            typeValue.Name = "typeValue";
            typeValue.Size = new Size(308, 28);
            typeValue.TabIndex = 20;
            typeValue.SelectedIndexChanged += typeValue_SelectedIndexChanged;
            // 
            // brandValue
            // 
            brandValue.BackColor = Color.FromArgb(26, 22, 71);
            brandValue.DropDownStyle = ComboBoxStyle.DropDownList;
            brandValue.FlatStyle = FlatStyle.Flat;
            brandValue.Font = new Font("NSimSun", 12F);
            brandValue.ForeColor = Color.White;
            brandValue.FormattingEnabled = true;
            brandValue.Location = new Point(146, 290);
            brandValue.Name = "brandValue";
            brandValue.Size = new Size(312, 28);
            brandValue.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.Location = new Point(137, 201);
            panel4.Name = "panel4";
            panel4.Size = new Size(12, 27);
            panel4.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.Location = new Point(135, 192);
            panel5.Name = "panel5";
            panel5.Size = new Size(333, 10);
            panel5.TabIndex = 16;
            // 
            // panel6
            // 
            panel6.Location = new Point(135, 290);
            panel6.Name = "panel6";
            panel6.Size = new Size(12, 27);
            panel6.TabIndex = 15;
            // 
            // panel7
            // 
            panel7.Location = new Point(136, 283);
            panel7.Name = "panel7";
            panel7.Size = new Size(333, 10);
            panel7.TabIndex = 17;
            // 
            // errorPlateNum
            // 
            errorPlateNum.AutoSize = true;
            errorPlateNum.ForeColor = Color.Red;
            errorPlateNum.Location = new Point(142, 150);
            errorPlateNum.Name = "errorPlateNum";
            errorPlateNum.Size = new Size(0, 20);
            errorPlateNum.TabIndex = 22;
            // 
            // erroDriveName
            // 
            erroDriveName.AutoSize = true;
            erroDriveName.ForeColor = Color.Red;
            erroDriveName.Location = new Point(142, 410);
            erroDriveName.Name = "erroDriveName";
            erroDriveName.Size = new Size(0, 20);
            erroDriveName.TabIndex = 23;
            // 
            // erroPhoneNum
            // 
            erroPhoneNum.AutoSize = true;
            erroPhoneNum.ForeColor = Color.Red;
            erroPhoneNum.Location = new Point(143, 490);
            erroPhoneNum.Name = "erroPhoneNum";
            erroPhoneNum.Size = new Size(0, 20);
            erroPhoneNum.TabIndex = 24;
            // 
            // errorType
            // 
            errorType.AutoSize = true;
            errorType.ForeColor = Color.Red;
            errorType.Location = new Point(146, 231);
            errorType.Name = "errorType";
            errorType.Size = new Size(0, 20);
            errorType.TabIndex = 25;
            // 
            // errorBrand
            // 
            errorBrand.AutoSize = true;
            errorBrand.ForeColor = Color.Red;
            errorBrand.Location = new Point(146, 323);
            errorBrand.Name = "errorBrand";
            errorBrand.Size = new Size(0, 20);
            errorBrand.TabIndex = 26;
            // 
            // edit
            // 
            AccessibleRole = AccessibleRole.MenuBar;
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 22, 71);
            ClientSize = new Size(486, 563);
            ControlBox = false;
            Controls.Add(errorBrand);
            Controls.Add(errorType);
            Controls.Add(erroPhoneNum);
            Controls.Add(erroDriveName);
            Controls.Add(errorPlateNum);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(brandValue);
            Controls.Add(typeValue);
            Controls.Add(panel15);
            Controls.Add(panel14);
            Controls.Add(panel13);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(phoneValue);
            Controls.Add(label5);
            Controls.Add(driverValue);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(plateValue);
            Controls.Add(label1);
            Font = new Font("NSimSun", 12F);
            Name = "edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "edit";
            Load += edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox plateValue;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox driverValue;
        private Label label4;
        private TextBox phoneValue;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
        private ComboBox typeValue;
        private ComboBox brandValue;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Label errorPlateNum;
        private Label erroDriveName;
        private Label erroPhoneNum;
        private Label errorType;
        private Label errorBrand;
    }
}