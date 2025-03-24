using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Domain.Entities;
using BookLibrary.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllAsync()
        {
            return await _context.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).ToListAsync();
        }

        public async Task<Book> GetByIdAsync(int id)
        {
            return await _context.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task AddAsync(Book book)
        {
            await _context.Books.AddAsync(book);
            
        }

        public async Task UpdateAsync(Book book)
        {
            _context.Books.Update(book);
            
        }

        public async Task DeleteAsync(Book book)
        {
            _context.Books.Remove(book);
            
        }

        public async Task AddAuthorToBookAsync(int bookId, int authorId)
        {
            var bookAuthor = new BookAuthor
            {
                BookId = bookId,
                AuthorId = authorId
            };

            await _context.Set<BookAuthor>().AddAsync(bookAuthor);
            
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
