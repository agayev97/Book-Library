using BookLibrary.Application.DTOs.BookRentals;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Constants;
using BookLibrary.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BookLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class BookRentalsController : ControllerBase
    {
        private readonly IBookRentalService _bookRentalService;


        public BookRentalsController(IBookRentalService bookRentalService)
        {
            _bookRentalService = bookRentalService;

        }

        [HttpGet]
        [Authorize(Roles = $"{Roles.Admin},{Roles.Librarian}")]
        public async Task<ActionResult<List<BookRentalDto>>> GetAll()
        {
            var rentals = await _bookRentalService.GetAllRentalAsync();
            return Ok(rentals);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = $"{Roles.Admin},{Roles.Librarian}")]
        public async Task<ActionResult<BookRentalDto>> GetById(int id)
        {
            var rental = await _bookRentalService.GetRentalByIdAsync(id);
            if (rental == null) return NotFound();
            return Ok(rental);
        }


        [HttpGet("current")]
        [Authorize(Roles = $"{Roles.Admin},{Roles.User}")]
        public async Task<IActionResult> GetCurrentReading()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var result = await _bookRentalService.GetCurrentReadingBooksAsync(userId);
            return Ok(result);
        }

        [HttpGet("completed")]
        [Authorize(Roles = $"{Roles.Admin},{Roles.User}")]
        public async Task<IActionResult> GetCompleted()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var result = await _bookRentalService.GetCompletedBooksAsync(userId);
            return Ok(result);
        }

        [HttpGet("history")]
        [Authorize(Roles = $"{Roles.Admin},{Roles.User}")]
        public async Task<IActionResult> GetReadingHistory()
        {
            int userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var result = await _bookRentalService.GetReadingHistoryBooksAsync(userId);
            return Ok(result);
        }


        [HttpPost]
        [Authorize(Roles = $"{Roles.Admin},{Roles.Librarian}")]
        public async Task<ActionResult> Create(CreateBookRentalDto rentalDto)
        {
           var createdRental =  await _bookRentalService.AddBookRentalAsync(rentalDto);
            return CreatedAtAction(nameof(GetById), new { id = createdRental.Id }, createdRental);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = $"{Roles.Admin},{Roles.Librarian}")]
        public async Task<ActionResult> Update(int id, UpdateBookRentalDto rentalDto)
        {
            if(id != rentalDto.Id) return BadRequest();
            await _bookRentalService.UpdateBookRentalAsync(id, rentalDto);
            return NoContent();
        }



        [HttpPost("{id}/return")]
        [Authorize(Roles = $"{Roles.Admin},{Roles.Librarian}")]
        public async Task<IActionResult>ReturnBook(int id)
        {
            await _bookRentalService.ReturnBookAsync(id);
            return Ok();
        }

        [HttpPost("{id}/lost")]
        [Authorize(Roles = $"{Roles.Admin},{Roles.Librarian}")]
        public async Task<IActionResult>MarkLost(int id)
        {
            await _bookRentalService.MarkAsLostAsync(id);
            return Ok();
        }


        [HttpDelete("{id}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<ActionResult> Delete(int id)
        {
            var rental = await _bookRentalService.GetRentalByIdAsync(id);
            if (rental == null) return NotFound();
            await _bookRentalService.DeleteRentalAsync(id);
            return NoContent();
        }

    }
}
