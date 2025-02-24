namespace BookLibrary.Domain.Entities
{
    public class User : Member
    {
        public DateTime MembershipStartDate { get; set; } = DateTime.Now;
        public DateTime MembershipEndDate { get; set;}
    }
}
