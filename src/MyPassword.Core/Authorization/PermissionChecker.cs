using Abp.Authorization;
using MyPassword.Authorization.Roles;
using MyPassword.Authorization.Users;

namespace MyPassword.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
