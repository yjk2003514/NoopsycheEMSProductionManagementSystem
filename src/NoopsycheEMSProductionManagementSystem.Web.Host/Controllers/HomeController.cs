using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp;
using Abp.Extensions;
using Abp.Notifications;
using Abp.Timing;
using Abp.Web.Security.AntiForgery;
using NoopsycheEMSProductionManagementSystem.Controllers;

namespace NoopsycheEMSProductionManagementSystem.Web.Host.Controllers
{
#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
    public class HomeController : NoopsycheEMSProductionManagementSystemControllerBase
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
    {
        private readonly INotificationPublisher _notificationPublisher;

#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        public HomeController(INotificationPublisher notificationPublisher)
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        {
            _notificationPublisher = notificationPublisher;
        }

#pragma warning disable CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        public IActionResult Index()
#pragma warning restore CS1591 // ȱ�ٶԹ����ɼ����ͻ��Ա�� XML ע��
        {
            return Redirect("/swagger");
        }

        /// <summary>
        /// This is a demo code to demonstrate sending notification to default tenant admin and host admin uers.
        /// Don't use this code in production !!!
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<ActionResult> TestNotification(string message = "")
        {
            if (message.IsNullOrEmpty())
            {
                message = "This is a test notification, created at " + Clock.Now;
            }

            var defaultTenantAdmin = new UserIdentifier(1, 2);
            var hostAdmin = new UserIdentifier(null, 1);

            await _notificationPublisher.PublishAsync(
                "App.SimpleMessage",
                new MessageNotificationData(message),
                severity: NotificationSeverity.Info,
                userIds: new[] { defaultTenantAdmin, hostAdmin }
            );

            return Content("Sent notification: " + message);
        }
    }
}
