using System.Threading.Tasks;
using Abp.Application.Services;
using NoopsycheEMSProductionManagementSystem.Authorization.Accounts.Dto;

namespace NoopsycheEMSProductionManagementSystem.Authorization.Accounts
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public interface IAccountAppService : IApplicationService
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task<RegisterOutput> Register(RegisterInput input);
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
