using BookLibrary.Application.DTOs.BookLocations;

namespace BookLibrary.Application.Interfaces.Services
{
    public interface IBookLocationService
    {
        Task<List<BookLocationDto>> GetAllAsync();
        Task<BookLocationDto> GetByIdAsync(int id);
        Task AddAsync(CreateBookLocationDto dto);
        Task UpdateAsync(UpdateBookLocationDto dto);
        Task DeleteAsync(int id);
    }
}
