using AutoMapper;
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
        private readonly IMapper _mapper;

        public BookRentalsController(IBookRentalService bookRentalService, IMapper mapper)
        {
            _bookRentalService = bookRentalService;
            _mapper = mapper;
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

        [HttpPost]
        public async Task<ActionResult> Create(BookRentalDto rentalDto)
        {
            await _bookRentalService.AddBookRentalAsync(rentalDto);
            return CreatedAtAction(nameof(GetById), new { id = rentalDto.Id }, rentalDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id,  BookRentalDto rentalDto)
        {
            if(id != rentalDto.Id) return BadRequest();
            await _bookRentalService.UpdateBookRentalAsync(rentalDto);
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
