using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GoodHost.MultiTenancy.Dto;

namespace GoodHost.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
