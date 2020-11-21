using System.Threading.Tasks;
using Abp.Application.Services;
using vino.Configuration.Dto;

namespace vino.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}