using LGPD.MDE.Mappings;
using LGPD_MDE.Entities.Generated;
using LGPD_MDE.Mapping;
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
            modelBuilder.ApplyConfiguration(new WorkshopMap());
            modelBuilder.ApplyConfiguration(new RiskMap());
            modelBuilder.ApplyConfiguration(new AreaMap());
            modelBuilder.ApplyConfiguration(new QuestionMap());
            modelBuilder.ApplyConfiguration(new QuestionCategoryMap());
            modelBuilder.ApplyConfiguration(new ImpactMap());
            modelBuilder.ApplyConfiguration(new ProbabilityMap());
            modelBuilder.ApplyConfiguration(new CompanyMap());
            modelBuilder.ApplyConfiguration(new FieldMap());
            modelBuilder.ApplyConfiguration(new CompanyCategoryMap());
            modelBuilder.ApplyConfiguration(new ReportPeriodMap());
            modelBuilder.ApplyConfiguration(new ExceptionsMap());
            modelBuilder.ApplyConfiguration(new ObservationMap());
            modelBuilder.ApplyConfiguration(new StepMap());


            base.OnModelCreating(modelBuilder);
        }
        #region DbSets

        public DbSet<User> Usuario { get; set; }
        public DbSet<Risk> Risk { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<Workshop> Workshop { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionCategory> QuestionCategory { get; set; }
        public DbSet<Impact> Impact { get; set; }
        public DbSet<Probability> Probability { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Field> Field { get; set; }
        public DbSet<CompanyCategory> CompanyCategory { get; set; }
        public DbSet<ReportPeriod> ReportPeriod { get; set; }
        public DbSet<Observation> Observation { get; set; }
        public DbSet<Exceptions> Exceptions { get; set; }
        public DbSet<Step> Step { get; set; }

        #endregion

    }
}
