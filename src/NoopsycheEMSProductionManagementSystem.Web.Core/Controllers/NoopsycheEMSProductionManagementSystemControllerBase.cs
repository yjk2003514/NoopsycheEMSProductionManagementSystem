using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NoopsycheEMSProductionManagementSystem.Controllers
{
#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
    public abstract class NoopsycheEMSProductionManagementSystemControllerBase: AbpController
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
    {
#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        protected NoopsycheEMSProductionManagementSystemControllerBase()
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        {
            LocalizationSourceName = NoopsycheEMSProductionManagementSystemConsts.LocalizationSourceName;
        }

#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        protected void CheckErrors(IdentityResult identityResult)
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
