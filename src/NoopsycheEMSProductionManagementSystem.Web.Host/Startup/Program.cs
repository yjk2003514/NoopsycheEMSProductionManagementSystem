using Abp.AspNetCore.Dependency;
using Abp.Dependency;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace NoopsycheEMSProductionManagementSystem.Web.Host.Startup
{
    public class Program
    {
        //Main 解释：Main 方法是程序的入口点，它是一个静态方法，用于创建一个主机构建器，用于创建主机
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        //CreateHostBuilder 是一个静态方法，用于创建一个主机构建器，用于创建主机
        internal static IHostBuilder CreateHostBuilder(string[] args) =>
            Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>().UseUrls("http://192.168.253.129:5000");//linux 运行端口号，请自行修改;
                })
                .UseCastleWindsor(IocManager.Instance.IocContainer);
    }
}
