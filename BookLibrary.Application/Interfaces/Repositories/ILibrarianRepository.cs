using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Interfaces.Repositories
{
    public interface ILibrarianRepository
    {
        Task<List<Librarian>> GetAllAsync();
        Task <Librarian> GetByIdAsync(int id);
        Task AddAsync(Librarian librarian);
        Task UpdateAsync(Librarian librarian);
        Task DeleteAsync(Librarian librarian);
    }
}
