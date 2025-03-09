namespace BookLibrary.Domain.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<BookRental> BookRentals { get; set; } = new List<BookRental>();
       
    }
}
