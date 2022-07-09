namespace LGPD_Repository_Infra.Repositories.Interface.Generico
{
    public interface IRepositoryLGPD<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(int id);
        Task<int> Add(TEntity entidade);
        Task<int> AddAll(IEnumerable<TEntity> entidade);
        Task<int> Remove(TEntity entidade);
        Task<int> RemoveAll(IEnumerable<TEntity> entidades);
        Task<int> Update(TEntity entidade);
        Task<IEnumerable<TEntity>> GetAll();
        Task<int> UpdateAll(IEnumerable<TEntity> entidades);

    }
}
