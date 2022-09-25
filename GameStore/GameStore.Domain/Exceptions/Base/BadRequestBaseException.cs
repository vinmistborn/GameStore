using System;

namespace GameStore.Domain.Exceptions.Base
{
    public class BadRequestBaseException : Exception
    {
        public BadRequestBaseException(string message) : base(message)
        {
        }
    }
}
