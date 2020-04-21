using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using GoodHost.Roles.Dto;
using GoodHost.Users.Dto;

namespace GoodHost.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}