using AutoMapper;
using BookLibrary.Application.DTOs.Books;
using BookLibrary.Application.DTOs.Search;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<List<BookDto>> GetAllBookAsync()
        {
            var books = await _bookRepository.GetAllAsync();
            return _mapper.Map<List<BookDto>>(books);
        }

        public async Task<BookDto> GetBookByIdAsync(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);
            return _mapper.Map<BookDto>(book);
        }

        public async Task <BookDto>AddBookAsync(CreateBookDto bookDto)
        {
            var book = _mapper.Map<Book>(bookDto);
            await _bookRepository.AddAsync(book);
            await _bookRepository.SaveChangesAsync();

            return _mapper.Map<BookDto>(book);
        }

        public async Task UpdateBookAsync(int id, UpdateBookDto bookDto)
        {
            var book = await _bookRepository.GetByIdAsync(bookDto.Id);

            _mapper.Map(bookDto, book);

            await _bookRepository.UpdateAsync(book);
            await _bookRepository.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _bookRepository.GetByIdAsync(id);
            if(book != null)
            {
                await _bookRepository.DeleteAsync(book);
            }

            await _bookRepository.SaveChangesAsync();
        }

        public async Task<List<BookDto>> SearchBookAsync(SearchBooksRequestDto request)
        {
            var books = await _bookRepository.SearchAsync(
                request.Title,
                request.AuthorName,
                request.PublishedYear
            );

            return _mapper.Map<List<BookDto>>(books);
        }
    }
}
