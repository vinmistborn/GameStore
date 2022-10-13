using System;

namespace GameStore.Domain.Exceptions.Base
{
    public class UnauthorizedBaseException : Exception
    {
        public UnauthorizedBaseException(string message) : base(message)
        {
        }
    }
}
