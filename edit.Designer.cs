namespace Parking
{
    partial class edit
    {
     
        private System.ComponentModel.IContainer components = null;
  
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit));
            label1 = new Label();
            plateValue = new TextBox();
            typeValue = new TextBox();
            label2 = new Label();
            brandValue = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            driverValue = new TextBox();
            label4 = new Label();
            phoneValue = new TextBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 127);
            label1.Name = "label1";
            label1.Size = new Size(92, 23);
            label1.TabIndex = 0;
            label1.Text = "Plate No:";
            // 
            // plateValue
            // 
            plateValue.Location = new Point(118, 129);
            plateValue.Name = "plateValue";
            plateValue.Size = new Size(252, 27);
            plateValue.TabIndex = 1;
            // 
            // typeValue
            // 
            typeValue.Location = new Point(118, 209);
            typeValue.Name = "typeValue";
            typeValue.Size = new Size(252, 27);
            typeValue.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(49, 212);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 2;
            label2.Text = "Type:";
            // 
            // brandValue
            // 
            brandValue.Location = new Point(118, 297);
            brandValue.Name = "brandValue";
            brandValue.Size = new Size(252, 27);
            brandValue.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(39, 297);
            label3.Name = "label3";
            label3.Size = new Size(73, 23);
            label3.TabIndex = 4;
            label3.Text = "Brand:";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(542, 296);
            button1.Name = "button1";
            button1.Size = new Size(99, 34);
            button1.TabIndex = 6;
            button1.Text = "        Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(669, 296);
            button2.Name = "button2";
            button2.Size = new Size(94, 34);
            button2.TabIndex = 7;
            button2.Text = "        Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // driverValue
            // 
            driverValue.Location = new Point(511, 129);
            driverValue.Name = "driverValue";
            driverValue.Size = new Size(252, 27);
            driverValue.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(431, 127);
            label4.Name = "label4";
            label4.Size = new Size(74, 23);
            label4.TabIndex = 8;
            label4.Text = "Driver:";
            // 
            // phoneValue
            // 
            phoneValue.Location = new Point(511, 212);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(252, 27);
            phoneValue.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(402, 213);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 10;
            label5.Text = "Phone No:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 12F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(337, 47);
            label6.Name = "label6";
            label6.Size = new Size(126, 23);
            label6.TabIndex = 12;
            label6.Text = "Edit Vehicle*";
            // 
            // edit
            // 
            AccessibleRole = AccessibleRole.MenuBar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 22, 71);
            ClientSize = new Size(784, 393);
            ControlBox = false;
            Controls.Add(label6);
            Controls.Add(phoneValue);
            Controls.Add(label5);
            Controls.Add(driverValue);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(brandValue);
            Controls.Add(label3);
            Controls.Add(typeValue);
            Controls.Add(label2);
            Controls.Add(plateValue);
            Controls.Add(label1);
            Name = "edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "edit";
            Load += edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox plateValue;
        private TextBox typeValue;
        private Label label2;
        private TextBox brandValue;
        private Label label3;
        private Button button1;
        private Button button2;
        private TextBox driverValue;
        private Label label4;
        private TextBox phoneValue;
        private Label label5;
        private Label label6;
    }
}