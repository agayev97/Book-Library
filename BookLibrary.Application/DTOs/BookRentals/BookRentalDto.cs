using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.BookRentals
{
    public class BookRentalDto
    {
        public int Id {  get; set; }
        public int BookId {  get; set; }
        public int UserId {  get; set; }
        public DateTime BookRentalDate { get; set; }
        public DateTime? ReturnDate {  get; set; }
    }
}
