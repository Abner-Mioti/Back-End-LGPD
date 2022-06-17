using LGPD_MDE.Entities;
using LGPD_MDE.Entities.Generated;
using LGPD_Repository_Infra.Repositories.Interface.Generico;


namespace LGPD_Repository.Repositories.Generico
{
    public class RepositoryEntity<TEntity> : Repository<TEntity>, IRepositoryEntity<TEntity> where TEntity : Entity
    {
        public RepositoryEntity(LgpdDbContext context) : base(context)
        {

        }

    }
}
