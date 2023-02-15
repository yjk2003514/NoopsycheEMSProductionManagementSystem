namespace NoopsycheEMSProductionManagementSystem.Configuration.Ui
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class UiThemeInfo
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string Name { get; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public string CssClass { get; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public UiThemeInfo(string name, string cssClass)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            Name = name;
            CssClass = cssClass;
        }
    }
}
