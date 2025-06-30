
namespace BookLibrary.Domain.Entities
{
    public class BookLocation
    {
        public int Id  { get; set; }
        public string BuildingNumber  { get; set; } = null!;
        public int    FloorNumber     { get; set; }
        public string RoomNumber      { get; set; } = null!;
        public string CabinetNumber   { get; set; } = null!;
        public string ShelfNumber     { get; set; } = null!;

        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
    }
}
