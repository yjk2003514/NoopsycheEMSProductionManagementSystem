using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using NoopsycheEMSProductionManagementSystem.Roles.Dto;
using NoopsycheEMSProductionManagementSystem.Users.Dto;

namespace NoopsycheEMSProductionManagementSystem.Users
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task DeActivate(EntityDto<long> user);
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task Activate(EntityDto<long> user);
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task<ListResultDto<RoleDto>> GetRoles();
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task ChangeLanguage(ChangeUserLanguageDto input);
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        Task<bool> ChangePassword(ChangePasswordDto input);
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
