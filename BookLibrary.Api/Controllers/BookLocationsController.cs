using BookLibrary.Application.DTOs.BookLocations;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace BookLibrary.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookLocationsController :ControllerBase
    {
        private readonly IBookLocationService _service;
        public BookLocationsController(IBookLocationService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<BookLocationDto>>> GetAll() =>
            Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<BookLocationDto>> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookLocationDto dto)
        {
            await _service.AddAsync(dto);
            return Ok("Location elave olundu") ;                                                                                                                                                              
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateBookLocationDto dto)
        {
            if (id != dto.Id) return BadRequest();
            await _service.UpdateAsync(dto);
            return NoContent();
        }

        [HttpDelete("{id}")]         
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
