namespace Parking
{
    partial class Parkout
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
            Button button4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parkout));
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            listOfVehicle = new FlowLayoutPanel();
            panel1 = new Panel();
            invalidT = new Label();
            invalidD = new Label();
            setHours = new Label();
            label11 = new Label();
            button5 = new Button();
            label6 = new Label();
            label9 = new Label();
            parkOutTime = new DateTimePicker();
            setStatus = new Label();
            parkOutDate = new DateTimePicker();
            label7 = new Label();
            setChange = new Label();
            label5 = new Label();
            setAmt = new Label();
            label2 = new Label();
            label1 = new Label();
            enterAmt = new TextBox();
            panel3 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel4 = new Panel();
            seeAll = new Button();
            button3 = new Button();
            searchVHTxt = new TextBox();
            button6 = new Button();
            flowPanelVH = new FlowLayoutPanel();
            flowPanel = new Panel();
            label3 = new Label();
            panel7 = new Panel();
            title = new Label();
            button4 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            flowPanel.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(22, 10, 100);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.8F);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(232, 3);
            button4.Name = "button4";
            button4.Size = new Size(102, 43);
            button4.TabIndex = 11;
            button4.Text = "    Pay";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(172, 468);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 50);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(22, 10, 100);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(129, 3);
            button1.Name = "button1";
            button1.Size = new Size(108, 43);
            button1.TabIndex = 0;
            button1.Text = "    Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(22, 10, 100);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.ForeColor = Color.Transparent;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(9, 4);
            button2.Name = "button2";
            button2.Size = new Size(118, 40);
            button2.TabIndex = 6;
            button2.Text = "     Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // listOfVehicle
            // 
            listOfVehicle.AutoScroll = true;
            listOfVehicle.BackColor = Color.FromArgb(22, 10, 95);
            listOfVehicle.Location = new Point(16, 111);
            listOfVehicle.Name = "listOfVehicle";
            listOfVehicle.Size = new Size(1001, 106);
            listOfVehicle.TabIndex = 3;
            listOfVehicle.Paint += listOfVehicle_Paint;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.FromArgb(22, 10, 95);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(invalidT);
            panel1.Controls.Add(invalidD);
            panel1.Controls.Add(setHours);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(parkOutTime);
            panel1.Controls.Add(setStatus);
            panel1.Controls.Add(parkOutDate);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(setChange);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(setAmt);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(enterAmt);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(512, 236);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 544);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint_1;
            // 
            // invalidT
            // 
            invalidT.AutoSize = true;
            invalidT.ForeColor = Color.Red;
            invalidT.Location = new Point(207, 284);
            invalidT.Name = "invalidT";
            invalidT.Size = new Size(0, 20);
            invalidT.TabIndex = 17;
            // 
            // invalidD
            // 
            invalidD.AutoSize = true;
            invalidD.ForeColor = Color.Red;
            invalidD.Location = new Point(207, 225);
            invalidD.Name = "invalidD";
            invalidD.Size = new Size(0, 20);
            invalidD.TabIndex = 16;
            // 
            // setHours
            // 
            setHours.AutoSize = true;
            setHours.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setHours.ForeColor = Color.White;
            setHours.Location = new Point(244, 196);
            setHours.Name = "setHours";
            setHours.Size = new Size(0, 23);
            setHours.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(110, 192);
            label11.Name = "label11";
            label11.Size = new Size(90, 27);
            label11.TabIndex = 14;
            label11.Text = "Hour/s:";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ButtonFace;
            button5.Cursor = Cursors.Hand;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(383, 307);
            button5.Name = "button5";
            button5.Size = new Size(94, 41);
            button5.TabIndex = 11;
            button5.Text = "Set";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(11, 306);
            label6.Name = "label6";
            label6.Size = new Size(190, 27);
            label6.TabIndex = 10;
            label6.Text = "Set ParkOut Time:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(11, 250);
            label9.Name = "label9";
            label9.Size = new Size(185, 27);
            label9.TabIndex = 13;
            label9.Text = "Set ParkOut Date:";
            // 
            // parkOutTime
            // 
            parkOutTime.Cursor = Cursors.Hand;
            parkOutTime.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkOutTime.Format = DateTimePickerFormat.Time;
            parkOutTime.Location = new Point(207, 307);
            parkOutTime.Name = "parkOutTime";
            parkOutTime.Size = new Size(167, 38);
            parkOutTime.TabIndex = 9;
            // 
            // setStatus
            // 
            setStatus.AutoSize = true;
            setStatus.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setStatus.ForeColor = Color.Red;
            setStatus.Location = new Point(244, 142);
            setStatus.Name = "setStatus";
            setStatus.Size = new Size(0, 23);
            setStatus.TabIndex = 8;
            // 
            // parkOutDate
            // 
            parkOutDate.Cursor = Cursors.Hand;
            parkOutDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parkOutDate.Location = new Point(207, 248);
            parkOutDate.Name = "parkOutDate";
            parkOutDate.Size = new Size(271, 30);
            parkOutDate.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(120, 138);
            label7.Name = "label7";
            label7.Size = new Size(79, 27);
            label7.TabIndex = 7;
            label7.Text = "Status:";
            // 
            // setChange
            // 
            setChange.AutoSize = true;
            setChange.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setChange.Location = new Point(254, 81);
            setChange.Name = "setChange";
            setChange.Size = new Size(0, 23);
            setChange.TabIndex = 5;
            setChange.Click += change_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 77);
            label5.Name = "label5";
            label5.Size = new Size(90, 27);
            label5.TabIndex = 4;
            label5.Text = "Change:";
            // 
            // setAmt
            // 
            setAmt.AutoSize = true;
            setAmt.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            setAmt.ForeColor = Color.Lime;
            setAmt.Location = new Point(254, 18);
            setAmt.Name = "setAmt";
            setAmt.Size = new Size(0, 27);
            setAmt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 18);
            label2.Name = "label2";
            label2.Size = new Size(166, 28);
            label2.TabIndex = 2;
            label2.Text = "TOTAL AMOUNT:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 392);
            label1.Name = "label1";
            label1.Size = new Size(160, 31);
            label1.TabIndex = 1;
            label1.Text = "Enter Amount:";
            // 
            // enterAmt
            // 
            enterAmt.BackColor = Color.Black;
            enterAmt.BorderStyle = BorderStyle.None;
            enterAmt.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterAmt.ForeColor = Color.Lime;
            enterAmt.Location = new Point(203, 371);
            enterAmt.Name = "enterAmt";
            enterAmt.Size = new Size(274, 54);
            enterAmt.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(22, 10, 95);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(seeAll);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(searchVHTxt);
            panel3.Location = new Point(14, 43);
            panel3.Name = "panel3";
            panel3.Size = new Size(1006, 62);
            panel3.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.Location = new Point(11, 11);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 40);
            panel5.TabIndex = 11;
            // 
            // panel6
            // 
            panel6.Location = new Point(364, 11);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 40);
            panel6.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.Location = new Point(17, 9);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 10);
            panel4.TabIndex = 3;
            // 
            // seeAll
            // 
            seeAll.BackColor = Color.FromArgb(22, 10, 110);
            seeAll.FlatAppearance.BorderSize = 0;
            seeAll.FlatStyle = FlatStyle.Flat;
            seeAll.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seeAll.ForeColor = Color.White;
            seeAll.Location = new Point(422, 16);
            seeAll.Name = "seeAll";
            seeAll.Size = new Size(53, 37);
            seeAll.TabIndex = 2;
            seeAll.Text = "All";
            seeAll.UseVisualStyleBackColor = false;
            seeAll.Click += seeAll_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(22, 10, 110);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(373, 15);
            button3.Name = "button3";
            button3.Size = new Size(48, 39);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // searchVHTxt
            // 
            searchVHTxt.BackColor = Color.FromArgb(22, 10, 95);
            searchVHTxt.CharacterCasing = CharacterCasing.Upper;
            searchVHTxt.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchVHTxt.ForeColor = Color.White;
            searchVHTxt.Location = new Point(18, 17);
            searchVHTxt.Name = "searchVHTxt";
            searchVHTxt.PlaceholderText = " ENTER PLATE NO.";
            searchVHTxt.Size = new Size(349, 34);
            searchVHTxt.TabIndex = 0;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(22, 10, 95);
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 13.8F);
            button6.ForeColor = Color.Transparent;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(993, -4);
            button6.Name = "button6";
            button6.Size = new Size(40, 40);
            button6.TabIndex = 12;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // flowPanelVH
            // 
            flowPanelVH.Location = new Point(-1, 17);
            flowPanelVH.Name = "flowPanelVH";
            flowPanelVH.Size = new Size(492, 504);
            flowPanelVH.TabIndex = 8;
            // 
            // flowPanel
            // 
            flowPanel.BackColor = Color.FromArgb(22, 10, 95);
            flowPanel.Controls.Add(flowPanelVH);
            flowPanel.Location = new Point(10, 238);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(494, 542);
            flowPanel.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 222);
            label3.Name = "label3";
            label3.Size = new Size(165, 31);
            label3.TabIndex = 10;
            label3.Text = "Vehicle Details";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(22, 10, 95);
            panel7.Controls.Add(title);
            panel7.Controls.Add(button6);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(1035, 36);
            panel7.TabIndex = 13;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("NSimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(0, 4);
            title.Name = "title";
            title.Size = new Size(101, 23);
            title.TabIndex = 19;
            title.Text = "Parkout";
            // 
            // Parkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 22, 120);
            ClientSize = new Size(1035, 789);
            Controls.Add(panel7);
            Controls.Add(label3);
            Controls.Add(flowPanel);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(listOfVehicle);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Parkout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parkout";
            Load += Parkout_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            flowPanel.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button button1;
        private FlowLayoutPanel listOfVehicle;
        private Panel panel1;
        private Panel panel3;
        private Button button3;
        private TextBox searchVHTxt;
        private Label label1;
        private FlowLayoutPanel flowPanelVH;
        private Panel flowPanel;
        private Label label3;
        private TextBox enterAmt;
        private Button button4;
        private Button button2;
        private Label setStatus;
        private Label label7;
        private Label setChange;
        private Label label5;
        private Label setAmt;
        private Label label2;
        private Button seeAll;
        private Button button5;
        private Label label6;
        private DateTimePicker parkOutTime;
        private Label label9;
        private DateTimePicker parkOutDate;
        private Label setHours;
        private Label label11;
        private Label invalidT;
        private Label invalidD;
        private Panel panel4;
        private Panel panel6;
        private Panel panel5;
        private Button button6;
        private Panel panel7;
        private Label title;
    }
}