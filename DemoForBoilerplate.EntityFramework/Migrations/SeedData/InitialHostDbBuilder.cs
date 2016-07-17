using DemoForBoilerplate.EntityFramework;
using EntityFramework.DynamicFilters;

namespace DemoForBoilerplate.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly DemoForBoilerplateDbContext _context;

        public InitialHostDbBuilder(DemoForBoilerplateDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
