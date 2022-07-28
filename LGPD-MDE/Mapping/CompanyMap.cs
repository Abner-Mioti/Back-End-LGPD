using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LGPD_MDE.Mapping
{
    public class CompanyMap : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("COMPANY");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.QuestionId)
           .HasColumnType("INT")
           .HasColumnName("QUESTION_ID").IsRequired(true);

            builder.Property(x => x.FieldId)
           .HasColumnType("INT")
           .HasColumnName("FIELD_ID").IsRequired(true);

            builder.Property(x => x.CompanyCategoryId)
           .HasColumnType("INT")
           .HasColumnName("COMPANY_CATEGORY_ID").IsRequired(true);

            builder.Property(x => x.ReportPeriodId)
           .HasColumnType("INT")
           .HasColumnName("REPORT_PERIOD_ID").IsRequired(true);

            builder.Property(x => x.WorkshopId)
           .HasColumnType("INT")
           .HasColumnName("WORKSHOP_ID").IsRequired(true);

            builder.Property(x => x.StepId)
           .HasColumnType("INT")
           .HasColumnName("STEP_ID").IsRequired(true);

            builder.Property(x => x.CNPJ)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("CNPJ");

            builder.Property(x => x.Name)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("NAME");

            builder.Property(x => x.Email)
            .HasColumnType("VARCHAR(100)")
            .HasColumnName("EMAIL");

            builder.Property(x => x.Mobile)
           .HasColumnType("VARCHAR(100)")
           .HasColumnName("MOBILE");

            builder.Property(x => x.Site)
           .HasColumnType("VARCHAR(100)")
           .HasColumnName("SITE");

            builder.Property(x => x.Progress)
           .HasColumnType("FLOAT")
           .HasColumnName("PROGRESS");

            builder.Property(x => x.ProgrectionStatus)
           .HasColumnType("BIT")
           .HasColumnName("PROGRECTION_STATUS");

            builder.Property(x => x.ProgrectionStartDate)
           .HasColumnType("DATE")
           .HasColumnName("PROGRECTION_START_DATE");

            builder.Property(x => x.Maturity)
           .HasColumnType("FLOAT")
           .HasColumnName("MATURITY");

            builder.Property(x => x.RegistrationDate)
            .HasColumnType("DATE")
            .HasColumnName("REGISTRATION_DATE");

            builder.Property(x => x.MaturityDate)
            .HasColumnType("DATE")
            .HasColumnName("MATURITY_DATE");

        }

    }
}
