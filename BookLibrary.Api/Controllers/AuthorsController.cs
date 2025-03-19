using BookLibrary.Application.DTOs.Authors;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace BookLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;


        public AuthorsController(IAuthorService authorService)
        { 
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<AuthorDto>>> GetAll()
        {
            var authors = await _authorService.GetAllAuthorsAsync();
            return Ok(authors);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<AuthorDto>>> GetById(int id)
        {
            var author = await _authorService.GetByIdAsync(id);
            if (author == null) return NotFound();
            return Ok(author);
        }

        [HttpPost]
        public async Task<ActionResult> Create (CreateAuthorDto authorDto)
        {
            var createdAuthor = await _authorService.AddAuthorAsync(authorDto);
            return CreatedAtAction(nameof(GetById), new { id = createdAuthor.Id }, createdAuthor);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, AuthorDto authorDto)
        {
            if (id != authorDto.Id) return BadRequest();
            await _authorService.UpdateAuthorAsync(authorDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var author = await _authorService.GetByIdAsync(id);
            if (author == null) return NotFound();
            await _authorService.DeleteAuthorAsync(id);
            return NoContent();
        }
    }
}
