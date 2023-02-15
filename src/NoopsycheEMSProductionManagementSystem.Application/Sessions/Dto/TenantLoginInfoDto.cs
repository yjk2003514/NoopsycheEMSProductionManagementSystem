﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using NoopsycheEMSProductionManagementSystem.MultiTenancy;

namespace NoopsycheEMSProductionManagementSystem.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class TenantLoginInfoDto : EntityDto
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string TenancyName { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Name { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
