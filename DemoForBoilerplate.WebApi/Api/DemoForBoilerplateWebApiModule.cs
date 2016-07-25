using System.Reflection;
using System.Web.Http;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;
using DemoForBoilerplate.MyTasks;

namespace DemoForBoilerplate.Api
{
    [DependsOn(typeof(AbpWebApiModule), typeof(DemoForBoilerplateApplicationModule))]
    public class DemoForBoilerplateWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(DemoForBoilerplateApplicationModule).Assembly, "app")
                .Build();
		//	DynamicApiControllerBuilder.ForAll<IMyTaskAppService>(typeof(DemoForBoilerplateApplicationModule).Assembly, "task").Build();
            Configuration.Modules.AbpWebApi().HttpConfiguration.Filters.Add(new HostAuthenticationFilter("Bearer"));
        }
    }
}
