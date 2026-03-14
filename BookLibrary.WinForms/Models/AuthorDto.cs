using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.WinForms.Models
{
    public class AuthorDto
    {
        public int Id { get; set; } 
        public string FullName { get; set; }    
        public string Biography { get; set; }
    }
}
