using GameStore.Domain.Exceptions.Base;

namespace GameStore.Domain.Exceptions
{
    public class ImageException : BadRequestBaseException
    {
        public ImageException(string message) : base(message)
        {
        }
    }
}
