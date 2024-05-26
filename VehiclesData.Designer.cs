namespace Parking
{
    partial class VehiclesData
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
            typeLabel = new Label();
            NumberParkVlabel = new Label();
            flagDownlabel = new Label();
            amtPerhHour = new Label();
            SuspendLayout();
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            typeLabel.ForeColor = Color.Bisque;
            typeLabel.Location = new Point(20, 9);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(114, 28);
            typeLabel.TabIndex = 0;
            typeLabel.Text = "MOTOBIKE";
            // 
            // NumberParkVlabel
            // 
            NumberParkVlabel.AutoSize = true;
            NumberParkVlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumberParkVlabel.ForeColor = Color.DarkOrange;
            NumberParkVlabel.Location = new Point(791, 9);
            NumberParkVlabel.Name = "NumberParkVlabel";
            NumberParkVlabel.Size = new Size(36, 28);
            NumberParkVlabel.TabIndex = 1;
            NumberParkVlabel.Text = "15";
            // 
            // flagDownlabel
            // 
            flagDownlabel.AutoSize = true;
            flagDownlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flagDownlabel.ForeColor = Color.Gold;
            flagDownlabel.Location = new Point(191, 9);
            flagDownlabel.Name = "flagDownlabel";
            flagDownlabel.Size = new Size(36, 28);
            flagDownlabel.TabIndex = 2;
            flagDownlabel.Text = "30";
            // 
            // amtPerhHour
            // 
            amtPerhHour.AutoSize = true;
            amtPerhHour.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amtPerhHour.ForeColor = Color.Red;
            amtPerhHour.Location = new Point(274, 9);
            amtPerhHour.Name = "amtPerhHour";
            amtPerhHour.Size = new Size(38, 28);
            amtPerhHour.TabIndex = 3;
            amtPerhHour.Text = "+5";
            // 
            // VehiclesData
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 19, 120);
            Controls.Add(amtPerhHour);
            Controls.Add(flagDownlabel);
            Controls.Add(NumberParkVlabel);
            Controls.Add(typeLabel);
            Name = "VehiclesData";
            Size = new Size(872, 48);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label typeLabel;
        private Label NumberParkVlabel;
        private Label flagDownlabel;
        private Label amtPerhHour;
    }
}
