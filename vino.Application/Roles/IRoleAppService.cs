using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using vino.Roles.Dto;

namespace vino.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
