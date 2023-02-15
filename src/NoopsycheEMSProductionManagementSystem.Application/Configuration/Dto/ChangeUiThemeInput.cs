using System.ComponentModel.DataAnnotations;

namespace NoopsycheEMSProductionManagementSystem.Configuration.Dto
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class ChangeUiThemeInput
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        [Required]
        [StringLength(32)]
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Theme { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
