using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace vino.EntityFramework.Repositories
{
    public abstract class vinoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<vinoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected vinoRepositoryBase(IDbContextProvider<vinoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class vinoRepositoryBase<TEntity> : vinoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected vinoRepositoryBase(IDbContextProvider<vinoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
