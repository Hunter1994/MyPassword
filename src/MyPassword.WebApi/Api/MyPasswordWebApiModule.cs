using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace MyPassword.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(MyPasswordApplicationModule))]
    public class MyPasswordWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(MyPasswordApplicationModule).Assembly, "app")
                .Build();

            //添加访问令牌类型（Access Token Types）过滤（不加这句话也支持Bearer）
            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));
        }
    }
}
