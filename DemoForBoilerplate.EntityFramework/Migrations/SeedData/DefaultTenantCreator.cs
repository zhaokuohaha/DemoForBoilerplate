using System.Linq;
using DemoForBoilerplate.EntityFramework;
using DemoForBoilerplate.MultiTenancy;

namespace DemoForBoilerplate.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly DemoForBoilerplateDbContext _context;

        public DefaultTenantCreator(DemoForBoilerplateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
