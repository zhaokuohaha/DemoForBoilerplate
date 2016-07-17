using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace DemoForBoilerplate
{
    [DependsOn(typeof(DemoForBoilerplateCoreModule), typeof(AbpAutoMapperModule))]
    public class DemoForBoilerplateApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
