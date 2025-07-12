using BookLibrary.Domain.Entities;

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
