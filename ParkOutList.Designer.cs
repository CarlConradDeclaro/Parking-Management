namespace Parking
{
    partial class ParkOutList
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
            brand = new Label();
            type = new Label();
            plateNo = new Label();
            parkout = new Button();
            SuspendLayout();
            // 
            // brand
            // 
            brand.AutoSize = true;
            brand.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            brand.ForeColor = Color.White;
            brand.Location = new Point(448, 12);
            brand.Name = "brand";
            brand.Size = new Size(49, 19);
            brand.TabIndex = 22;
            brand.Text = "Tesla";
            // 
            // type
            // 
            type.AutoSize = true;
            type.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            type.ForeColor = Color.White;
            type.Location = new Point(229, 12);
            type.Name = "type";
            type.Size = new Size(43, 19);
            type.TabIndex = 16;
            type.Text = "SUV";
            // 
            // plateNo
            // 
            plateNo.AutoSize = true;
            plateNo.Font = new Font("Arial", 10.2F, FontStyle.Bold);
            plateNo.ForeColor = Color.Yellow;
            plateNo.Location = new Point(12, 12);
            plateNo.Name = "plateNo";
            plateNo.Size = new Size(79, 19);
            plateNo.TabIndex = 15;
            plateNo.Text = "9807oipu";
            // 
            // parkout
            // 
            parkout.BackColor = SystemColors.ButtonFace;
            parkout.FlatStyle = FlatStyle.Flat;
            parkout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            parkout.ForeColor = Color.Black;
            parkout.Location = new Point(831, 5);
            parkout.Name = "parkout";
            parkout.Size = new Size(107, 33);
            parkout.TabIndex = 25;
            parkout.Text = "Parkout";
            parkout.UseVisualStyleBackColor = false;
            parkout.Click += parkout_Click;
            // 
            // ParkOutList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 22, 71);
            Controls.Add(parkout);
            Controls.Add(brand);
            Controls.Add(type);
            Controls.Add(plateNo);
            Name = "ParkOutList";
            Size = new Size(951, 41);
            Load += ParkOutList_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label brand;
        private Label type;
        private Label plateNo;
        private Button parkout;
    }
}
