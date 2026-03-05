using BookLibrary.WinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookLibrary.WinForms.Forms
{
    public partial class AddEditBookForm : Form
    {
        private readonly BooksApiServices _booksApiServices;
        private readonly AuthorsApiService _authorsService;
        private readonly AuthApiService _authApiService;
        
        public AddEditBookForm(
            BooksApiServices booksApiServices,
            AuthorsApiService authorsService,
            AuthApiService authApiService)           
        {
            InitializeComponent();
            _booksApiServices = booksApiServices;
            _authorsService = authorsService;
            _authApiService = authApiService;

            LoadAuthors();
        }

        private void SetRoundedRegion(Control control, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            control.Region = new Region(path);
        }

        private async void LoadAuthors()
        {
            try
            {
                var authors = await _authorsService.GetAllAsync();
                // Əgər ayrıca AuthorsApiService varsa onu istifadə et

                cmbAuthors.DataSource = authors;
                cmbAuthors.DisplayMember = "FullName";
                cmbAuthors.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Author yüklənərkən xəta: " + ex.Message);
            }
        }


    }
}
