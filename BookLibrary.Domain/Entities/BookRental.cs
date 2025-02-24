using System.ComponentModel.DataAnnotations.Schema;

namespace BookLibrary.Domain.Entities
{
    public class BookRental
    {
        public int Id { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int MemberId { get; set; }
        [ForeignKey("MemberId")]
        public Member Member { get; set; }

        public DateTime BookRentalDate { get; set; } = DateTime.Now;
        public DateTime? ReturnDate { get; set; }
    }
}
