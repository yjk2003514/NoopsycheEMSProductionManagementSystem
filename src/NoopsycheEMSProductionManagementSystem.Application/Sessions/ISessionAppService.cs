using System.Threading.Tasks;
using Abp.Application.Services;
using NoopsycheEMSProductionManagementSystem.Sessions.Dto;

namespace NoopsycheEMSProductionManagementSystem.Sessions
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public interface ISessionAppService : IApplicationService
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
