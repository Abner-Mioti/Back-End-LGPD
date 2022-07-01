using LGPD_MDE.Entities;
using LGPD_Repository_Infra.Repositories.Interface.Generico;

namespace LGPD_Repository.Repositories.Generico
{
    public class RepositoryLGPD<TEntity> : IRepositoryLGPD<TEntity> where TEntity : class
    {
        protected readonly LgpdDbContext _ctx;

        /// <summary>
        /// Utilizado somente para Injeção de Dependência.
        /// </summary>
        /// <param name="ctx">Contexto de conexão do banco gerenciado somente pela Injeção de Dependência.</param>
        public RepositoryLGPD(LgpdDbContext ctx)
        {
            _ctx = ctx;
        }


        #region Metodos genericos para PortalDb

        /// <summary>
        /// Adiciona a entidade.
        /// </summary>
        /// <param name="entidade">Entidade relacionada a tabela.</param>
        /// <returns>Numero de linhas afetadas</returns>
        public Task<int> Adicionar(TEntity entidade)
        {
            _ctx.Set<TEntity>().Add(entidade);
            return _ctx.SaveChangesAsync();
        }

        /// <summary>
        /// Adiciona todas as entidades no banco.
        /// </summary>
        /// <param name="entidades">Lista de entidades a serem adicionadas</param>
        /// <returns>Número de entidades adicionadas no banco.</returns>
        public Task<int> AdicionarTodos(IEnumerable<TEntity> entidades)
        {
            _ctx.Set<TEntity>().AddRange(entidades);
            return _ctx.SaveChangesAsync();
        }

        /// <summary>
        /// Obtem entidade pelo Id Chave primária da tabela.
        /// </summary>
        /// <param name="id">Chave primária ID.</param>
        /// <returns>Entidade correspondente.</returns>
        public Task<TEntity> ObterPorId(int id)
        {
            return Task.Run(() => _ctx.Set<TEntity>().Find(id));
        }


        /// <summary>
        /// Atualiza entidade no banco.
        /// </summary>
        /// <param name="entidade">Entidade a ser atualizada, necessário ter o ID primário preenchido.</param>
        /// <returns>Número de linhas afetadas no banco.</returns>
        public Task<int> Atualizar(TEntity entidade)
        {
            _ctx.Set<TEntity>().Update(entidade);
            return _ctx.SaveChangesAsync();
        }

        /// <summary>
        /// Atualiza lista de entidades no banco.
        /// </summary>
        /// <param name="entidades">Lista de Entidade a serem atualizadas, necessário ter ID primário preenchido.</param>
        /// <returns>Número de linhas afetadas no banco.</returns>
        public Task<int> AtualizarTodos(IEnumerable<TEntity> entidades)
        {
            _ctx.Set<TEntity>().UpdateRange(entidades);
            return _ctx.SaveChangesAsync();
        }

        /// <summary>
        /// Remove entidade no banco.
        /// </summary>
        /// <param name="entidade">Entidade a ser removida do banco, necessário ter o ID primário preenchido.</param>
        /// <returns>Número de linhas afetadas no banco.</returns>
        public Task<int> Remover(TEntity entidade)
        {
            _ctx.Set<TEntity>().Remove(entidade);
            return _ctx.SaveChangesAsync();
        }

        /// <summary>
        /// Obtem todas as entidades do banco, ATENÇÃO: não utilize esse método para tabelas de regras de negócio, somente para tabelas de domínio.
        /// </summary>
        /// <returns>Todas as entidades da tabela do banco.</returns>
        public Task<IEnumerable<TEntity>> GetAll()
        {
            return Task.Run(() => _ctx.Set<TEntity>().AsEnumerable());
        }

        /// <summary>
        /// Remove todas as entidades da lista do banco de dados.
        /// </summary>
        /// <param name="entidades">Todas as entidades a serem deletadas, necessário ter o ID primário preenchido.</param>
        /// <returns>Número de linhas afetadas</returns>
        public Task<int> RemoverTodos(IEnumerable<TEntity> entidades)
        {
            _ctx.Set<TEntity>().RemoveRange(entidades);
            return _ctx.SaveChangesAsync();
        }
        #endregion

    }
}
