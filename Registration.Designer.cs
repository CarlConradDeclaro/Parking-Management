namespace Parking
{
    partial class Registration
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
            panel1 = new Panel();
            number = new TextBox();
            label2 = new Label();
            label1 = new Label();
            createAccBtn = new Button();
            email = new TextBox();
            Lname = new TextBox();
            comboBoxGender = new ComboBox();
            password = new TextBox();
            fname = new TextBox();
            label3 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(number);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(createAccBtn);
            panel1.Controls.Add(email);
            panel1.Controls.Add(Lname);
            panel1.Controls.Add(comboBoxGender);
            panel1.Controls.Add(password);
            panel1.Controls.Add(fname);
            panel1.Location = new Point(438, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 559);
            panel1.TabIndex = 0;
            // 
            // number
            // 
            number.Font = new Font("NSimSun", 16.2F);
            number.Location = new Point(358, 224);
            number.Name = "number";
            number.PlaceholderText = "Phone Number";
            number.Size = new Size(227, 38);
            number.TabIndex = 8;
            number.TextChanged += number_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("NSimSun", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(199, 0);
            label2.Name = "label2";
            label2.Size = new Size(253, 34);
            label2.TabIndex = 7;
            label2.Text = "Create account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(231, 520);
            label1.Name = "label1";
            label1.Size = new Size(171, 20);
            label1.TabIndex = 6;
            label1.Text = "already have an account?";
            label1.Click += label1_Click;
            // 
            // createAccBtn
            // 
            createAccBtn.Cursor = Cursors.Hand;
            createAccBtn.Location = new Point(211, 442);
            createAccBtn.Name = "createAccBtn";
            createAccBtn.Size = new Size(209, 45);
            createAccBtn.TabIndex = 5;
            createAccBtn.Text = "Create Account";
            createAccBtn.UseVisualStyleBackColor = true;
            createAccBtn.Click += createAccBtn_Click;
            // 
            // email
            // 
            email.Font = new Font("NSimSun", 16.2F);
            email.Location = new Point(358, 114);
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(227, 38);
            email.TabIndex = 4;
            email.TextChanged += email_TextChanged;
            // 
            // Lname
            // 
            Lname.Font = new Font("NSimSun", 16.2F);
            Lname.Location = new Point(34, 224);
            Lname.Name = "Lname";
            Lname.PlaceholderText = "Lastname";
            Lname.Size = new Size(248, 38);
            Lname.TabIndex = 3;
            Lname.TextChanged += Lname_TextChanged;
            // 
            // comboBoxGender
            // 
            comboBoxGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGender.Font = new Font("NSimSun", 16.2F);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.ImeMode = ImeMode.KatakanaHalf;
            comboBoxGender.Location = new Point(358, 353);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(227, 35);
            comboBoxGender.TabIndex = 2;
            comboBoxGender.SelectedIndexChanged += comboBoxGender_SelectedIndexChanged;
            // 
            // password
            // 
            password.Font = new Font("NSimSun", 16.2F);
            password.Location = new Point(34, 353);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(248, 38);
            password.TabIndex = 1;
            password.TextChanged += password_TextChanged;
            // 
            // fname
            // 
            fname.Font = new Font("NSimSun", 16.2F);
            fname.Location = new Point(34, 114);
            fname.Name = "fname";
            fname.PlaceholderText = "Firstname";
            fname.Size = new Size(248, 38);
            fname.TabIndex = 0;
            fname.TextChanged += fname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("NSimSun", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(90, 98);
            label3.Name = "label3";
            label3.Size = new Size(267, 34);
            label3.TabIndex = 1;
            label3.Text = "Parking System";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.registerIcon;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(49, 213);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 297);
            panel2.TabIndex = 2;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 11, 45);
            ClientSize = new Size(1082, 753);
            Controls.Add(panel2);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox fname;
        private TextBox Lname;
        private ComboBox comboBoxGender;
        private TextBox password;
        private TextBox email;
        private Label label1;
        private Button createAccBtn;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private TextBox number;
    }
}