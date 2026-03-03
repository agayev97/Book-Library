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
    public partial class BooksForm : Form
    {
        private readonly BooksApiServices _booksService;
        private List<BookDto> _allBooks = new();
        public BooksForm(BooksApiServices booksApiServices)
        {
            InitializeComponent();
            _booksService = booksApiServices;

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
                dgvBooks.DataSource = _allBooks;
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
                b.PublishedYear.ToString().Contains(searchText))
                .ToList();

            dgvBooks.DataSource = null;
            dgvBooks.DataSource = filteredBooks;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch_TextChanged(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
