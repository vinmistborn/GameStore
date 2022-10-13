using GameStore.Domain.Exceptions.Base;

namespace GameStore.Domain.Exceptions
{
    public class ReservedException : BadRequestBaseException 
    {
        public ReservedException(string info, string type) : base($"{info} {type} is taken")
        {
        }
    }
}
