using Abp.Authorization;
using DemoForBoilerplate.Authorization.Roles;
using DemoForBoilerplate.MultiTenancy;
using DemoForBoilerplate.Users;

namespace DemoForBoilerplate.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
