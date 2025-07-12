using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Domain.Entities;
using BookLibrary.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


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
                .Include(br => br.User)
                .ToListAsync();
        }

        public async Task<BookRental?> GetByIdAsync(int id)
        {
            return await _context.BookRentals
                .Include(br => br.Book)
                .Include(br => br.User)
                .FirstOrDefaultAsync(br => br.Id == id);
        }

        public async Task AddAsync(BookRental bookRental)
        {
            await _context.BookRentals.AddAsync(bookRental);
           
        }

        public async Task UpdateAsync(BookRental bookRental)
        {
            _context.BookRentals.Update(bookRental);
           
        }

        public async Task DeleteAsync(BookRental bookRental)
        {
            _context.BookRentals.Remove(bookRental);
            
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
