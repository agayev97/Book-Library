using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookRentalsController : ControllerBase
    {
        private readonly IBookRentalRepository _bookRentalRepository;

        public BookRentalsController(IBookRentalRepository bookRentalRepository)
        {
            _bookRentalRepository = bookRentalRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<BookRental>>> GetAll()
        {
            var rentals = await _bookRentalRepository.GetAllAsync();
            return Ok(Ok(rentals));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookRental>> GetById(int id)
        {
            var rental = await _bookRentalRepository.GetByIdAsync(id);
            if (rental == null) return NotFound();
            return Ok(rental);
        }

        [HttpPost]
        public async Task<ActionResult> Create(BookRental rental)
        {
            await _bookRentalRepository.AddAsync(rental);
            return CreatedAtAction(nameof(GetById), new { id = rental.Id }, rental);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id,  BookRental rental)
        {
            if(id != rental.Id) return BadRequest();
            await _bookRentalRepository.UpdateAsync(rental);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var rental = await _bookRentalRepository.GetByIdAsync(id);
            if (rental == null) return NotFound();
            await _bookRentalRepository.DeleteAsync(rental);
            return NoContent();
        }

    }
}
