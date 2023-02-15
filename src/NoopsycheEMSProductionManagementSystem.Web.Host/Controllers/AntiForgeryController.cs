using System.Threading.Tasks;
using Abp.Web.Security.AntiForgery;
using Microsoft.AspNetCore.Antiforgery;
using NoopsycheEMSProductionManagementSystem.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace NoopsycheEMSProductionManagementSystem.Web.Host.Controllers
{
#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
    public class AntiForgeryController : NoopsycheEMSProductionManagementSystemControllerBase
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
    {
        private readonly IAntiforgery _antiforgery;
        private readonly IAbpAntiForgeryManager _antiForgeryManager;

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public AntiForgeryController(IAntiforgery antiforgery, IAbpAntiForgeryManager antiForgeryManager)
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            _antiforgery = antiforgery;
            _antiForgeryManager = antiForgeryManager;
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public void GetToken()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }

#pragma warning disable CS1591 // 缺少对公共可见类型或成员的 XML 注释
        public void SetCookie()
#pragma warning restore CS1591 // 缺少对公共可见类型或成员的 XML 注释
        {
            _antiForgeryManager.SetCookie(HttpContext);
        }
    }
}
