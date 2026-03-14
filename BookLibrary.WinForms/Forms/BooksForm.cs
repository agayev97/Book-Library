using BookLibrary.WinForms.Models;
using BookLibrary.WinForms.Services;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class BooksForm : Form
    {
        private readonly BooksApiServices _booksService;
        private readonly AuthorsApiService _authorsService;
        private readonly AuthApiService _authApiService;
        private List<BookDto> _allBooks = new();
        public BooksForm(
            BooksApiServices booksApiServices,
            AuthorsApiService authorsApiService
,           AuthApiService authApiService)
        {
            InitializeComponent();

            _booksService = booksApiServices;
            _authorsService = authorsApiService;
            _authApiService = authApiService;

            StyleGrid();
        }

        protected override async void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            await LoadBooks();
        }

        private async Task LoadBooks()
        {
            try
            {
                var books = await _booksService.GetAllAsync();

                _allBooks = books ?? new List<BookDto>();

                dgvBooks.DataSource = null;
                dgvBooks.DataSource = _allBooks.Select(b => new
                {
                    b.Id,
                    b.Title,
                    b.PublishedYear,
                    IsAvailable = b.IsAvailable,
                    AuthorName = b.Authors != null ? string.Join(", ", b.Authors) : "N/A"
                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi:" + ex.Message);
            }
        }


        private void StyleGrid()
        {
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvBooks.EnableHeadersVisualStyles = false;

            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(240, 240, 240);

            dgvBooks.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dgvBooks.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            var filteredBooks = _allBooks
                .Where(b =>
                b.Title.ToLower().Contains(searchText) ||
                b.PublishedYear.ToString().Contains(searchText) ||
                (b.Authors != null && b.Authors.Any(a => a.ToLower().Contains(searchText)))
                )
                .Select(b => new
                {
                    b.Id,
                    b.Title,
                    b.PublishedYear,
                    IsAvailable = b.IsAvailable,
                    AuthorName = b.Authors != null ? string.Join(", ", b.Authors) : "N/A"
                })
                .ToList();

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = filteredBooks;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using (var scope = Program.Services.CreateScope())
            {
                var form = scope.ServiceProvider.GetRequiredService<AddEditBookForm>();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    await LoadBooks();
                }
            }

        }

        private int GetSelectedBookId()
        {
            if (dgvBooks.CurrentRow == null)
                return -1;
            return Convert.ToInt32(dgvBooks.CurrentRow.Cells["Id"].Value);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = GetSelectedBookId();

                if (id == -1)
                {
                    MessageBox.Show("Zəhmət olmasa silmək istədiyiniz kitabı seçin.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Bu kitabı silmək istədiyinizə əminsinizmi?",
                    "Təsdiq",
                    MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    await _booksService.DeleteAsync(id);
                    await LoadBooks();
                    MessageBox.Show("Kitab uğurla silindi.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Xəta baş verdi:" + ex.Message);

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = GetSelectedBookId();

            if (id == -1)
            {
                MessageBox.Show("Zəhmət olmasa kitab seçin.");
                return;
            }

            using(var scope = Program.Services.CreateScope())
            {
                var form = scope.ServiceProvider.GetRequiredService<AddEditBookForm>();

                form.BookId = id;

                if(form.ShowDialog() == DialogResult.OK)
                {
                     LoadBooks();
                }
            }
        }

        
    }
}
