using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.BookRentals
{
    public class ReadingHistoryDto
    {
        public int RentalId { get; set; }
        public int BookId { get; set; }
        public string Title { get; set; }
        public string AuthorNames { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
