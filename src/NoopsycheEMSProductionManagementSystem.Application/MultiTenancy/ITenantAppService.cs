using Abp.Application.Services;
using NoopsycheEMSProductionManagementSystem.MultiTenancy.Dto;

namespace NoopsycheEMSProductionManagementSystem.MultiTenancy
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
    }
}

