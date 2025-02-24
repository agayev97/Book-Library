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
    public class LibrarianRepository : ILibrarianRepository
    {
        private readonly ApplicationDbContext _context;

        public LibrarianRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Librarian>> GetAllAsync()
        {
            return await _context.Members
                .OfType<Librarian>()
                .ToListAsync();
        }

        public async Task<Librarian> GetByIdAsync(int id)
        {
            return await _context.Members
                .OfType<Librarian>()
                .FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task AddAsync(Librarian librarian)
        {
            await _context.Members.AddAsync(librarian);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Librarian librarian)
        {
            _context.Members.Update(librarian);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Librarian librarian)
        {
            _context.Members.Remove(librarian);
            await _context.SaveChangesAsync();
        }
    }
}
