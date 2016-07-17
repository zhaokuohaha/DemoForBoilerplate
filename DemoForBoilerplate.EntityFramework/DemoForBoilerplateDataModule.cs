using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using DemoForBoilerplate.EntityFramework;

namespace DemoForBoilerplate
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(DemoForBoilerplateCoreModule))]
    public class DemoForBoilerplateDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DemoForBoilerplateDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
