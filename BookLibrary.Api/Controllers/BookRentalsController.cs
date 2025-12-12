using BookLibrary.Application.DTOs.BookRentals;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookRentalsController : ControllerBase
    {
        private readonly IBookRentalService _bookRentalService;


        public BookRentalsController(IBookRentalService bookRentalService)
        {
            _bookRentalService = bookRentalService;

        }

        [HttpGet]
        public async Task<ActionResult<List<BookRentalDto>>> GetAll()
        {
            var rentals = await _bookRentalService.GetAllRentalAsync();
            return Ok(rentals);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BookRentalDto>> GetById(int id)
        {
            var rental = await _bookRentalService.GetRentalByIdAsync(id);
            if (rental == null) return NotFound();
            return Ok(rental);
        }


        [HttpGet("current/{userId}")]
        public async Task<IActionResult> GetCurrentReading(int userId)
        {
            var result = await _bookRentalService.GetCurrentReadingBooksAsync(userId);
            return Ok(result);
        }

        [HttpGet("completed/{userId}")]
        public async Task<IActionResult> GetCompleted(int userId)
        {
            var result = await _bookRentalService.GetCompletedBooksAsync(userId);
            return Ok(result);
        }

        [HttpGet("history/{userId}")]
        public async Task<IActionResult> GetReadingHistory(int userId)
        {
            var result = await _bookRentalService.GetReadingHistoryBooksAsync(userId);
            return Ok(result);
        }


        [HttpPost]
        public async Task<ActionResult> Create(CreateBookRentalDto rentalDto)
        {
           var createdRental =  await _bookRentalService.AddBookRentalAsync(rentalDto);
            return CreatedAtAction(nameof(GetById), new { id = createdRental.Id }, createdRental);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, UpdateBookRentalDto rentalDto)
        {
            if(id != rentalDto.Id) return BadRequest();
            await _bookRentalService.UpdateBookRentalAsync(id, rentalDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var rental = await _bookRentalService.GetRentalByIdAsync(id);
            if (rental == null) return NotFound();
            await _bookRentalService.DeleteRentalAsync(id);
            return NoContent();
        }

    }
}
