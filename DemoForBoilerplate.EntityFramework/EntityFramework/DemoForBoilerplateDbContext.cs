using System.Data.Common;
using Abp.Zero.EntityFramework;
using DemoForBoilerplate.Authorization.Roles;
using DemoForBoilerplate.MultiTenancy;
using DemoForBoilerplate.Users;
using System.Data.Entity;

namespace DemoForBoilerplate.EntityFramework
{
    public class DemoForBoilerplateDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
		public virtual IDbSet<MyTasks.MyTask> Tasks { get; set; }
		public virtual IDbSet<MyPeople.MyPerson> People { get; set; }
        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public DemoForBoilerplateDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in DemoForBoilerplateDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of DemoForBoilerplateDbContext since ABP automatically handles it.
         */
        public DemoForBoilerplateDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public DemoForBoilerplateDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
