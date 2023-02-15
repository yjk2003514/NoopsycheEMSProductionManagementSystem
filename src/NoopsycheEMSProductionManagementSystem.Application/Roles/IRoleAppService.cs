using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NoopsycheEMSProductionManagementSystem.Roles.Dto;

namespace NoopsycheEMSProductionManagementSystem.Roles
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedRoleResultRequestDto, CreateRoleDto, RoleDto>
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task<GetRoleForEditOutput> GetRoleForEdit(EntityDto input);
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task<ListResultDto<RoleListDto>> GetRolesAsync(GetRolesInput input);
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
