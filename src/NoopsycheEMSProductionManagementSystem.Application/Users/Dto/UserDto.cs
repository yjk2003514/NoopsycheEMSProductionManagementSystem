using System;
using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.Authorization.Users;
using Abp.AutoMapper;
using NoopsycheEMSProductionManagementSystem.Authorization.Users;

namespace NoopsycheEMSProductionManagementSystem.Users.Dto
{
    [AutoMapFrom(typeof(User))]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class UserDto : EntityDto<long>
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        [Required]
        [StringLength(AbpUserBase.MaxUserNameLength)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string UserName { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

        [Required]
        [StringLength(AbpUserBase.MaxNameLength)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Name { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

        [Required]
        [StringLength(AbpUserBase.MaxSurnameLength)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Surname { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string EmailAddress { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public bool IsActive { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string FullName { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public DateTime? LastLoginTime { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public DateTime CreationTime { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string[] RoleNames { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
