using GameStore.Domain.Entities.Identity;
using System.Threading.Tasks;

namespace GameStore.Application.Contracts.Services.Identity
{
    public interface ITokenService
    {
        Task<string> GetTokenAsync(User user);
    }
}
