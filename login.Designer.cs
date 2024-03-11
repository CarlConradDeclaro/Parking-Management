namespace Parking
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            button2 = new Button();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            password = new TextBox();
            label1 = new Label();
            loginbtn = new Button();
            username = new TextBox();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 28, 75);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(124, 753);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(12, 11, 45);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(124, 0);
            panel2.MinimumSize = new Size(500, 330);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 753);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(button2);
            panel4.Location = new Point(357, 35);
            panel4.Name = "panel4";
            panel4.Size = new Size(237, 136);
            panel4.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(12, 11, 45);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(-24, -21);
            button2.Name = "button2";
            button2.Size = new Size(297, 171);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(password);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(loginbtn);
            panel3.Controls.Add(username);
            panel3.Location = new Point(122, 114);
            panel3.Name = "panel3";
            panel3.Size = new Size(709, 538);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(300, 92);
            label3.Name = "label3";
            label3.Size = new Size(110, 46);
            label3.TabIndex = 6;
            label3.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(179, 287);
            label2.Name = "label2";
            label2.Size = new Size(110, 31);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(12, 11, 45);
            password.BorderStyle = BorderStyle.FixedSingle;
            password.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.ForeColor = Color.White;
            password.Location = new Point(170, 311);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(354, 43);
            password.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(179, 166);
            label1.Name = "label1";
            label1.Size = new Size(117, 31);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.FromArgb(31, 28, 75);
            loginbtn.BackgroundImageLayout = ImageLayout.None;
            loginbtn.Cursor = Cursors.Hand;
            loginbtn.FlatAppearance.BorderSize = 0;
            loginbtn.FlatStyle = FlatStyle.Flat;
            loginbtn.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = Color.White;
            loginbtn.Location = new Point(282, 455);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(136, 37);
            loginbtn.TabIndex = 2;
            loginbtn.Text = "Login";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // username
            // 
            username.BackColor = Color.FromArgb(12, 11, 45);
            username.BorderStyle = BorderStyle.FixedSingle;
            username.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.ForeColor = Color.White;
            username.Location = new Point(170, 188);
            username.Name = "username";
            username.Size = new Size(354, 43);
            username.TabIndex = 1;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1100, 800);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button loginbtn;
        private TextBox username;
        private Label label2;
        private TextBox password;
        private Label label1;
        private Panel panel4;
        private Button button2;
        private Label label3;
    }
}