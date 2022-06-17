using LGPD_MDE.Entities;
using LGPD_Repository_Infra.Repositories.Interface.Generico;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_Repository.Repositories.Generico
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly LgpdDbContext Db;

        protected readonly DbSet<TEntity> DbSet;

        public Repository(LgpdDbContext dbContext)
        {
            Db = dbContext;
            DbSet = Db.Set<TEntity>();
        }

        public async Task AdicionarAsync(TEntity entidade)
        {
            var _newEntity = await DbSet.AddAsync(entidade);
        }

        public async Task AdicionarTodosAsync(IEnumerable<TEntity> entidade)
        {
            await DbSet.AddRangeAsync(entidade.ToArray());
        }

        public void AtualizarAsync(TEntity entidade)
        {
            DbSet.Attach(entidade);
            Db.Entry(entidade).State = EntityState.Modified;
        }

        public void AtualizarTodosAsync(IEnumerable<TEntity> entidades)
        {
            DbSet.AttachRange(entidades);
            Db.Entry(entidades).State = EntityState.Modified;
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task<TEntity> ObterPorIdAsync(int id)
        {
            var _entity = await DbSet.FindAsync(id);
            return _entity;
        }

        public async Task<IEnumerable<TEntity>> ObterTodosAsync()
        {
            var _entity = await DbSet.ToListAsync();
            return _entity;
        }

        public async Task RemoverAsync(int id)
        {
            var _entity = await DbSet.FindAsync(id);
            DbSet.Remove(_entity);
        }

        public async Task<int> SalvarAsync(IEnumerable<TEntity> entidades)
        {
            return await Db.SaveChangesAsync();
        }
    }
}
