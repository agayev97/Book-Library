using BookLibrary.WinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BookLibrary.WinForms.Forms
{
    public partial class MainForm : Form
    {
        private readonly BooksApiServices _booksService;
        private Form activeForm = null;

        public MainForm(BooksApiServices booksService)
        {
            _booksService = booksService ?? throw new ArgumentNullException(nameof(booksService));

            InitializeComponent();
            this.Resize += MainForm_Resize;

            ApplyTheme();
            StyleMenuButtons();
           
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdatePanelRegions();
            SetRoundedPanel(panelSidebar, 25);
            SetRoundedPanel(panelCard, 20);
        }


        private void ApplyTheme()
        {
            this.BackColor = Color.FromArgb(240, 244, 249);
            panelSidebar.BackColor = Color.FromArgb(30, 41, 59);
            panelHeader.Paint += panelHeader_Paint;
            panelCard.BackColor = Color.White;
        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush =
                new LinearGradientBrush(panelHeader.ClientRectangle,
                Color.FromArgb(86, 125, 210),
                Color.FromArgb(120, 160, 220),
                0f))
            { e.Graphics.FillRectangle(brush, panelHeader.ClientRectangle); }
        }

        private void StyleMenuButtons()
        {
            Button[] buttons =
            {
                btnDash,
                btnBook,
                btnAuthor,
                btnRental,
                btnUser
            };

            foreach (var btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Height = 50;
                btn.ForeColor = Color.White;
                btn.BackColor = Color.FromArgb(30, 41, 59);
                btn.Font = new Font("Segoe UI", 10);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Padding = new Padding(20, 0, 0, 0);

                btn.FlatAppearance.MouseOverBackColor =
                    Color.FromArgb(51, 65, 85);

                btn.Click += (s, e) =>
                {
                    ResetMenu(buttons);
                    btn.BackColor = Color.FromArgb(51, 65, 85);
                };
            }

        }

        private void ResetMenu(Button[] buttons)
        {
            foreach (var btn in buttons)
            {
                btn.BackColor = Color.FromArgb(30, 41, 59);
            }
        }

        private void OpenForm(Form form)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm.Dispose();
            }

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelCard.Controls.Clear();
            panelCard.Controls.Add(form);
            panelCard.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) return;

            panelHeader.Invalidate();
            UpdatePanelRegions();
        }

        private void UpdatePanelRegions()
        {
            if (panelSidebar.Width > 0 && panelSidebar.Height > 0)
                SetRoundedPanel(panelSidebar, 25);

            if (panelCard.Width > 0 && panelCard.Height > 0)
                SetRoundedPanel(panelCard, 20);
        }


        private  void btnBook_Click(object sender, EventArgs e)
        {
            OpenForm(new BooksForm(_booksService));

        }

        private void SetRoundedPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(panel.Width - radius, panel.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius, radius, radius), 90, 90);

            path.CloseFigure();
            panel.Region = new Region(path);
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= 0x20000;
                return cp;
            }
        }
    }
}
