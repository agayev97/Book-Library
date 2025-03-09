using AutoMapper;
using BookLibrary.Application.DTOs.BookRentals;
using BookLibrary.Application.DTOs.Books;
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
    public class BookRentalService : IBookRentalService
    {
        private readonly IBookRentalRepository _bookRentalRepository;
        private readonly IMapper _mapper;

        public BookRentalService(IBookRentalRepository bookRentalRepository, IMapper mapper)
        {
            _bookRentalRepository = bookRentalRepository;
            _mapper = mapper;
        }

        public async Task<List<BookRentalDto>> GetAllRentalAsync()
        {
            var rentals = await _bookRentalRepository.GetAllAsync();
            return _mapper.Map<List<BookRentalDto>>(rentals);
        }

        public async Task<BookRentalDto> GetRentalByIdAsync(int id)
        {
            var rental = await _bookRentalRepository.GetByIdAsync(id);
            return _mapper.Map<BookRentalDto>(rental);
        }

        public async Task AddBookRentalAsync(BookRentalDto bookRentalDto)
        {
            var bookRental = _mapper.Map<BookRental>(bookRentalDto);
            bookRental.BookRentalDate = DateTime.Now;
            await _bookRentalRepository.AddAsync(bookRental);
        }

        public async Task UpdateBookRentalAsync(BookRentalDto bookRentalDto)
        {
            var existingRental = await _bookRentalRepository.GetByIdAsync(bookRentalDto.Id);
            if (existingRental != null)
            {
                _mapper.Map(bookRentalDto, existingRental);
                await _bookRentalRepository.UpdateAsync(existingRental);
            }
        }

        public async Task DeleteRentalAsync(int id)
        {
            var rental = await _bookRentalRepository.GetByIdAsync(id);
            if(rental != null)
            {
                await _bookRentalRepository.DeleteAsync(rental);
            }
        }
    }

    
}
