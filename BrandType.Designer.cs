namespace Parking
{
    partial class BrandType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrandType));
            brandName = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // brandName
            // 
            brandName.BackColor = Color.FromArgb(22, 19, 90);
            brandName.BorderStyle = BorderStyle.FixedSingle;
            brandName.ForeColor = Color.White;
            brandName.Location = new Point(3, 3);
            brandName.Name = "brandName";
            brandName.Size = new Size(297, 27);
            brandName.TabIndex = 7;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(306, 1);
            button2.Name = "button2";
            button2.Size = new Size(60, 34);
            button2.TabIndex = 8;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // BrandType
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 19, 75);
            Controls.Add(button2);
            Controls.Add(brandName);
            Name = "BrandType";
            Size = new Size(374, 35);
            Load += BrandType_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox brandName;
        private Button button2;
    }
}
