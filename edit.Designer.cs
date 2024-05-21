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
            typeValue = new TextBox();
            label2 = new Label();
            brandValue = new TextBox();
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
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            panel13 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 111);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 0;
            label1.Text = "Plate No:";
            label1.Click += label1_Click;
            // 
            // plateValue
            // 
            plateValue.BackColor = Color.FromArgb(26, 22, 71);
            plateValue.Font = new Font("NSimSun", 12F);
            plateValue.ForeColor = Color.White;
            plateValue.Location = new Point(125, 111);
            plateValue.Name = "plateValue";
            plateValue.Size = new Size(252, 30);
            plateValue.TabIndex = 1;
            // 
            // typeValue
            // 
            typeValue.BackColor = Color.FromArgb(26, 22, 71);
            typeValue.Font = new Font("NSimSun", 12F);
            typeValue.ForeColor = Color.White;
            typeValue.Location = new Point(125, 191);
            typeValue.Name = "typeValue";
            typeValue.Size = new Size(252, 30);
            typeValue.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(50, 191);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 2;
            label2.Text = "Type:";
            // 
            // brandValue
            // 
            brandValue.BackColor = Color.FromArgb(26, 22, 71);
            brandValue.Font = new Font("NSimSun", 12F);
            brandValue.ForeColor = Color.White;
            brandValue.Location = new Point(125, 280);
            brandValue.Name = "brandValue";
            brandValue.Size = new Size(252, 30);
            brandValue.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 280);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 4;
            label3.Text = "Brand:";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(127, 545);
            button1.Name = "button1";
            button1.Size = new Size(99, 34);
            button1.TabIndex = 6;
            button1.Text = "        Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(254, 545);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
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
            driverValue.Location = new Point(125, 370);
            driverValue.Name = "driverValue";
            driverValue.Size = new Size(252, 30);
            driverValue.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 370);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 8;
            label4.Text = "Driver:";
            // 
            // phoneValue
            // 
            phoneValue.BackColor = Color.FromArgb(26, 22, 71);
            phoneValue.Font = new Font("NSimSun", 12F);
            phoneValue.ForeColor = Color.White;
            phoneValue.Location = new Point(125, 450);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(252, 30);
            phoneValue.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(8, 450);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 10;
            label5.Text = "Phone No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(190, 51);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 12;
            label6.Text = "Edit Vehicle*";
            // 
            // panel1
            // 
            panel1.Location = new Point(118, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 27);
            panel1.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.Location = new Point(373, 112);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 27);
            panel2.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Location = new Point(118, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 10);
            panel3.TabIndex = 15;
            // 
            // panel4
            // 
            panel4.Location = new Point(119, 193);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 27);
            panel4.TabIndex = 14;
            // 
            // panel5
            // 
            panel5.Location = new Point(116, 183);
            panel5.Name = "panel5";
            panel5.Size = new Size(267, 10);
            panel5.TabIndex = 16;
            // 
            // panel6
            // 
            panel6.Location = new Point(373, 183);
            panel6.Name = "panel6";
            panel6.Size = new Size(12, 38);
            panel6.TabIndex = 15;
            // 
            // panel7
            // 
            panel7.Location = new Point(117, 280);
            panel7.Name = "panel7";
            panel7.Size = new Size(10, 27);
            panel7.TabIndex = 15;
            // 
            // panel8
            // 
            panel8.Location = new Point(373, 272);
            panel8.Name = "panel8";
            panel8.Size = new Size(12, 38);
            panel8.TabIndex = 16;
            // 
            // panel9
            // 
            panel9.Location = new Point(115, 272);
            panel9.Name = "panel9";
            panel9.Size = new Size(267, 10);
            panel9.TabIndex = 17;
            // 
            // panel10
            // 
            panel10.Location = new Point(117, 370);
            panel10.Name = "panel10";
            panel10.Size = new Size(10, 27);
            panel10.TabIndex = 16;
            // 
            // panel11
            // 
            panel11.Location = new Point(373, 362);
            panel11.Name = "panel11";
            panel11.Size = new Size(12, 38);
            panel11.TabIndex = 17;
            // 
            // panel12
            // 
            panel12.Location = new Point(117, 362);
            panel12.Name = "panel12";
            panel12.Size = new Size(267, 10);
            panel12.TabIndex = 18;
            // 
            // panel13
            // 
            panel13.Location = new Point(117, 442);
            panel13.Name = "panel13";
            panel13.Size = new Size(267, 10);
            panel13.TabIndex = 19;
            // 
            // panel14
            // 
            panel14.Location = new Point(119, 452);
            panel14.Name = "panel14";
            panel14.Size = new Size(10, 27);
            panel14.TabIndex = 17;
            // 
            // panel15
            // 
            panel15.Location = new Point(372, 442);
            panel15.Name = "panel15";
            panel15.Size = new Size(10, 40);
            panel15.TabIndex = 17;
            // 
            // edit
            // 
            AccessibleRole = AccessibleRole.MenuBar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 22, 71);
            ClientSize = new Size(411, 601);
            ControlBox = false;
            Controls.Add(panel15);
            Controls.Add(panel14);
            Controls.Add(panel13);
            Controls.Add(panel12);
            Controls.Add(panel11);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
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
            Controls.Add(brandValue);
            Controls.Add(label3);
            Controls.Add(typeValue);
            Controls.Add(label2);
            Controls.Add(plateValue);
            Controls.Add(label1);
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
        private TextBox typeValue;
        private Label label2;
        private TextBox brandValue;
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
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Panel panel11;
        private Panel panel12;
        private Panel panel13;
        private Panel panel14;
        private Panel panel15;
    }
}