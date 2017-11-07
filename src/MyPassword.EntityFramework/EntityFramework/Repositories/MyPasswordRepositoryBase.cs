using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MyPassword.EntityFramework.Repositories
{
    public abstract class MyPasswordRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MyPasswordDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MyPasswordRepositoryBase(IDbContextProvider<MyPasswordDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MyPasswordRepositoryBase<TEntity> : MyPasswordRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MyPasswordRepositoryBase(IDbContextProvider<MyPasswordDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
