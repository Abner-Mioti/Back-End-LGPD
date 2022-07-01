using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_Repository_Infra.Repositories.Interface.Generico
{
    public interface IRepositoryLGPD<TEntity> where TEntity : class
    {
        Task<TEntity> ObterPorId(int id);
        Task<int> Adicionar(TEntity entidade);
        Task<int> AdicionarTodos(IEnumerable<TEntity> entidade);
        Task<int> Remover(TEntity entidade);
        Task<int> RemoverTodos(IEnumerable<TEntity> entidades);
        Task<int> Atualizar(TEntity entidade);
        Task<IEnumerable<TEntity>> GetAll();
        Task<int> AtualizarTodos(IEnumerable<TEntity> entidades);

    }
}
