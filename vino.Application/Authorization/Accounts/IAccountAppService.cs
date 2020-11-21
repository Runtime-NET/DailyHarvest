using System.Threading.Tasks;
using Abp.Application.Services;
using vino.Authorization.Accounts.Dto;

namespace vino.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
