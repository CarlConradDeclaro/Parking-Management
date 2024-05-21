namespace Parking
{
    partial class History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(History));
            label1 = new Label();
            flowPanelHistory = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            searchVH = new TextBox();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            colorDialog1 = new ColorDialog();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(593, 23);
            label1.Name = "label1";
            label1.Size = new Size(178, 28);
            label1.TabIndex = 0;
            label1.Text = "Transaction History";
            // 
            // flowPanelHistory
            // 
            flowPanelHistory.AutoScroll = true;
            flowPanelHistory.Location = new Point(0, 3);
            flowPanelHistory.Name = "flowPanelHistory";
            flowPanelHistory.Size = new Size(1352, 755);
            flowPanelHistory.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.Controls.Add(flowPanelHistory);
            panel1.Location = new Point(37, 207);
            panel1.Name = "panel1";
            panel1.Size = new Size(1363, 761);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top;
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(searchVH);
            panel2.Location = new Point(833, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 68);
            panel2.TabIndex = 3;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(482, 21);
            button2.Name = "button2";
            button2.Size = new Size(64, 29);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(412, 21);
            button3.Name = "button3";
            button3.Size = new Size(64, 29);
            button3.TabIndex = 5;
            button3.Text = "All";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(312, 13);
            button1.Name = "button1";
            button1.Size = new Size(48, 44);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // searchVH
            // 
            searchVH.BackColor = Color.FromArgb(22, 19, 64);
            searchVH.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchVH.ForeColor = Color.White;
            searchVH.Location = new Point(57, 18);
            searchVH.Name = "searchVH";
            searchVH.PlaceholderText = "Enter Plate No.";
            searchVH.Size = new Size(249, 34);
            searchVH.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(37, 137);
            panel3.Name = "panel3";
            panel3.Size = new Size(1357, 57);
            panel3.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(1073, 22);
            label8.Name = "label8";
            label8.Size = new Size(83, 23);
            label8.TabIndex = 6;
            label8.Text = "Amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(952, 22);
            label7.Name = "label7";
            label7.Size = new Size(88, 23);
            label7.TabIndex = 5;
            label7.Text = "Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(721, 22);
            label6.Name = "label6";
            label6.Size = new Size(179, 23);
            label6.TabIndex = 4;
            label6.Text = "Parkout DateTime";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(541, 22);
            label5.Name = "label5";
            label5.Size = new Size(169, 23);
            label5.TabIndex = 3;
            label5.Text = "Arrival DateTime";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(356, 22);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 2;
            label4.Text = "Brand";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(174, 22);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 1;
            label3.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 22);
            label2.Name = "label2";
            label2.Size = new Size(91, 23);
            label2.TabIndex = 0;
            label2.Text = "Plate No.";
            // 
            // panel4
            // 
            panel4.Location = new Point(50, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(10, 35);
            panel4.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Location = new Point(54, 10);
            panel5.Name = "panel5";
            panel5.Size = new Size(258, 10);
            panel5.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.Location = new Point(304, 17);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 35);
            panel6.TabIndex = 6;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 19, 64);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            Name = "History";
            Size = new Size(1416, 982);
            Load += History_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowPanelHistory;
        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button1;
        private TextBox searchVH;
        private Panel panel3;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ColorDialog colorDialog1;
        private Button button2;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
    }
}
