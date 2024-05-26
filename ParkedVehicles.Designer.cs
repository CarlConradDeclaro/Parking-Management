namespace Parking
{
    partial class ParkedVehicles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParkedVehicles));
            panel21 = new Panel();
            panel22 = new Panel();
            plateNum = new Label();
            sloc = new Label();
            SuspendLayout();
            // 
            // panel21
            // 
            panel21.Anchor = AnchorStyles.Top;
            panel21.BackColor = Color.Silver;
            panel21.BackgroundImageLayout = ImageLayout.Zoom;
            panel21.Location = new Point(21, 7);
            panel21.Name = "panel21";
            panel21.Size = new Size(10, 75);
            panel21.TabIndex = 15;
            // 
            // panel22
            // 
            panel22.Anchor = AnchorStyles.Top;
            panel22.BackgroundImage = (Image)resources.GetObject("panel22.BackgroundImage");
            panel22.BackgroundImageLayout = ImageLayout.Zoom;
            panel22.Location = new Point(48, 24);
            panel22.Name = "panel22";
            panel22.Size = new Size(46, 48);
            panel22.TabIndex = 16;
            // 
            // plateNum
            // 
            plateNum.AutoSize = true;
            plateNum.Font = new Font("NSimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plateNum.ForeColor = Color.White;
            plateNum.Location = new Point(158, 24);
            plateNum.Name = "plateNum";
            plateNum.Size = new Size(86, 20);
            plateNum.TabIndex = 19;
            plateNum.Text = "GAH9807";
            // 
            // sloc
            // 
            sloc.AutoSize = true;
            sloc.Font = new Font("NSimSun", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sloc.ForeColor = Color.Gray;
            sloc.Location = new Point(160, 55);
            sloc.Name = "sloc";
            sloc.Size = new Size(58, 17);
            sloc.TabIndex = 20;
            sloc.Text = "BM-01";
            // 
            // ParkedVehicles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 19, 120);
            Controls.Add(sloc);
            Controls.Add(plateNum);
            Controls.Add(panel21);
            Controls.Add(panel22);
            Name = "ParkedVehicles";
            Size = new Size(279, 88);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel21;
        private Panel panel22;
        private Label plateNum;
        private Label sloc;
    }
}
