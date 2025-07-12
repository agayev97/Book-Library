namespace BookLibrary.Domain.Entities
{
    public class User 
    {
        public int Id { get; set; }
        public string UserName { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;
        public string PasswordSalt { get; set; } = null!;

        public string FullName { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string Email { get; set; }
        public string? FIN {  get; set; }
        public bool IsActive {  get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt {  get; set; } 

        public DateTime MembershipStartDate { get; set; } = DateTime.Now;
        public DateTime MembershipEndDate { get; set;}

        public ICollection<UserRole> UserRoles { get; set; }
      

        public ICollection<BookRental> BookRentals { get; set; } = new List<BookRental>();
       
    }
}
