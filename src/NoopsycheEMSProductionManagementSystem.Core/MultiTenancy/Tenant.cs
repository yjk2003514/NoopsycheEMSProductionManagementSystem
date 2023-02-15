using Abp.MultiTenancy;
using NoopsycheEMSProductionManagementSystem.Authorization.Users;

namespace NoopsycheEMSProductionManagementSystem.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
