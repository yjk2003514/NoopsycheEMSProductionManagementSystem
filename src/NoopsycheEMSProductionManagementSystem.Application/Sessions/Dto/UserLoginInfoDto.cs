using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NoopsycheEMSProductionManagementSystem.Authorization.Users;

namespace NoopsycheEMSProductionManagementSystem.Sessions.Dto
{
    [AutoMapFrom(typeof(User))]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class UserLoginInfoDto : EntityDto<long>
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Name { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Surname { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string UserName { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string EmailAddress { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
