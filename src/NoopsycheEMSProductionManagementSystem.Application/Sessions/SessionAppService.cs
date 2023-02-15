using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Auditing;
using NoopsycheEMSProductionManagementSystem.Sessions.Dto;

namespace NoopsycheEMSProductionManagementSystem.Sessions
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class SessionAppService : NoopsycheEMSProductionManagementSystemAppServiceBase, ISessionAppService
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        [DisableAuditing]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public async Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            var output = new GetCurrentLoginInformationsOutput
            {
                Application = new ApplicationInfoDto
                {
                    Version = AppVersionHelper.Version,
                    ReleaseDate = AppVersionHelper.ReleaseDate,
                    Features = new Dictionary<string, bool>()
                }
            };

            if (AbpSession.TenantId.HasValue)
            {
                output.Tenant = ObjectMapper.Map<TenantLoginInfoDto>(await GetCurrentTenantAsync());
            }

            if (AbpSession.UserId.HasValue)
            {
                output.User = ObjectMapper.Map<UserLoginInfoDto>(await GetCurrentUserAsync());
            }

            return output;
        }
    }
}
