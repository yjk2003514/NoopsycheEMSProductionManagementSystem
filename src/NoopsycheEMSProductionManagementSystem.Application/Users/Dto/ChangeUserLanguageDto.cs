using System.ComponentModel.DataAnnotations;

namespace NoopsycheEMSProductionManagementSystem.Users.Dto
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class ChangeUserLanguageDto
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        [Required]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string LanguageName { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}