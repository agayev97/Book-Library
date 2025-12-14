using BookLibrary.Application.DTOs.BookRentals;
using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Interfaces.Services
{
    public interface IBookRentalService
    {
        Task<List<BookRentalDto>> GetAllRentalAsync();
        Task<BookRentalDto> GetRentalByIdAsync(int id);

        Task<BookRentalDto> AddBookRentalAsync(CreateBookRentalDto bookRentalDto);
        Task UpdateBookRentalAsync(int id, UpdateBookRentalDto bookRentalDto);
        Task DeleteRentalAsync(int id);

        Task<List<CurrentReadingBookDto>> GetCurrentReadingBooksAsync(int userId);
        Task<List<CompletedBookDto>> GetCompletedBooksAsync(int userId);
        Task<List<ReadingHistoryDto>> GetReadingHistoryBooksAsync(int userId);

        Task ReturnBookAsync(int rentalId);
        Task ReserveBookAsync(int bookId, int userId);
        Task MarkAsLostAsync(int rentalId);
        Task MarkOverdueBooksAsync();

        
    }
}
