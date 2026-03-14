using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.WinForms.Models
{
    public class UpdateBookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublishedYear { get; set; }
        public bool IsAvailable { get; set; }
        public List<int> AuthorIds { get; set; } 

    }
}
