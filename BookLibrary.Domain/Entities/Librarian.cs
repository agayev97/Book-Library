namespace BookLibrary.Domain.Entities
{
    public class Librarian : Member
    {
        public string EmployeeId { get; set; }
        public DateTime HireDate { get; set; }
    }
}
