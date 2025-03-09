using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.BookRentals
{
    public class CreateBookRentalDto
    {
        public int BookId { get; set; }
        public int MemberId {  get; set; }
        public DateTime BookRentalDate {  get; set; } = DateTime.Now;
    }
}
