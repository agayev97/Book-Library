namespace BookLibrary.WinForms.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblError = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panelCard = new Panel();
            lblForgot = new Label();
            loginButton = new Button();
            panelPassword = new Panel();
            iconEye = new PictureBox();
            txtPassword = new TextBox();
            iconLock = new PictureBox();
            panelUsername = new Panel();
            txtUsername = new TextBox();
            iconUser = new PictureBox();
            lblWelcome = new Label();
            panel1.SuspendLayout();
            panelCard.SuspendLayout();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconEye).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconLock).BeginInit();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).BeginInit();
            SuspendLayout();
            // 
            // lblError
            // 
            lblError.Font = new Font("Segoe UI", 9F);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(5, 234);
            lblError.Margin = new Padding(5, 0, 5, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(410, 25);
            lblError.TabIndex = 5;
            lblError.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 62, 80);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5, 4, 5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1389, 74);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(123, 25);
            label1.TabIndex = 0;
            label1.Text = "BookLibrary";
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(lblForgot);
            panelCard.Controls.Add(loginButton);
            panelCard.Controls.Add(lblError);
            panelCard.Controls.Add(panelPassword);
            panelCard.Controls.Add(panelUsername);
            panelCard.Controls.Add(lblWelcome);
            panelCard.Location = new Point(143, 81);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(420, 380);
            panelCard.TabIndex = 7;
            // 
            // lblForgot
            // 
            lblForgot.AutoSize = true;
            lblForgot.Cursor = Cursors.Hand;
            lblForgot.ForeColor = Color.FromArgb(74, 144, 226);
            lblForgot.Location = new Point(130, 312);
            lblForgot.Name = "lblForgot";
            lblForgot.Size = new Size(171, 25);
            lblForgot.TabIndex = 6;
            lblForgot.Text = "Forgot password?";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(74, 144, 226);
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(50, 263);
            loginButton.Margin = new Padding(5, 4, 5, 4);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(320, 45);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += LoginButton_Click;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = Color.FromArgb(244, 246, 249);
            panelPassword.Controls.Add(iconEye);
            panelPassword.Controls.Add(txtPassword);
            panelPassword.Controls.Add(iconLock);
            panelPassword.Location = new Point(50, 180);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(320, 45);
            panelPassword.TabIndex = 2;
            // 
            // iconEye
            // 
            iconEye.Cursor = Cursors.Hand;
            iconEye.Image = (Image)resources.GetObject("iconEye.Image");
            iconEye.Location = new Point(290, 10);
            iconEye.Name = "iconEye";
            iconEye.Size = new Size(24, 24);
            iconEye.TabIndex = 2;
            iconEye.TabStop = false;
            iconEye.Click += IconEye_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(244, 246, 249);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(45, 12);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(220, 20);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // iconLock
            // 
            iconLock.Image = (Image)resources.GetObject("iconLock.Image");
            iconLock.Location = new Point(10, 10);
            iconLock.Name = "iconLock";
            iconLock.Size = new Size(24, 24);
            iconLock.TabIndex = 0;
            iconLock.TabStop = false;
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.FromArgb(244, 246, 249);
            panelUsername.Controls.Add(txtUsername);
            panelUsername.Controls.Add(iconUser);
            panelUsername.Location = new Point(50, 120);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(320, 45);
            panelUsername.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(244, 246, 249);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(45, 12);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 20);
            txtUsername.TabIndex = 1;
            // 
            // iconUser
            // 
            iconUser.Image = (Image)resources.GetObject("iconUser.Image");
            iconUser.Location = new Point(10, 10);
            iconUser.Name = "iconUser";
            iconUser.Size = new Size(24, 24);
            iconUser.SizeMode = PictureBoxSizeMode.Zoom;
            iconUser.TabIndex = 0;
            iconUser.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(44, 62, 80);
            lblWelcome.Location = new Point(130, 40);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(147, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(233, 238, 245);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1389, 728);
            Controls.Add(panelCard);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            Margin = new Padding(5, 4, 5, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconEye).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconLock).EndInit();
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconUser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblError;
        private Panel panel1;
        private Label label1;
        private Panel panelCard;
        private Label lblWelcome;
        private Panel panelUsername;
        private TextBox txtUsername;
        private PictureBox iconUser;
        private Panel panelPassword;
        private PictureBox iconLock;
        private TextBox txtPassword;
        private PictureBox iconEye;
        private Button loginButton;
        private Label lblForgot;
    }
}