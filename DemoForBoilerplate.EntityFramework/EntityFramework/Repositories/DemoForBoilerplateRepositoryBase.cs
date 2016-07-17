using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace DemoForBoilerplate.EntityFramework.Repositories
{
    public abstract class DemoForBoilerplateRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<DemoForBoilerplateDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected DemoForBoilerplateRepositoryBase(IDbContextProvider<DemoForBoilerplateDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class DemoForBoilerplateRepositoryBase<TEntity> : DemoForBoilerplateRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected DemoForBoilerplateRepositoryBase(IDbContextProvider<DemoForBoilerplateDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
