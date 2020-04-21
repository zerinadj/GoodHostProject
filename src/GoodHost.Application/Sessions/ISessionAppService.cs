using System.Threading.Tasks;
using Abp.Application.Services;
using GoodHost.Sessions.Dto;

namespace GoodHost.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
