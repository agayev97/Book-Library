using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace BookLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _authorsRepository;

        public AuthorsController(IAuthorRepository authorsRepository)
        {
            _authorsRepository = authorsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Author>>> GetAll()
        {
            var authors = await _authorsRepository.GetAllAsync();
            return Ok(authors);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Author>>> GetById(int id)
        {
            var author = await _authorsRepository.GetByIdAsync(id);
            if (author == null) return NotFound();
            return Ok(author);
        }

        [HttpPost]
        public async Task<ActionResult> Create (Author author)
        {
            await _authorsRepository.AddAsync(author);
            return CreatedAtAction(nameof(GetById), new { id = author.Id }, author);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Author author)
        {
            if (id != author.Id) return BadRequest();
            await _authorsRepository.UpdateAsync(author);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var author = await _authorsRepository.GetByIdAsync(id);
            if (author == null) return NotFound();
            await _authorsRepository.DeleteAsync(author);
            return NoContent();
        }
    }
}
