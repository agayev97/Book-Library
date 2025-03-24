using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Application.DTOs.Members
{
    public class CreateMemberDto
    {
        public string FullName {  get; set; }   
        public string Email {  get; set; }
        public string PhoneNumber {  get; set; }

    }
}
