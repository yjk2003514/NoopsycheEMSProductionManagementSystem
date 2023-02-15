using System.Threading.Tasks;
using Abp.Web.Security.AntiForgery;
using Microsoft.AspNetCore.Antiforgery;
using NoopsycheEMSProductionManagementSystem.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace NoopsycheEMSProductionManagementSystem.Web.Host.Controllers
{
#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
    public class AntiForgeryController : NoopsycheEMSProductionManagementSystemControllerBase
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
    {
        private readonly IAntiforgery _antiforgery;
        private readonly IAbpAntiForgeryManager _antiForgeryManager;

#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        public AntiForgeryController(IAntiforgery antiforgery, IAbpAntiForgeryManager antiForgeryManager)
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        {
            _antiforgery = antiforgery;
            _antiForgeryManager = antiForgeryManager;
        }

#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        public void GetToken()
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }

#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        public void SetCookie()
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        {
            _antiForgeryManager.SetCookie(HttpContext);
        }
    }
}
