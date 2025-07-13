using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Domain.Entities;
using BookLibrary.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace BookLibrary.Infrastructure.Repositories
{
    public class BookLocationRepository : IBookLocationRepository
    {
        private readonly ApplicationDbContext _context;

        public BookLocationRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<BookLocation>> GetAllAsync()
        {
            return await _context.BookLocations
                .Include(bl => bl.Book)
                .ToListAsync();
        }

        public async Task<BookLocation?> GetByIdAsync(int id)
        {
            return await _context.BookLocations
                .Include(bl => bl.Book)
                .FirstOrDefaultAsync(bl => bl.Id == id);
        }

        public async Task AddAsync(BookLocation bookLocation)
        {
            await _context.BookLocations.AddAsync(bookLocation);
        }

        public async Task UpdateAsync(BookLocation bookLocation)
        {
            _context.BookLocations.Update(bookLocation);
        }

        public async Task DeleteAsync(BookLocation bookLocation)
        {
            _context.BookLocations.Remove(bookLocation);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
            
}
