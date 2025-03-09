using BookLibrary.Application.DTOs.Books;
using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace BookLibrary.Application.Interfaces.Services
{
    public interface IBookService
    {
        Task<List<BookDto>> GetAllBookAsync();
        Task<BookDto> GetBookByIdAsync(int id);
        Task AddBookAsync(BookDto bookDto);
        Task UpdateBookAsync(BookDto bookDto);
        Task DeleteBookAsync(int id);
    }
}
