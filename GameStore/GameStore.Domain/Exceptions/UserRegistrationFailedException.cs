using GameStore.Domain.Exceptions.Base;

namespace GameStore.Domain.Exceptions
{
    public class UserRegistrationFailedException : BadRequestBaseException
    {
        public UserRegistrationFailedException(string message) : base(message)
        {
        }
    }
}
