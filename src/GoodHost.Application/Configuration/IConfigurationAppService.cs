using System.Threading.Tasks;
using Abp.Application.Services;
using GoodHost.Configuration.Dto;

namespace GoodHost.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}