using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;

namespace NoopsycheEMSProductionManagementSystem.Models.TokenAuth
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class ExternalAuthenticateModel
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        [Required]
        [StringLength(UserLogin.MaxLoginProviderLength)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string AuthProvider { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

        [Required]
        [StringLength(UserLogin.MaxProviderKeyLength)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string ProviderKey { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

        [Required]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string ProviderAccessCode { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
