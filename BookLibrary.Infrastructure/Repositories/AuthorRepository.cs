using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Domain.Entities;
using BookLibrary.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Infrastructure.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ApplicationDbContext _context;

        public AuthorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Author>> GetAllAsync()
        {
            return await _context.Authors.Include(a => a.BookAuthors).ThenInclude(ba => ba.Book).ToListAsync();
        }

        public async Task<Author> GetByIdAsync(int id)
        {
            var author = await _context.Authors
                .Include(a => a.BookAuthors)
                .ThenInclude(ba => ba.Book)
                .FirstOrDefaultAsync(a => a.Id == id);

            return author;
        }

        public async Task AddAsync(Author author)
        {
            await _context.Authors.AddAsync(author);
           
        }
        
        public async Task UpdateAsync(Author author)
        {
            _context.Authors.Update(author);
            
        }

        public async Task DeleteAsync(Author author)
        {
            _context.Authors.Remove(author);
           
        }

        public async Task AddBookToAuthorAsync(int authorId, int bookId)
        {
            var bookAuthor = new BookAuthor
            {
                AuthorId = authorId,
                BookId = bookId
            };

            await _context.Set<BookAuthor>().AddAsync(bookAuthor);
            
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
