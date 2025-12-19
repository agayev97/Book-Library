

namespace BookLibrary.Application.Exceptions
{
    public class RoleNotFoundException : Exception
    {
        public RoleNotFoundException() 
            :base ("Rol tapılmadı və ya deaktivdir."){ }

        public RoleNotFoundException(string message)
            :base(message) { }


    }
}
