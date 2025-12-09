using BookLibrary.Application.DTOs.Books;
using BookLibrary.Application.DTOs.Search;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace BookLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase 
    {
        private readonly IBookService _bookService;
       

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
            
        }

        [HttpGet]
        public async Task<ActionResult<List<BookDto>>> GetAll()
        {
            var books = await _bookService.GetAllBookAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookDto>> GetById(int id)
        {
            var book = await _bookService.GetBookByIdAsync(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateBookDto bookDto)
        {
            var createBook = await _bookService.AddBookAsync(bookDto);
            return CreatedAtAction(nameof(GetById), new {id = createBook.Id}, createBook);
        }

        [HttpPost("search")]
        public async Task<IActionResult> Search([FromBody] SearchBooksRequestDto request)
        {
            var result = await _bookService.SearchBookAsync(request);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateBookDto bookDto)
        {
            if (id != bookDto.Id) return BadRequest();
            await _bookService.UpdateBookAsync(id, bookDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var book = await _bookService.GetBookByIdAsync(id);
            if (book == null) return NotFound();
            await _bookService.DeleteBookAsync(id);
            return NoContent() ;
        }
    }
}
