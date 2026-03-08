using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.WinForms.Models
{
    public class bookCreateDto
    { 
        public string Title { get; set; }
        public List<int> AuthorIds { get; set; } = new List<int>();
        public int PublishedYear { get; set; }
        public bool IsAvailable { get; set; }
    }
}
