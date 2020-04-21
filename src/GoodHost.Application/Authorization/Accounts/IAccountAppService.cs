using System.Threading.Tasks;
using Abp.Application.Services;
using GoodHost.Authorization.Accounts.Dto;

namespace GoodHost.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
