namespace BookLibrary.WinForms.Forms
{
    partial class AddEditBookForm
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
            components = new System.ComponentModel.Container();
            panelHeader = new Panel();
            lblTitle = new Label();
            panelContent = new Panel();
            chklsAvilable = new CheckBox();
            btnAddAuthor = new Button();
            cmbAuthors = new ComboBox();
            panelButtons = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            numYear = new NumericUpDown();
            lblYear = new Label();
            lblAuthor = new Label();
            txtTitle = new TextBox();
            lblBookName = new Label();
            errorProvider1 = new ErrorProvider(components);
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(245, 246, 248);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(784, 68);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(197, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Kitab İdarəetməsi";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(chklsAvilable);
            panelContent.Controls.Add(btnAddAuthor);
            panelContent.Controls.Add(cmbAuthors);
            panelContent.Controls.Add(panelButtons);
            panelContent.Controls.Add(numYear);
            panelContent.Controls.Add(lblYear);
            panelContent.Controls.Add(lblAuthor);
            panelContent.Controls.Add(txtTitle);
            panelContent.Controls.Add(lblBookName);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 68);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(30, 34, 30, 34);
            panelContent.Size = new Size(784, 493);
            panelContent.TabIndex = 1;
            // 
            // chklsAvilable
            // 
            chklsAvilable.AutoSize = true;
            chklsAvilable.Location = new Point(30, 320);
            chklsAvilable.Name = "chklsAvilable";
            chklsAvilable.Size = new Size(99, 23);
            chklsAvilable.TabIndex = 10;
            chklsAvilable.Text = "Mövcuddur";
            chklsAvilable.UseVisualStyleBackColor = true;
            // 
            // btnAddAuthor
            // 
            btnAddAuthor.BackColor = Color.FromArgb(22, 163, 74);
            btnAddAuthor.FlatAppearance.BorderSize = 0;
            btnAddAuthor.FlatStyle = FlatStyle.Flat;
            btnAddAuthor.ForeColor = Color.White;
            btnAddAuthor.Location = new Point(400, 185);
            btnAddAuthor.Name = "btnAddAuthor";
            btnAddAuthor.Size = new Size(140, 35);
            btnAddAuthor.TabIndex = 9;
            btnAddAuthor.Text = "+ Yeni Müəllif";
            btnAddAuthor.UseVisualStyleBackColor = false;
            // 
            // cmbAuthors
            // 
            cmbAuthors.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAuthors.Font = new Font("Segoe UI", 11F);
            cmbAuthors.FormattingEnabled = true;
            cmbAuthors.Location = new Point(30, 185);
            cmbAuthors.Name = "cmbAuthors";
            cmbAuthors.Size = new Size(350, 28);
            cmbAuthors.TabIndex = 8;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(245, 246, 248);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(30, 392);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(724, 67);
            panelButtons.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(224, 224, 224);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(541, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "İmtina Et";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(22, 163, 74);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(370, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Yadda Saxla";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // numYear
            // 
            numYear.Font = new Font("Segoe UI", 11F);
            numYear.Location = new Point(30, 265);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1800, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(200, 27);
            numYear.TabIndex = 6;
            numYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 10F);
            lblYear.Location = new Point(30, 240);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(16, 19);
            lblYear.TabIndex = 4;
            lblYear.Text = "İl";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 10F);
            lblAuthor.Location = new Point(30, 160);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(50, 19);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Müəllif";
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(33, 105);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(500, 30);
            txtTitle.TabIndex = 1;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 11F);
            lblBookName.Location = new Point(30, 80);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(71, 20);
            lblBookName.TabIndex = 0;
            lblBookName.Text = "Kitab Adı";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddEditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 561);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AddEditBookForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddEditBookForm";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Label lblTitle;
        private Panel panelContent;
        private TextBox txtTitle;
        private Label lblBookName;
        private ErrorProvider errorProvider1;
        private Label lblAuthor;
        private Label lblYear;
        private Panel panelButtons;
        private Button btnSave;
        private NumericUpDown numYear;
        private Button btnCancel;
        private ComboBox cmbAuthors;
        private Button btnAddAuthor;
        private CheckBox chklsAvilable;
    }
}