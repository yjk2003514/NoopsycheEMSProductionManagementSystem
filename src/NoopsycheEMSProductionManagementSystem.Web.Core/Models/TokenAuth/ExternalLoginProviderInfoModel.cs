﻿using Abp.AutoMapper;
using NoopsycheEMSProductionManagementSystem.Authentication.External;

namespace NoopsycheEMSProductionManagementSystem.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class ExternalLoginProviderInfoModel
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Name { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string ClientId { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
