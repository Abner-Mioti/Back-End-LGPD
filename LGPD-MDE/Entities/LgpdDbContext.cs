using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;

namespace LGPD_MDE.Entities
{
    public partial class LgpdDbContext : DbContext
    {
        #region Base
        public LgpdDbContext(DbContextOptions<LgpdDbContext> options) : base(options)
        {
        }

        public void AddEntity(object entity)
        {
            base.Add(entity);
        }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        #region DbSets

        public DbSet<Usuario> Usuario { get; set; }

        #endregion

    }
}
