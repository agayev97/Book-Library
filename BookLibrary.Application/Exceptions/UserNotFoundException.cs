

namespace BookLibrary.Application.Exceptions
{
    public class UserNotFoundException : Exception
    {
        public UserNotFoundException()
            : base("İstifadəçi tapılmadı.") { }
        
         public UserNotFoundException(string message)
            : base(message){ }
        
    }
}
