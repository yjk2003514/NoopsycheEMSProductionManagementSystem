namespace NoopsycheEMSProductionManagementSystem.Authorization.Accounts.Dto
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class IsTenantAvailableOutput
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public TenantAvailabilityState State { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public int? TenantId { get; set; }
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public IsTenantAvailableOutput()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public IsTenantAvailableOutput(TenantAvailabilityState state, int? tenantId = null)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            State = state;
            TenantId = tenantId;
        }
    }
}
