using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Interfaces.Repositories
{
    public interface IBookRentalRepository
    {
        Task<List<BookRental>> GetAllAsync();
        Task<BookRental> GetByIdAsync(int id);
        Task AddAsync (BookRental bookRental);
        Task UpdateAsync(BookRental bookRental);
        Task DeleteAsync(BookRental bookRental);
        Task SaveChangesAsync();
    }
}
