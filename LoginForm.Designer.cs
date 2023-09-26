namespace quanlykhachsan
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lbMainHeading = new Label();
            lbSubHeading = new Label();
            pictureBox1 = new PictureBox();
            lbUsername = new Label();
            lbPassword = new Label();
            panel1 = new Panel();
            textBox1 = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lbMainHeading
            // 
            lbMainHeading.AutoSize = true;
            lbMainHeading.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbMainHeading.Location = new Point(46, 59);
            lbMainHeading.Name = "lbMainHeading";
            lbMainHeading.Size = new Size(150, 62);
            lbMainHeading.TabIndex = 0;
            lbMainHeading.Text = "Login";
            // 
            // lbSubHeading
            // 
            lbSubHeading.AutoSize = true;
            lbSubHeading.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbSubHeading.ForeColor = Color.FromArgb(64, 64, 64);
            lbSubHeading.Location = new Point(52, 121);
            lbSubHeading.Name = "lbSubHeading";
            lbSubHeading.Size = new Size(222, 23);
            lbSubHeading.TabIndex = 1;
            lbSubHeading.Text = "Welcome to Gia Doan hotel";
            lbSubHeading.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(598, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(372, 485);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsername.Location = new Point(55, 198);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(87, 23);
            lbUsername.TabIndex = 3;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbPassword.Location = new Point(55, 294);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(82, 23);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(55, 224);
            panel1.Name = "panel1";
            panel1.Size = new Size(469, 39);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(10, 7);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(456, 29);
            textBox1.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaptionText;
            btnLogin.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(407, 405);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 41);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 416);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 10;
            label1.Text = "Don’t have an account ?";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(287, 405);
            button1.Name = "button1";
            button1.Size = new Size(114, 41);
            button1.TabIndex = 11;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(55, 320);
            panel2.Name = "panel2";
            panel2.Size = new Size(469, 39);
            panel2.TabIndex = 8;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(3, 7);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(456, 29);
            textBox2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(970, 483);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(pictureBox1);
            Controls.Add(lbSubHeading);
            Controls.Add(lbMainHeading);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMainHeading;
        private Label lbSubHeading;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lbUsername;
        private Label lbPassword;
        private Panel panel1;
        private Button btnLogin;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox textBox2;
    }
}