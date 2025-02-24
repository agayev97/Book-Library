using BookLibrary.Application.Interfaces.Repositories;
using BookLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.Services
{
    public class BookRentalService
    {
        private readonly IBookRentalRepository _bookRentalRepository;

        public BookRentalService(IBookRentalRepository bookRentalRepository)
        {
            _bookRentalRepository = bookRentalRepository;
        }

        public async Task<List<BookRental>> GetAllRentalAsync()
        {
            return await _bookRentalRepository.GetAllAsync();
        }

        public async Task<BookRental> GetRentalByIdAsync(int id)
        {
            return await _bookRentalRepository.GetByIdAsync(id);
        }

        public async Task RentBookAsync(BookRental bookRental)
        {
            bookRental.BookRentalDate = DateTime.Now;
            await _bookRentalRepository.AddAsync(bookRental);
        }

        public async Task ReturnBookAsync(int rentalId, DateTime returnDate)
        {
            var rental = await _bookRentalRepository.GetByIdAsync(rentalId);
            if(rental != null)
            {
                rental.ReturnDate = returnDate;
                await _bookRentalRepository.UpdateAsync(rental);
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
