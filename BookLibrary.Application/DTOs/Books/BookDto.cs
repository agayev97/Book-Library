using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.Books
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublishedYear {  get; set; }
        public bool IsAvailable {  get; set; }
    }
}
