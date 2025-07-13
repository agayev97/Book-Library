using BookLibrary.Domain.Entities;


namespace BookLibrary.Application.Interfaces.Repositories
{
   public interface IBookLocationRepository
    {
        Task<List<BookLocation>> GetAllAsync();
        Task<BookLocation> GetByIdAsync(int id);
        Task AddAsync(BookLocation bookLocation);
        Task UpdateAsync(BookLocation bookLocation);
        Task DeleteAsync(BookLocation bookLocation);
        Task SaveChangesAsync();
    }
}
