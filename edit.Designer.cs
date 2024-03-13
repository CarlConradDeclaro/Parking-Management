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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 100);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Plate No.";
            // 
            // plateValue
            // 
            plateValue.Location = new Point(249, 102);
            plateValue.Name = "plateValue";
            plateValue.Size = new Size(252, 27);
            plateValue.TabIndex = 1;
            // 
            // typeValue
            // 
            typeValue.Location = new Point(249, 182);
            typeValue.Name = "typeValue";
            typeValue.Size = new Size(252, 27);
            typeValue.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 180);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 2;
            label2.Text = "Type";
            // 
            // brandValue
            // 
            brandValue.Location = new Point(249, 270);
            brandValue.Name = "brandValue";
            brandValue.Size = new Size(252, 27);
            brandValue.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 268);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Brand";
            // 
            // button1
            // 
            button1.Location = new Point(520, 518);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(642, 518);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // driverValue
            // 
            driverValue.Location = new Point(249, 352);
            driverValue.Name = "driverValue";
            driverValue.Size = new Size(252, 27);
            driverValue.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 350);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Driver";
            // 
            // phoneValue
            // 
            phoneValue.Location = new Point(249, 435);
            phoneValue.Name = "phoneValue";
            phoneValue.Size = new Size(252, 27);
            phoneValue.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(110, 433);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 10;
            label5.Text = "Phone No.";
            // 
            // edit
            // 
            AccessibleRole = AccessibleRole.MenuBar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 631);
            ControlBox = false;
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
    }
}