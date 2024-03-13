namespace Parking
{
    partial class vehicleDetails
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
            panel5 = new Panel();
            vLabel1Data = new Label();
            vLabel1 = new Label();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(vLabel1Data);
            panel5.Controls.Add(vLabel1);
            panel5.Location = new Point(9, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(479, 25);
            panel5.TabIndex = 3;
            panel5.Paint += panel5_Paint;
            // 
            // vLabel1Data
            // 
            vLabel1Data.AutoSize = true;
            vLabel1Data.Dock = DockStyle.Right;
            vLabel1Data.Font = new Font("PMingLiU-ExtB", 13.8F, FontStyle.Bold);
            vLabel1Data.ForeColor = Color.White;
            vLabel1Data.Location = new Point(378, 0);
            vLabel1Data.Name = "vLabel1Data";
            vLabel1Data.Size = new Size(101, 23);
            vLabel1Data.TabIndex = 1;
            vLabel1Data.Text = "9807oipu";
            // 
            // vLabel1
            // 
            vLabel1.AutoSize = true;
            vLabel1.Dock = DockStyle.Left;
            vLabel1.Font = new Font("PMingLiU-ExtB", 13.8F, FontStyle.Bold);
            vLabel1.ForeColor = Color.White;
            vLabel1.Location = new Point(0, 0);
            vLabel1.Name = "vLabel1";
            vLabel1.Size = new Size(158, 23);
            vLabel1.TabIndex = 0;
            vLabel1.Text = "Plate Number: ";
            // 
            // vehicleDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 25, 80);
            Controls.Add(panel5);
            Name = "vehicleDetails";
            Size = new Size(491, 35);
            Load += vehicleDetails_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel5;
        private Label vLabel1Data;
        private Label vLabel1;
    }
}
