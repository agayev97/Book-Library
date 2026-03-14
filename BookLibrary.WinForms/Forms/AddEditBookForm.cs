using BookLibrary.WinForms.Helpers;
using BookLibrary.WinForms.Models;
using BookLibrary.WinForms.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
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
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int? BookId { get; set; } // Redaktə üçün kitab ID-si, əlavə üçün null olacaq

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

            if (BookId.HasValue)
            {
                await LoadBook();
            }
        }

        private async Task LoadBook()
        {
            try
            {
                var book = await _booksApiServices.GetByIdAsync(BookId.Value);

                txtTitle.Text = book.Title;
                numYear.Value = book.PublishedYear;

                // Ensure we use the AuthorIds collection when selecting the author
                if (book.AuthorIds != null && book.AuthorIds.Count > 0)
                {
                    cmbAuthors.SelectedValue = book.AuthorIds.FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitab məlumatları gəlmədi: " + ex.Message);
            }
        }

        private async Task LoadAuthors()
        {
            try
            {
                var authors = await _authorsService.GetAllAsync();
                authors ??= new List<AuthorDto>();

                cmbAuthors.DataSource = authors;
                cmbAuthors.DisplayMember = "FullName"; // DTO-da olan ad
                cmbAuthors.ValueMember = "Id";
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
            await LoadAuthors(); // Yeni müəllifi əlavə etdikdən sonra müəllifləri yenidən yükləyirik

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

            try
            {
                if (BookId == null)
                {
                    var bookCreateDto = new BookCreateDto
                    {
                        Title = txtTitle.Text,
                        AuthorIds = new List<int> { (int)cmbAuthors.SelectedValue },
                        PublishedYear = (int)numYear.Value,
                        IsAvailable = chklsAvilable.Checked
                    };

                    await _booksApiServices.CreateAsync(bookCreateDto);

                    MessageBox.Show("Kitab uğurla əlavə edildi!");

                }
                else
                {
                    var updateDto = new UpdateBookDto
                    {
                        Id = BookId.Value,
                        Title = txtTitle.Text,
                        AuthorIds = new List<int> { (int)cmbAuthors.SelectedValue },
                        PublishedYear = (int)numYear.Value,
                        IsAvailable = chklsAvilable.Checked
                    };

                    await _booksApiServices.UpdateAsync(BookId.Value, updateDto);
                    MessageBox.Show("Kitab uğurla yeniləndi!");

                }

                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi: " + ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
