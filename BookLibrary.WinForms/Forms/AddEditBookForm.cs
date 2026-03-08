using BookLibrary.WinForms.Helpers;
using BookLibrary.WinForms.Models;
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

            this.Load += AddEditBookForm_Load;       
        }


        private async void AddEditBookForm_Load(object sender, EventArgs e)
        {
            await LoadAuthors();
        }

        private async Task LoadAuthors()
        {
            try
            {
                using (var client = HttpHelper.GetClient())
                {
                    var response = await client.GetAsync("api/authors");

                    if (response.IsSuccessStatusCode)
                    {
                        var authors = await response.Content.ReadAsAsync<List<AuthorDto>>();
                        cmbAuthors.DataSource = authors;
                        cmbAuthors.DisplayMember = "FullName"; // DTO-da olan ad
                        cmbAuthors.ValueMember = "Id";
                    }
                    else
                    {
                        MessageBox.Show("Müəlliflər gəlmədi. Xəta kodu: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }
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


        private async void btnAddAuthor_Click(object sender, EventArgs e)
        {
            var authorForm = new FormAuthors();
            authorForm.ShowDialog();
            await LoadAuthors(); // Yeni müəllifi əlavə etdikdən sonra müəllimləri yenidən yükləyirik

        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Kitab adı daxil edin.");
                return;
            }

            if (cmbAuthors.SelectedIndex == -1)
            {
                MessageBox.Show("Müəllif seçin.");
                return;
            }

            var bookCreateDto = new bookCreateDto
            {
                Title = txtTitle.Text,
                AuthorIds = new List<int> { (int)cmbAuthors.SelectedValue },
                PublishedYear = (int)numYear.Value,
                IsAvailable = chklsAvilable.Checked
            };

            try
            {
                await _booksApiServices.CreateAsync(bookCreateDto);

                MessageBox.Show("Kitab uğurla əlavə edildi!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }

        }

       
    }
}
