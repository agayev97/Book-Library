using AutoMapper;
using BookLibrary.Application.DTOs.BookRentals;
using BookLibrary.Application.DTOs.Books;
using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Application.Interfaces.Services;
using BookLibrary.Domain.Entities;
using BookLibrary.Domain.Enums;
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

        public async Task <BookRentalDto>AddBookRentalAsync(CreateBookRentalDto bookRentalDto)
        {
            var bookRental = _mapper.Map<BookRental>(bookRentalDto);
            bookRental.BookRentalDate = DateTime.Now;
            bookRental.DueDate = DateTime.Now.AddDays(bookRentalDto.RentalDays);
            bookRental.Status = RentalStatus.Selected;

            await _bookRentalRepository.AddAsync(bookRental);
            await _bookRentalRepository.SaveChangesAsync();

            return _mapper.Map<BookRentalDto>(bookRental);
        }

        public async Task UpdateBookRentalAsync(int id, UpdateBookRentalDto bookRentalDto)
        {
            var existingRental = await _bookRentalRepository.GetByIdAsync(bookRentalDto.Id);
            if (existingRental != null)
            {
                _mapper.Map(bookRentalDto, existingRental);
                await _bookRentalRepository.UpdateAsync(existingRental);
            }

            await _bookRentalRepository.SaveChangesAsync();
        }

        public async Task DeleteRentalAsync(int id)
        {
            var rental = await _bookRentalRepository.GetByIdAsync(id);
            if(rental != null)
            {
                await _bookRentalRepository.DeleteAsync(rental);
            }
            await _bookRentalRepository.SaveChangesAsync();
        }


        public async Task<List<CurrentReadingBookDto>> GetCurrentReadingBooksAsync(int userId)
        {
            var rentals = await _bookRentalRepository.GetCurrentReadingBooksAsync(userId);
            return _mapper.Map<List<CurrentReadingBookDto>>(rentals);
        }
        
        public async Task<List<CompletedBookDto>> GetCompletedBooksAsync(int userId)
        {
            var rentals = await _bookRentalRepository.GetCompletedBooksAsync(userId);
            return _mapper.Map<List<CompletedBookDto>>(rentals);
        }

        public async Task<List<ReadingHistoryDto>>  GetReadingHistoryBooksAsync(int userId)
        {
            var rentals = await _bookRentalRepository.GetReadingHistoryAsync(userId);
            return _mapper.Map< List< ReadingHistoryDto >> (rentals);

        }

        public async Task ReturnBookAsync(int rentalId)
        {
            var rental = await _bookRentalRepository.GetByIdAsync(rentalId);
            if (rental == null) return;

            rental.ReturnDate = DateTime.Now;
            rental.Status = RentalStatus.Returned;

            await _bookRentalRepository.UpdateAsync(rental);
            await _bookRentalRepository.SaveChangesAsync();
        }

        public async Task ReserveBookAsync(int bookId, int userId)
        {
            var rental = new BookRental
            {
                BookId = bookId ,
                UserId = userId ,
                BookRentalDate = DateTime.Now,
                Status = RentalStatus.Reserved
            };

            await _bookRentalRepository.AddAsync(rental);
            await _bookRentalRepository.SaveChangesAsync();
        }

        public async Task MarkAsLostAsync(int rentalId)
        {
            var rental = await _bookRentalRepository.GetByIdAsync(rentalId);
            if(rental == null) return;

            rental.Status = RentalStatus.Lost;

            await _bookRentalRepository.UpdateAsync(rental);
            await _bookRentalRepository.SaveChangesAsync();
        }

        public async Task MarkOverdueBooksAsync()
        {
            var rentals = await _bookRentalRepository.GetActiveRentalsAsync();

            foreach(var rental in rentals )
            {
                if(rental.DueDate.HasValue && rental.DueDate < DateTime.Now)
                {
                    rental.Status = RentalStatus.Overdue;
                }
            }

            await _bookRentalRepository.SaveChangesAsync();
        }


    }

    
}
