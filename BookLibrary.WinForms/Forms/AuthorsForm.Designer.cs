namespace BookLibrary.WinForms.Forms
{
    partial class FormAuthors
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
            pnlHeader = new Panel();
            lblHeaderTitle = new Label();
            panelPageTitle = new Panel();
            label1 = new Label();
            panelAddAuthor = new Panel();
            panelAddBody = new Panel();
            btnAddAuthor = new Button();
            txtAuthorBio = new TextBox();
            lblBio = new Label();
            txtAuthorName = new TextBox();
            lblName = new Label();
            panel1 = new Panel();
            lblAddHeader = new Label();
            panelActionBar = new Panel();
            btnSearch = new Button();
            txtSearch = new TextBox();
            btnNewAuthor = new Button();
            panelGridContainer = new Panel();
            panelPagination = new Panel();
            lblPageInfo = new Label();
            btnPage4 = new Button();
            btnPage3 = new Button();
            btnPage2 = new Button();
            btnPage1 = new Button();
            gridAuthors = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colBio = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            pnlHeader.SuspendLayout();
            panelPageTitle.SuspendLayout();
            panelAddAuthor.SuspendLayout();
            panelAddBody.SuspendLayout();
            panel1.SuspendLayout();
            panelActionBar.SuspendLayout();
            panelGridContainer.SuspendLayout();
            panelPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridAuthors).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(248, 248, 248);
            pnlHeader.Controls.Add(lblHeaderTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(984, 40);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(51, 51, 51);
            lblHeaderTitle.Location = new Point(15, 10);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(61, 19);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Authors";
            // 
            // panelPageTitle
            // 
            panelPageTitle.BackColor = Color.Transparent;
            panelPageTitle.BorderStyle = BorderStyle.FixedSingle;
            panelPageTitle.Controls.Add(label1);
            panelPageTitle.Dock = DockStyle.Top;
            panelPageTitle.Location = new Point(0, 40);
            panelPageTitle.Name = "panelPageTitle";
            panelPageTitle.Size = new Size(984, 60);
            panelPageTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(51, 51, 51);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(235, 32);
            label1.TabIndex = 0;
            label1.Text = "Müəllif idarəetməsi";
            // 
            // panelAddAuthor
            // 
            panelAddAuthor.BackColor = Color.White;
            panelAddAuthor.Controls.Add(panelAddBody);
            panelAddAuthor.Controls.Add(panel1);
            panelAddAuthor.Dock = DockStyle.Top;
            panelAddAuthor.Location = new Point(0, 100);
            panelAddAuthor.Name = "panelAddAuthor";
            panelAddAuthor.Padding = new Padding(10);
            panelAddAuthor.Size = new Size(984, 151);
            panelAddAuthor.TabIndex = 2;
            // 
            // panelAddBody
            // 
            panelAddBody.Controls.Add(btnAddAuthor);
            panelAddBody.Controls.Add(txtAuthorBio);
            panelAddBody.Controls.Add(lblBio);
            panelAddBody.Controls.Add(txtAuthorName);
            panelAddBody.Controls.Add(lblName);
            panelAddBody.Dock = DockStyle.Fill;
            panelAddBody.Location = new Point(10, 45);
            panelAddBody.Name = "panelAddBody";
            panelAddBody.Size = new Size(964, 96);
            panelAddBody.TabIndex = 1;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.BackColor = Color.SeaGreen;
            btnAddAuthor.FlatStyle = FlatStyle.Flat;
            btnAddAuthor.ForeColor = Color.White;
            btnAddAuthor.Location = new Point(822, 47);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(115, 35);
            btnAddAuthor.TabIndex = 4;
            btnAddAuthor.Text = "Əlavə Et";
            btnAddAuthor.UseVisualStyleBackColor = false;
            // 
            // txtAuthorBio
            // 
            txtAuthorBio.Location = new Point(455, 47);
            txtAuthorBio.Multiline = true;
            txtAuthorBio.Name = "txtAuthorBio";
            txtAuthorBio.Size = new Size(330, 30);
            txtAuthorBio.TabIndex = 3;
            // 
            // lblBio
            // 
            lblBio.AutoSize = true;
            lblBio.Location = new Point(450, 25);
            lblBio.Name = "lblBio";
            lblBio.Size = new Size(72, 19);
            lblBio.TabIndex = 2;
            lblBio.Text = "Bioqrafiya:";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(11, 47);
            txtAuthorName.Multiline = true;
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(330, 30);
            txtAuthorName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(10, 25);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 19);
            lblName.TabIndex = 0;
            lblName.Text = "Ad, Soyad:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 241, 241);
            panel1.Controls.Add(lblAddHeader);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(964, 35);
            panel1.TabIndex = 0;
            // 
            // lblAddHeader
            // 
            lblAddHeader.AutoSize = true;
            lblAddHeader.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddHeader.Location = new Point(10, 8);
            lblAddHeader.Name = "lblAddHeader";
            lblAddHeader.Size = new Size(82, 17);
            lblAddHeader.TabIndex = 0;
            lblAddHeader.Text = "Yeni Müəllif";
            // 
            // panelActionBar
            // 
            panelActionBar.Controls.Add(btnSearch);
            panelActionBar.Controls.Add(txtSearch);
            panelActionBar.Controls.Add(btnNewAuthor);
            panelActionBar.Dock = DockStyle.Top;
            panelActionBar.Location = new Point(0, 251);
            panelActionBar.Name = "panelActionBar";
            panelActionBar.Size = new Size(984, 60);
            panelActionBar.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(940, 15);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(40, 30);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(740, 15);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search";
            txtSearch.Size = new Size(200, 30);
            txtSearch.TabIndex = 1;
            // 
            // btnNewAuthor
            // 
            btnNewAuthor.BackColor = Color.SeaGreen;
            btnNewAuthor.FlatStyle = FlatStyle.Flat;
            btnNewAuthor.ForeColor = Color.White;
            btnNewAuthor.Location = new Point(20, 12);
            btnNewAuthor.Name = "btnNewAuthor";
            btnNewAuthor.Size = new Size(140, 36);
            btnNewAuthor.TabIndex = 0;
            btnNewAuthor.Text = "+ Yeni Müəllif";
            btnNewAuthor.UseVisualStyleBackColor = false;
            // 
            // panelGridContainer
            // 
            panelGridContainer.Controls.Add(panelPagination);
            panelGridContainer.Controls.Add(gridAuthors);
            panelGridContainer.Dock = DockStyle.Fill;
            panelGridContainer.Location = new Point(0, 311);
            panelGridContainer.Name = "panelGridContainer";
            panelGridContainer.Padding = new Padding(20);
            panelGridContainer.Size = new Size(984, 381);
            panelGridContainer.TabIndex = 4;
            // 
            // panelPagination
            // 
            panelPagination.BackColor = Color.Transparent;
            panelPagination.Controls.Add(lblPageInfo);
            panelPagination.Controls.Add(btnPage4);
            panelPagination.Controls.Add(btnPage3);
            panelPagination.Controls.Add(btnPage2);
            panelPagination.Controls.Add(btnPage1);
            panelPagination.Dock = DockStyle.Bottom;
            panelPagination.Location = new Point(20, 316);
            panelPagination.Name = "panelPagination";
            panelPagination.Size = new Size(944, 45);
            panelPagination.TabIndex = 1;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Location = new Point(820, 12);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(68, 19);
            lblPageInfo.TabIndex = 4;
            lblPageInfo.Text = "1 - 5 / 25";
            // 
            // btnPage4
            // 
            btnPage4.Location = new Point(140, 8);
            btnPage4.Name = "btnPage4";
            btnPage4.Size = new Size(30, 23);
            btnPage4.TabIndex = 3;
            btnPage4.Text = "3";
            btnPage4.UseVisualStyleBackColor = true;
            // 
            // btnPage3
            // 
            btnPage3.Location = new Point(100, 8);
            btnPage3.Name = "btnPage3";
            btnPage3.Size = new Size(30, 23);
            btnPage3.TabIndex = 2;
            btnPage3.Text = "3";
            btnPage3.UseVisualStyleBackColor = true;
            // 
            // btnPage2
            // 
            btnPage2.Location = new Point(60, 8);
            btnPage2.Name = "btnPage2";
            btnPage2.Size = new Size(30, 23);
            btnPage2.TabIndex = 1;
            btnPage2.Text = "2";
            btnPage2.UseVisualStyleBackColor = true;
            // 
            // btnPage1
            // 
            btnPage1.Location = new Point(20, 8);
            btnPage1.Name = "btnPage1";
            btnPage1.Size = new Size(30, 23);
            btnPage1.TabIndex = 0;
            btnPage1.Text = "1";
            btnPage1.UseVisualStyleBackColor = true;
            // 
            // gridAuthors
            // 
            gridAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridAuthors.BackgroundColor = Color.White;
            gridAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridAuthors.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colBio, colEdit, colDelete });
            gridAuthors.Dock = DockStyle.Fill;
            gridAuthors.Location = new Point(20, 20);
            gridAuthors.Name = "gridAuthors";
            gridAuthors.RowHeadersVisible = false;
            gridAuthors.Size = new Size(944, 341);
            gridAuthors.TabIndex = 0;
            // 
            // colID
            // 
            colID.HeaderText = "Id";
            colID.Name = "colID";
            // 
            // colName
            // 
            colName.HeaderText = "Ad, Soyad";
            colName.Name = "colName";
            // 
            // colBio
            // 
            colBio.HeaderText = "Bioqrafiya";
            colBio.Name = "colBio";
            // 
            // colEdit
            // 
            colEdit.HeaderText = "Düzəliş et";
            colEdit.Name = "colEdit";
            colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            colDelete.HeaderText = "Sil";
            colDelete.Name = "colDelete";
            colDelete.UseColumnTextForButtonValue = true;
            // 
            // FormAuthors
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(984, 692);
            Controls.Add(panelGridContainer);
            Controls.Add(panelActionBar);
            Controls.Add(panelAddAuthor);
            Controls.Add(panelPageTitle);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FormAuthors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müəllif idarəetməsi";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            panelPageTitle.ResumeLayout(false);
            panelPageTitle.PerformLayout();
            panelAddAuthor.ResumeLayout(false);
            panelAddBody.ResumeLayout(false);
            panelAddBody.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelActionBar.ResumeLayout(false);
            panelActionBar.PerformLayout();
            panelGridContainer.ResumeLayout(false);
            panelPagination.ResumeLayout(false);
            panelPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridAuthors).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeaderTitle;
        private Panel panelPageTitle;
        private Label label1;
        private Panel panelAddAuthor;
        private Panel panel1;
        private Label lblAddHeader;
        private Panel panelAddBody;
        private TextBox txtAuthorName;
        private Label lblName;
        private TextBox txtAuthorBio;
        private Label lblBio;
        private Button btnAddAuthor;
        private Panel panelActionBar;
        private Button btnNewAuthor;
        private TextBox txtSearch;
        private Button btnSearch;
        private Panel panelGridContainer;
        private DataGridView gridAuthors;
        private Panel panelPagination;
        private Button btnPage2;
        private Button btnPage1;
        private Label lblPageInfo;
        private Button btnPage4;
        private Button btnPage3;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colBio;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
    }
}