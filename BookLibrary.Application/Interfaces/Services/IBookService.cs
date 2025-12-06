using BookLibrary.Application.DTOs.Books;
using BookLibrary.Application.DTOs.Search;


namespace BookLibrary.Application.Interfaces.Services
{
    public interface IBookService
    {
        Task<List<BookDto>> GetAllBookAsync();
        Task<BookDto> GetBookByIdAsync(int id);
        Task <BookDto>AddBookAsync(CreateBookDto bookDto);
        Task UpdateBookAsync(int id, UpdateBookDto bookDto);
        Task DeleteBookAsync(int id);

        Task<List<BookDto>> SearchBookAsync(SearchBooksRequestDto request);
    }
}
