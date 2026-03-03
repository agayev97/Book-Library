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
            panelButtons = new Panel();
            btnCancel = new Button();
            btnSave = new Button();
            numYear = new NumericUpDown();
            lblYear = new Label();
            txtAuthor = new TextBox();
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
            panelHeader.Size = new Size(800, 60);
            panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(44, 62, 80);
            lblTitle.Location = new Point(12, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(166, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Kitab İdarəetməsi";
            // 
            // panelContent
            // 
            panelContent.Controls.Add(panelButtons);
            panelContent.Controls.Add(numYear);
            panelContent.Controls.Add(lblYear);
            panelContent.Controls.Add(txtAuthor);
            panelContent.Controls.Add(lblAuthor);
            panelContent.Controls.Add(txtTitle);
            panelContent.Controls.Add(lblBookName);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 60);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(30);
            panelContent.Size = new Size(800, 390);
            panelContent.TabIndex = 1;
            // 
            // panelButtons
            // 
            panelButtons.BackColor = Color.FromArgb(245, 246, 248);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Controls.Add(btnSave);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(30, 290);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(740, 70);
            panelButtons.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(224, 224, 224);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(581, 17);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(130, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "İmtina Et";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(39, 174, 96);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(423, 17);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Yadda Saxla";
            btnSave.UseVisualStyleBackColor = false;
            
            // 
            // numYear
            // 
            numYear.Font = new Font("Segoe UI", 10F);
            numYear.Location = new Point(33, 216);
            numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1500, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(320, 25);
            numYear.TabIndex = 6;
            numYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI", 10F);
            lblYear.Location = new Point(30, 190);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(16, 19);
            lblYear.TabIndex = 4;
            lblYear.Text = "İl";
           
            // 
            // txtAuthor
            // 
            txtAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtAuthor.Font = new Font("Segoe UI", 10F);
            txtAuthor.Location = new Point(33, 131);
            txtAuthor.Multiline = true;
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(320, 30);
            txtAuthor.TabIndex = 3;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI", 10F);
            lblAuthor.Location = new Point(30, 100);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(50, 19);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Müəllif";
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Segoe UI", 10F);
            txtTitle.Location = new Point(33, 50);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(320, 30);
            txtTitle.TabIndex = 1;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Font = new Font("Segoe UI", 11F);
            lblBookName.Location = new Point(30, 20);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.None;
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
        private TextBox txtAuthor;
        private Label lblAuthor;
        private Label lblYear;
        private Panel panelButtons;
        private Button btnSave;
        private NumericUpDown numYear;
        private Button btnCancel;
    }
}