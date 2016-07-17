using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using DemoForBoilerplate.EntityFramework;

namespace DemoForBoilerplate.Migrator
{
    [DependsOn(typeof(DemoForBoilerplateDataModule))]
    public class DemoForBoilerplateMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<DemoForBoilerplateDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}