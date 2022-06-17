using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGPD.MDE.Mappings;
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

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }
        #region DbSets

        public DbSet<Usuario> Usuario { get; set; }

        #endregion

    }
}
