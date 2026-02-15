namespace BookLibrary.WinForms.Forms
{
    partial class MainForm
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
            panelSidebar = new Panel();
            lblHeadr = new Label();
            btnUser = new Button();
            btnBook = new Button();
            btnAuthor = new Button();
            btnRental = new Button();
            btnDash = new Button();
            panel1 = new Panel();
            btnLogout = new Button();
            label2 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dgvBooks = new DataGridView();
            panelSidebar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.DarkBlue;
            panelSidebar.Controls.Add(lblHeadr);
            panelSidebar.Controls.Add(btnUser);
            panelSidebar.Controls.Add(btnBook);
            panelSidebar.Controls.Add(btnAuthor);
            panelSidebar.Controls.Add(btnRental);
            panelSidebar.Controls.Add(btnDash);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 450);
            panelSidebar.TabIndex = 0;
            // 
            // lblHeadr
            // 
            lblHeadr.AutoSize = true;
            lblHeadr.BackColor = Color.Transparent;
            lblHeadr.ForeColor = Color.White;
            lblHeadr.Location = new Point(12, 9);
            lblHeadr.Name = "lblHeadr";
            lblHeadr.Size = new Size(114, 15);
            lblHeadr.TabIndex = 5;
            lblHeadr.Text = "Book Library System";
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.Transparent;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.ForeColor = Color.White;
            btnUser.Location = new Point(12, 246);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(188, 45);
            btnUser.TabIndex = 4;
            btnUser.Text = "Users";
            btnUser.TextAlign = ContentAlignment.MiddleLeft;
            btnUser.UseVisualStyleBackColor = false;
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.Transparent;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(12, 93);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(188, 45);
            btnBook.TabIndex = 3;
            btnBook.Text = "Books";
            btnBook.TextAlign = ContentAlignment.MiddleLeft;
            btnBook.UseVisualStyleBackColor = false;
            // 
            // btnAuthor
            // 
            btnAuthor.BackColor = Color.Transparent;
            btnAuthor.FlatStyle = FlatStyle.Flat;
            btnAuthor.ForeColor = Color.White;
            btnAuthor.Location = new Point(12, 144);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(188, 45);
            btnAuthor.TabIndex = 2;
            btnAuthor.Text = "Authors";
            btnAuthor.TextAlign = ContentAlignment.MiddleLeft;
            btnAuthor.UseVisualStyleBackColor = false;
            // 
            // btnRental
            // 
            btnRental.BackColor = Color.Transparent;
            btnRental.FlatStyle = FlatStyle.Flat;
            btnRental.ForeColor = Color.White;
            btnRental.Location = new Point(12, 195);
            btnRental.Name = "btnRental";
            btnRental.Size = new Size(188, 45);
            btnRental.TabIndex = 1;
            btnRental.Text = "Rentals";
            btnRental.TextAlign = ContentAlignment.MiddleLeft;
            btnRental.UseVisualStyleBackColor = false;
            // 
            // btnDash
            // 
            btnDash.BackColor = Color.Transparent;
            btnDash.FlatStyle = FlatStyle.Flat;
            btnDash.ForeColor = Color.White;
            btnDash.Location = new Point(12, 42);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(188, 45);
            btnDash.TabIndex = 0;
            btnDash.Text = "Dashboard";
            btnDash.TextAlign = ContentAlignment.MiddleLeft;
            btnDash.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(71, 111, 245);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnLogout);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 60);
            panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Red;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(513, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 33);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 21);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 6;
            label2.Text = "Welcome, admin";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(223, 71);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(167, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(413, 71);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(223, 111);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;
            dgvBooks.Size = new Size(577, 190);
            dgvBooks.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBooks);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            Controls.Add(panelSidebar);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSidebar;
        private Button btnDash;
        private Button btnBook;
        private Button btnAuthor;
        private Button btnRental;
        private Label lblHeadr;
        private Button btnUser;
        private Panel panel1;
        private Button btnLogout;
        private Label label2;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dgvBooks;
    }
}