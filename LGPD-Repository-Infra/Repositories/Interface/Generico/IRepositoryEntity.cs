namespace LGPD_Repository_Infra.Repositories.Interface.Generico
{
    public interface IRepositoryEntity<TEntity> : IRepository<TEntity> where TEntity : class
    {
    }
}
