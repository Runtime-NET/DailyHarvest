using System.Threading.Tasks;
using Abp.Application.Services;
using vino.Sessions.Dto;

namespace vino.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
