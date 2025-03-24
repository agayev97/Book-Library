using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.BookRentals
{
    public class UpdateBookRentalDto
    {
        public int Id { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
