using BookLibrary.Application.DTOs.Members;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.Librarians
{
    public class CreatedLibrarianDto : CreateMemberDto
    {
        public string EmployeeId {  get; set; }
        public DateTime HireDate {  get; set; }
    }
}
