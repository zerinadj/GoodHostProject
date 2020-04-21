using System.Collections.Generic;
using GoodHost.Roles.Dto;
using GoodHost.Users.Dto;

namespace GoodHost.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}