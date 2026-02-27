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
        public MainForm()
        {
            InitializeComponent();


            ApplyTheme();
            StyleMenuButtons();
            StyleGrid();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
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

        private void StyleGrid()
        {
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvBooks.EnableHeadersVisualStyles = false;

            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(240, 240, 240);

            dgvBooks.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvBooks.DefaultCellStyle.SelectionForeColor =
                Color.Black;

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
