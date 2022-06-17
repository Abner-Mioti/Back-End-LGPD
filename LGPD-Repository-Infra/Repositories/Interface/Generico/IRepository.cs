using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_Repository_Infra.Repositories.Interface.Generico
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        Task<TEntity> ObterPorIdAsync(int id);
        Task AdicionarAsync(TEntity entidade);
        Task AdicionarTodosAsync(IEnumerable<TEntity> entidade);
        Task RemoverAsync(int id);
        void AtualizarAsync(TEntity entidade);
        Task<IEnumerable<TEntity>> ObterTodosAsync();
        void AtualizarTodosAsync(IEnumerable<TEntity> entidades);
        Task<int> SalvarAsync(IEnumerable<TEntity> entidades);

    }
}
