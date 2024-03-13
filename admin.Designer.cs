namespace Parking
{
    partial class admin
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
            panel1 = new Panel();
            button8 = new Button();
            panel3 = new Panel();
            selectType = new ComboBox();
            label7 = new Label();
            button2 = new Button();
            label2 = new Label();
            setBrandName = new TextBox();
            label6 = new Label();
            panel2 = new Panel();
            setAAPH = new NumericUpDown();
            setFlagDown = new NumericUpDown();
            label8 = new Label();
            button1 = new Button();
            setTypeName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            button7 = new Button();
            label13 = new Label();
            label9 = new Label();
            selectedItemType = new ComboBox();
            button3 = new Button();
            flowLayoutBrands = new FlowLayoutPanel();
            typeName = new TextBox();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            flagDown = new NumericUpDown();
            AAPH = new NumericUpDown();
            panel4 = new Panel();
            panel7 = new Panel();
            button9 = new Button();
            newBrand = new TextBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)setAAPH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)setFlagDown).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flagDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AAPH).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(131, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(1291, 308);
            panel1.TabIndex = 0;
            // 
            // button8
            // 
            button8.Location = new Point(1203, 19);
            button8.Name = "button8";
            button8.Size = new Size(71, 29);
            button8.TabIndex = 18;
            button8.Text = "refresh";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(22, 19, 75);
            panel3.Controls.Add(selectType);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(setBrandName);
            panel3.Location = new Point(3, 206);
            panel3.Name = "panel3";
            panel3.Size = new Size(1285, 69);
            panel3.TabIndex = 10;
            // 
            // selectType
            // 
            selectType.FormattingEnabled = true;
            selectType.Location = new Point(490, 19);
            selectType.Name = "selectType";
            selectType.Size = new Size(200, 28);
            selectType.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(397, 16);
            label7.Name = "label7";
            label7.Size = new Size(70, 31);
            label7.TabIndex = 10;
            label7.Text = "Type:";
            // 
            // button2
            // 
            button2.Location = new Point(1177, 22);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(19, 19);
            label2.Name = "label2";
            label2.Size = new Size(82, 31);
            label2.TabIndex = 0;
            label2.Text = "Name:";
            // 
            // setBrandName
            // 
            setBrandName.Location = new Point(107, 21);
            setBrandName.Name = "setBrandName";
            setBrandName.Size = new Size(207, 27);
            setBrandName.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 162);
            label6.Name = "label6";
            label6.Size = new Size(246, 31);
            label6.TabIndex = 10;
            label6.Text = "Create Vechicle Brand:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(22, 19, 75);
            panel2.Controls.Add(setAAPH);
            panel2.Controls.Add(setFlagDown);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(setTypeName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(1288, 69);
            panel2.TabIndex = 9;
            // 
            // setAAPH
            // 
            setAAPH.Location = new Point(1011, 25);
            setAAPH.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            setAAPH.Name = "setAAPH";
            setAAPH.Size = new Size(100, 27);
            setAAPH.TabIndex = 12;
            // 
            // setFlagDown
            // 
            setFlagDown.Location = new Point(502, 28);
            setFlagDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            setFlagDown.Name = "setFlagDown";
            setFlagDown.Size = new Size(100, 27);
            setFlagDown.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(663, 22);
            label8.Name = "label8";
            label8.Size = new Size(311, 31);
            label8.TabIndex = 11;
            label8.Text = "Additional amount per hour:";
            // 
            // button1
            // 
            button1.Location = new Point(1180, 21);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // setTypeName
            // 
            setTypeName.Location = new Point(110, 25);
            setTypeName.Name = "setTypeName";
            setTypeName.Size = new Size(207, 27);
            setTypeName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(363, 23);
            label3.Name = "label3";
            label3.Size = new Size(122, 31);
            label3.TabIndex = 7;
            label3.Text = "Flagdown:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 21);
            label4.Name = "label4";
            label4.Size = new Size(76, 31);
            label4.TabIndex = 8;
            label4.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(9, 5);
            label1.Name = "label1";
            label1.Size = new Size(234, 31);
            label1.TabIndex = 0;
            label1.Text = "Create Vechicle Type:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(22, 19, 75);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1342, 52);
            panel5.TabIndex = 11;
            panel5.Paint += panel5_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(11, 9);
            label5.Name = "label5";
            label5.Size = new Size(60, 31);
            label5.TabIndex = 11;
            label5.Text = "Edit:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(22, 19, 75);
            panel6.Controls.Add(button7);
            panel6.Controls.Add(label13);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(selectedItemType);
            panel6.Controls.Add(button3);
            panel6.Location = new Point(151, 81);
            panel6.Name = "panel6";
            panel6.Size = new Size(993, 52);
            panel6.TabIndex = 15;
            // 
            // button7
            // 
            button7.Location = new Point(375, 16);
            button7.Name = "button7";
            button7.Size = new Size(69, 29);
            button7.TabIndex = 17;
            button7.Text = "refresh";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.White;
            label13.Location = new Point(506, 8);
            label13.Name = "label13";
            label13.Size = new Size(149, 31);
            label13.TabIndex = 16;
            label13.Text = "Brand names";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(14, 14);
            label9.Name = "label9";
            label9.Size = new Size(70, 31);
            label9.TabIndex = 11;
            label9.Text = "Type:";
            // 
            // selectedItemType
            // 
            selectedItemType.FormattingEnabled = true;
            selectedItemType.Location = new Point(90, 14);
            selectedItemType.Name = "selectedItemType";
            selectedItemType.Size = new Size(167, 28);
            selectedItemType.TabIndex = 11;
            selectedItemType.SelectedIndexChanged += selectedItemType_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(272, 13);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 11;
            button3.Text = "Filter";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // flowLayoutBrands
            // 
            flowLayoutBrands.AutoScroll = true;
            flowLayoutBrands.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutBrands.Location = new Point(624, 213);
            flowLayoutBrands.Name = "flowLayoutBrands";
            flowLayoutBrands.Size = new Size(418, 251);
            flowLayoutBrands.TabIndex = 3;
            // 
            // typeName
            // 
            typeName.Location = new Point(236, 213);
            typeName.Name = "typeName";
            typeName.Size = new Size(207, 27);
            typeName.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(160, 213);
            label10.Name = "label10";
            label10.Size = new Size(70, 31);
            label10.TabIndex = 16;
            label10.Text = "Type:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(210, 265);
            label12.Name = "label12";
            label12.Size = new Size(122, 31);
            label12.TabIndex = 18;
            label12.Text = "Flagdown:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(21, 318);
            label11.Name = "label11";
            label11.Size = new Size(311, 31);
            label11.TabIndex = 20;
            label11.Text = "Additional amount per hour:";
            // 
            // flagDown
            // 
            flagDown.Location = new Point(338, 269);
            flagDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            flagDown.Name = "flagDown";
            flagDown.Size = new Size(100, 27);
            flagDown.TabIndex = 19;
            // 
            // AAPH
            // 
            AAPH.Location = new Point(338, 325);
            AAPH.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            AAPH.Name = "AAPH";
            AAPH.Size = new Size(100, 27);
            AAPH.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(button6);
            panel4.Controls.Add(button5);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(AAPH);
            panel4.Controls.Add(flagDown);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(typeName);
            panel4.Controls.Add(flowLayoutBrands);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(107, 373);
            panel4.Name = "panel4";
            panel4.Size = new Size(1348, 587);
            panel4.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Controls.Add(button9);
            panel7.Controls.Add(newBrand);
            panel7.Location = new Point(624, 159);
            panel7.Name = "panel7";
            panel7.Size = new Size(418, 51);
            panel7.TabIndex = 24;
            // 
            // button9
            // 
            button9.Location = new Point(357, 22);
            button9.Name = "button9";
            button9.Size = new Size(58, 29);
            button9.TabIndex = 1;
            button9.Text = "Add";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // newBrand
            // 
            newBrand.Location = new Point(149, 23);
            newBrand.Name = "newBrand";
            newBrand.Size = new Size(202, 27);
            newBrand.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(449, 325);
            button6.Name = "button6";
            button6.Size = new Size(100, 29);
            button6.TabIndex = 23;
            button6.Text = "Save";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(449, 269);
            button5.Name = "button5";
            button5.Size = new Size(100, 29);
            button5.TabIndex = 22;
            button5.Text = "Save";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(449, 213);
            button4.Name = "button4";
            button4.Size = new Size(100, 29);
            button4.TabIndex = 17;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 19, 64);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Name = "admin";
            Size = new Size(1533, 982);
            Load += admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)setAAPH).EndInit();
            ((System.ComponentModel.ISupportInitialize)setFlagDown).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)flagDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AAPH).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label3;
        private Button button1;
        private TextBox setTypeName;
        private Label label1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel3;
        private ComboBox selectType;
        private Button button2;
        private Label label2;
        private TextBox setBrandName;
        private NumericUpDown setAAPH;
        private NumericUpDown setFlagDown;
        private Panel panel5;
        private Label label5;
        private Panel panel6;
        private Label label13;
        private Label label9;
        private ComboBox selectedItemType;
        private Button button3;
        private FlowLayoutPanel flowLayoutBrands;
        private TextBox typeName;
        private Label label10;
        private Label label12;
        private Label label11;
        private NumericUpDown flagDown;
        private NumericUpDown AAPH;
        private Panel panel4;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button7;
        private Button button8;
        private Panel panel7;
        private Button button9;
        private TextBox newBrand;
    }
}
