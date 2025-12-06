using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.Search
{
    public class SearchBooksRequestDto
    {
        public string? Title {  get; set; }
        public string? AuthorName { get; set; }
        public int? PublishedYear { get; set; }
        
    }
}
