using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using DemoForBoilerplate.Migrations.SeedData;
using EntityFramework.DynamicFilters;
using DemoForBoilerplate.MyPeople;

namespace DemoForBoilerplate.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<DemoForBoilerplate.EntityFramework.DemoForBoilerplateDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "DemoForBoilerplate";
        }


		protected override void Seed(DemoForBoilerplate.EntityFramework.DemoForBoilerplateDbContext context)
        {
            context.DisableAllFilters();
			context.People.AddOrUpdate(
				p => p.Name,
				new MyPerson { Name = "�Դ�" },
				new MyPerson { Name = "Ǯ��" },
				new MyPerson { Name = "����" },
				new MyPerson { Name = "��ʯ" }
			);
			if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
				//You can add seed for tenant databases and use Tenant property...
			}
            context.SaveChanges();
        }
    }
}
