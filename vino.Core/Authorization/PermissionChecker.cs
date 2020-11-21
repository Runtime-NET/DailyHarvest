using Abp.Authorization;
using vino.Authorization.Roles;
using vino.Authorization.Users;

namespace vino.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
