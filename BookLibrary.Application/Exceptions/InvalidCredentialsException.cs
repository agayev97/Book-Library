
namespace BookLibrary.Application.Exceptions
{
    public class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException() 
            : base("İstifadəçi şifrəsi yanlışdır.") { }    
    }
}
