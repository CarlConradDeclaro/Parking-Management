namespace Parking
{
    partial class LoadingState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingState));
            loadingLabel = new Label();
            loadingTimer = new System.Windows.Forms.Timer(components);
            containerLoading = new Panel();
            panelLoading = new Panel();
            panel1 = new Panel();
            panel12 = new Panel();
            panel11 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            textAnimationTimer = new System.Windows.Forms.Timer(components);
            panel13 = new Panel();
            percentageLabel = new Label();
            panel14 = new Panel();
            containerLoading.SuspendLayout();
            panelLoading.SuspendLayout();
            SuspendLayout();
            // 
            // loadingLabel
            // 
            loadingLabel.AutoSize = true;
            loadingLabel.Font = new Font("NSimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loadingLabel.ForeColor = Color.White;
            loadingLabel.Location = new Point(348, 414);
            loadingLabel.Name = "loadingLabel";
            loadingLabel.Size = new Size(195, 34);
            loadingLabel.TabIndex = 0;
            loadingLabel.Text = "Loading...";
            // 
            // loadingTimer
            // 
            loadingTimer.Enabled = true;
            loadingTimer.Interval = 15;
            loadingTimer.Tick += loadingTimer_Tick;
            // 
            // containerLoading
            // 
            containerLoading.BorderStyle = BorderStyle.Fixed3D;
            containerLoading.Controls.Add(panelLoading);
            containerLoading.Location = new Point(-6, 451);
            containerLoading.Name = "containerLoading";
            containerLoading.Size = new Size(859, 67);
            containerLoading.TabIndex = 1;
            // 
            // panelLoading
            // 
            panelLoading.BackColor = Color.Transparent;
            panelLoading.Controls.Add(panel1);
            panelLoading.Controls.Add(panel12);
            panelLoading.Controls.Add(panel11);
            panelLoading.Controls.Add(panel10);
            panelLoading.Controls.Add(panel9);
            panelLoading.Controls.Add(panel8);
            panelLoading.Controls.Add(panel7);
            panelLoading.Controls.Add(panel6);
            panelLoading.Controls.Add(panel5);
            panelLoading.Controls.Add(panel4);
            panelLoading.Controls.Add(panel3);
            panelLoading.Controls.Add(panel2);
            panelLoading.Location = new Point(-1, 3);
            panelLoading.Name = "panelLoading";
            panelLoading.Size = new Size(103, 57);
            panelLoading.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(-5, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(108, 48);
            panel1.TabIndex = 4;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(224, 224, 224);
            panel12.Location = new Point(801, 26);
            panel12.Name = "panel12";
            panel12.Size = new Size(46, 10);
            panel12.TabIndex = 6;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(224, 224, 224);
            panel11.Location = new Point(719, 26);
            panel11.Name = "panel11";
            panel11.Size = new Size(46, 10);
            panel11.TabIndex = 6;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(224, 224, 224);
            panel10.Location = new Point(636, 26);
            panel10.Name = "panel10";
            panel10.Size = new Size(46, 10);
            panel10.TabIndex = 6;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(224, 224, 224);
            panel9.Location = new Point(559, 26);
            panel9.Name = "panel9";
            panel9.Size = new Size(46, 10);
            panel9.TabIndex = 6;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(224, 224, 224);
            panel8.Location = new Point(478, 26);
            panel8.Name = "panel8";
            panel8.Size = new Size(46, 10);
            panel8.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(224, 224, 224);
            panel7.Location = new Point(396, 26);
            panel7.Name = "panel7";
            panel7.Size = new Size(46, 10);
            panel7.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(224, 224, 224);
            panel6.Location = new Point(316, 26);
            panel6.Name = "panel6";
            panel6.Size = new Size(46, 10);
            panel6.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(224, 224, 224);
            panel5.Location = new Point(237, 26);
            panel5.Name = "panel5";
            panel5.Size = new Size(46, 10);
            panel5.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(224, 224, 224);
            panel4.Location = new Point(157, 26);
            panel4.Name = "panel4";
            panel4.Size = new Size(46, 10);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.Location = new Point(81, 26);
            panel3.Name = "panel3";
            panel3.Size = new Size(46, 10);
            panel3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Location = new Point(9, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(46, 10);
            panel2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("NSimSun", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(241, 9);
            label3.Name = "label3";
            label3.Size = new Size(311, 40);
            label3.TabIndex = 3;
            label3.Text = "Parking System";
            // 
            // textAnimationTimer
            // 
            textAnimationTimer.Enabled = true;
            textAnimationTimer.Interval = 500;
            textAnimationTimer.Tick += textAnimationTimer_Tick_1;
            // 
            // panel13
            // 
            panel13.BackgroundImage = (Image)resources.GetObject("panel13.BackgroundImage");
            panel13.BackgroundImageLayout = ImageLayout.Stretch;
            panel13.Enabled = false;
            panel13.Location = new Point(192, 52);
            panel13.Name = "panel13";
            panel13.Size = new Size(494, 343);
            panel13.TabIndex = 4;
            // 
            // percentageLabel
            // 
            percentageLabel.AutoSize = true;
            percentageLabel.Font = new Font("NSimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            percentageLabel.ForeColor = Color.White;
            percentageLabel.Location = new Point(766, 414);
            percentageLabel.Name = "percentageLabel";
            percentageLabel.RightToLeft = RightToLeft.No;
            percentageLabel.Size = new Size(0, 34);
            percentageLabel.TabIndex = 5;
            percentageLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel14
            // 
            panel14.BackgroundImage = (Image)resources.GetObject("panel14.BackgroundImage");
            panel14.BackgroundImageLayout = ImageLayout.Stretch;
            panel14.Location = new Point(547, -4);
            panel14.Name = "panel14";
            panel14.Size = new Size(53, 50);
            panel14.TabIndex = 5;
            // 
            // LoadingState
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 11, 60);
            ClientSize = new Size(849, 526);
            Controls.Add(panel14);
            Controls.Add(percentageLabel);
            Controls.Add(panel13);
            Controls.Add(label3);
            Controls.Add(containerLoading);
            Controls.Add(loadingLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingState";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingState";
            containerLoading.ResumeLayout(false);
            panelLoading.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label loadingLabel;
        private System.Windows.Forms.Timer loadingTimer;
        private Panel containerLoading;
        private Panel panelLoading;
        private Label label3;
        private System.Windows.Forms.Timer textAnimationTimer;
        private Panel panel1;
        private Panel panel9;
        private Panel panel10;
        private Panel panel8;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Panel panel12;
        private Panel panel11;
        private Panel panel13;
        private Label percentageLabel;
        private Panel panel14;
    }
}