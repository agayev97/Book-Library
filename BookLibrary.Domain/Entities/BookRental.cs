using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibrary.Domain.Entities
{
    public class BookRental
    {
       
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public DateTime BookRentalDate { get; set; } = DateTime.Now;
        public DateTime? ReturnDate { get; set; }
    }
}
