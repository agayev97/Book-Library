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
    public class BookRentalRepository : IBookRentalRepository
    {
        private readonly ApplicationDbContext _context;

        public BookRentalRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<BookRental>> GetAllAsync()
        {
            return await _context.BookRentals
                .Include(br => br.Book)
                .Include(br => br.Member)
                .ToListAsync();
        }

        public async Task<BookRental> GetByIdAsync(int id)
        {
            return await _context.BookRentals
                .Include(br => br.Book)
                .Include(br => br.Member)
                .FirstOrDefaultAsync(br => br.Id == id);
        }

        public async Task AddAsync(BookRental bookRental)
        {
            await _context.BookRentals.AddAsync(bookRental);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(BookRental bookRental)
        {
            _context.BookRentals.Update(bookRental);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(BookRental bookRental)
        {
            _context.BookRentals.Remove(bookRental);
            await _context.SaveChangesAsync();
        }
    }
}
