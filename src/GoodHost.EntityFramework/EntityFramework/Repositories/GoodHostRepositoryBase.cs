using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace GoodHost.EntityFramework.Repositories
{
    public abstract class GoodHostRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<GoodHostDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected GoodHostRepositoryBase(IDbContextProvider<GoodHostDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class GoodHostRepositoryBase<TEntity> : GoodHostRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected GoodHostRepositoryBase(IDbContextProvider<GoodHostDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
