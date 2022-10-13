using GameStore.Domain.Exceptions.Base;

namespace GameStore.Domain.Exceptions
{
    public class LoginFailedException : UnauthorizedBaseException
    {
        public LoginFailedException() : base("Invalid User Name or Password was entered")
        {
        }
    }
}
