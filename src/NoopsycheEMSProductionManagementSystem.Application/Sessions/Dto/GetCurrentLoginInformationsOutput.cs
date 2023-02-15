namespace NoopsycheEMSProductionManagementSystem.Sessions.Dto
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class GetCurrentLoginInformationsOutput
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public ApplicationInfoDto Application { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public UserLoginInfoDto User { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public TenantLoginInfoDto Tenant { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    }
}
