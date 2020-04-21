using Abp.Authorization;
using GoodHost.Authorization.Roles;
using GoodHost.Authorization.Users;

namespace GoodHost.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
