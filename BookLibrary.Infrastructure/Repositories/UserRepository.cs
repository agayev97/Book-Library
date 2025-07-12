using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Domain.Entities;
using BookLibrary.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

       
        public  UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.Include(u => u.BookRentals).ToListAsync();

        }

        public async Task<User?> GetByIdAsync(int id)
        {
            return await _context.Users.Include(u => u.BookRentals).FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            
        }

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            
        }

        public async Task DeleteAsync(User user)
        {
            _context.Users.Remove(user);
           
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
