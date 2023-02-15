using Abp.Application.Services.Dto;
using System;

namespace NoopsycheEMSProductionManagementSystem.Users.Dto
{
    //custom PagedResultRequestDto
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class PagedUserResultRequestDto : PagedResultRequestDto
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Keyword { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public bool? IsActive { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
