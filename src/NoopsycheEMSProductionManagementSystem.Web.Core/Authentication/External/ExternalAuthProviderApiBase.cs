using System.Threading.Tasks;
using Abp.Dependency;

namespace NoopsycheEMSProductionManagementSystem.Authentication.External
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public abstract class ExternalAuthProviderApiBase : IExternalAuthProviderApi, ITransientDependency
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public ExternalLoginProviderInfo ProviderInfo { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public void Initialize(ExternalLoginProviderInfo providerInfo)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            ProviderInfo = providerInfo;
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public async Task<bool> IsValidUser(string userId, string accessCode)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            var userInfo = await GetUserInfo(accessCode);
            return userInfo.ProviderKey == userId;
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public abstract Task<ExternalAuthUserInfo> GetUserInfo(string accessCode);
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
