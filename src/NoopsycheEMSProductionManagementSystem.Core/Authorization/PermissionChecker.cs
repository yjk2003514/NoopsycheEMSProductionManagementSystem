using Abp.Authorization;
using NoopsycheEMSProductionManagementSystem.Authorization.Roles;
using NoopsycheEMSProductionManagementSystem.Authorization.Users;

namespace NoopsycheEMSProductionManagementSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
