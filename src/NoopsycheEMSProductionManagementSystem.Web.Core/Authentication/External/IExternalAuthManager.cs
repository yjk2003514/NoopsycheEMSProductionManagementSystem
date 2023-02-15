using System.Threading.Tasks;

namespace NoopsycheEMSProductionManagementSystem.Authentication.External
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public interface IExternalAuthManager
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task<bool> IsValidUser(string provider, string providerKey, string providerAccessCode);
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task<ExternalAuthUserInfo> GetUserInfo(string provider, string accessCode);
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
