namespace NoopsycheEMSProductionManagementSystem.Authorization.Accounts.Dto
{
#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
    public class IsTenantAvailableOutput
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
    {
#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        public TenantAvailabilityState State { get; set; }
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��

#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        public int? TenantId { get; set; }
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��

#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        public IsTenantAvailableOutput()
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        {
        }

#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        public IsTenantAvailableOutput(TenantAvailabilityState state, int? tenantId = null)
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        {
            State = state;
            TenantId = tenantId;
        }
    }
}
