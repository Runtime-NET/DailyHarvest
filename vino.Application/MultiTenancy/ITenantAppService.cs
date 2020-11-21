using Abp.Application.Services;
using Abp.Application.Services.Dto;
using vino.MultiTenancy.Dto;

namespace vino.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
