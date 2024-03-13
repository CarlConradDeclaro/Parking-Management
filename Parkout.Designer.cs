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
            panel2 = new Panel();
            button1 = new Button();
            button4 = new Button();
            button2 = new Button();
            listOfVehicle = new FlowLayoutPanel();
            panel1 = new Panel();
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
            seeAll = new Button();
            button3 = new Button();
            searchVHTxt = new TextBox();
            flowPanelVH = new FlowLayoutPanel();
            flowPanel = new Panel();
            label3 = new Label();
            invalidD = new Label();
            invalidT = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            flowPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(143, 464);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 56);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(127, 3);
            button1.Name = "button1";
            button1.Size = new Size(103, 43);
            button1.TabIndex = 0;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ButtonFace;
            button4.Font = new Font("Segoe UI", 13.8F);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(236, 3);
            button4.Name = "button4";
            button4.Size = new Size(102, 43);
            button4.TabIndex = 11;
            button4.Text = "Pay";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(18, 4);
            button2.Name = "button2";
            button2.Size = new Size(103, 40);
            button2.TabIndex = 6;
            button2.Text = "Close";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // listOfVehicle
            // 
            listOfVehicle.AutoScroll = true;
            listOfVehicle.BorderStyle = BorderStyle.FixedSingle;
            listOfVehicle.Location = new Point(24, 100);
            listOfVehicle.Name = "listOfVehicle";
            listOfVehicle.Size = new Size(998, 106);
            listOfVehicle.TabIndex = 3;
            listOfVehicle.Paint += listOfVehicle_Paint;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
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
            panel1.Location = new Point(510, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 544);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint_1;
            // 
            // setHours
            // 
            setHours.AutoSize = true;
            setHours.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            setHours.ForeColor = Color.FromArgb(192, 0, 0);
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
            setStatus.ForeColor = Color.FromArgb(192, 0, 0);
            setStatus.Location = new Point(244, 142);
            setStatus.Name = "setStatus";
            setStatus.Size = new Size(0, 23);
            setStatus.TabIndex = 8;
            // 
            // parkOutDate
            // 
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
            label5.Size = new Size(103, 27);
            label5.TabIndex = 4;
            label5.Text = "Changed:";
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
            label1.Size = new Size(168, 31);
            label1.TabIndex = 1;
            label1.Text = "Entert Amount:";
            // 
            // enterAmt
            // 
            enterAmt.BackColor = Color.Black;
            enterAmt.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterAmt.ForeColor = Color.Lime;
            enterAmt.Location = new Point(203, 371);
            enterAmt.Name = "enterAmt";
            enterAmt.Size = new Size(274, 61);
            enterAmt.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(seeAll);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(searchVHTxt);
            panel3.Location = new Point(24, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(999, 82);
            panel3.TabIndex = 5;
            // 
            // seeAll
            // 
            seeAll.BackColor = SystemColors.ButtonFace;
            seeAll.ForeColor = Color.Black;
            seeAll.Location = new Point(465, 42);
            seeAll.Name = "seeAll";
            seeAll.Size = new Size(74, 37);
            seeAll.TabIndex = 2;
            seeAll.Text = "see all";
            seeAll.UseVisualStyleBackColor = false;
            seeAll.Click += seeAll_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(363, 45);
            button3.Name = "button3";
            button3.Size = new Size(96, 34);
            button3.TabIndex = 1;
            button3.Text = "SEARCH";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // searchVHTxt
            // 
            searchVHTxt.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchVHTxt.Location = new Point(2, 45);
            searchVHTxt.Name = "searchVHTxt";
            searchVHTxt.PlaceholderText = "ENTER PLATE NO.";
            searchVHTxt.Size = new Size(349, 34);
            searchVHTxt.TabIndex = 0;
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
            flowPanel.BorderStyle = BorderStyle.FixedSingle;
            flowPanel.Controls.Add(flowPanelVH);
            flowPanel.Location = new Point(10, 235);
            flowPanel.Name = "flowPanel";
            flowPanel.Size = new Size(494, 534);
            flowPanel.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(36, 219);
            label3.Name = "label3";
            label3.Size = new Size(165, 31);
            label3.TabIndex = 10;
            label3.Text = "Vehicle Details";
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
            // invalidT
            // 
            invalidT.AutoSize = true;
            invalidT.ForeColor = Color.Red;
            invalidT.Location = new Point(207, 284);
            invalidT.Name = "invalidT";
            invalidT.Size = new Size(0, 20);
            invalidT.TabIndex = 17;
            // 
            // Parkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 10, 75);
            ClientSize = new Size(1026, 777);
            Controls.Add(label3);
            Controls.Add(flowPanel);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(listOfVehicle);
            ForeColor = Color.White;
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
    }
}