using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Domain.Enums
{
    public enum RentalStatus
    {
        Selected = 1,
        Reserved = 2,
        Returned = 3,
        Overdue = 4,
        Lost = 5
    }
}
