namespace BookLibrary.Domain.Entities
{
    public class User : Member
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? FIN {  get; set; }
        public bool IsActive {  get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdateAt {  get; set; } 

        public DateTime MembershipStartDate { get; set; } = DateTime.Now;
        public DateTime MembershipEndDate { get; set;}

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
