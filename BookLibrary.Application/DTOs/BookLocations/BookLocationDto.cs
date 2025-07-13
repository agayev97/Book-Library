using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.BookLocations
{
    public class BookLocationDto
    {
        public int Id                { get; set; }
        public string BuildingNumber { get; set; } = null!;
        public int FloorNumber       { get; set; }
        public string RoomNumber     { get; set; } = null!;
        public string CabinetNumber  { get; set; } = null!;
        public string ShelfNumber    { get; set; } = null!;
        public int BookId            { get; set; }

    }
}
