using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD_MDE.Mapping
{
    public class EnterpriseMap : IEntityTypeConfiguration<Enterprise>
    {
        public void Configure(EntityTypeBuilder<Enterprise> builder)
        {
            builder.ToTable("ENTERPRISE");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.QuestionId)
           .HasColumnType("INTEGER")
           .HasColumnName("QUESTION_ID").IsRequired(true);

            builder.Property(x => x.FieldId)
           .HasColumnType("INTEGER")
           .HasColumnName("FIELD_ID").IsRequired(true);

            builder.Property(x => x.EnterpriseCategoryId)
           .HasColumnType("INTEGER")
           .HasColumnName("ENTERPRISE_CATEGORY_ID").IsRequired(true);

            builder.Property(x => x.ReportPeriodId)
           .HasColumnType("INTEGER")
           .HasColumnName("REPORT_PERIOD_ID").IsRequired(true);

            builder.Property(x => x.CNPJ)
            .HasColumnType("VARCHAR")
            .HasColumnName("CNPJ").HasMaxLength(30);

            builder.Property(x => x.Name)
            .HasColumnType("VARCHAR")
            .HasColumnName("NAME").HasMaxLength(50);

            builder.Property(x => x.Email)
            .HasColumnType("VARCHAR")
            .HasColumnName("EMAIL").HasMaxLength(50);

            builder.Property(x => x.Mobile)
           .HasColumnType("VARCHAR")
           .HasColumnName("MOBILE").HasMaxLength(50);

            builder.Property(x => x.Site)
           .HasColumnType("VARCHAR")
           .HasColumnName("SITE").HasMaxLength(50);

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

            builder.HasOne(y => y.Question)
           .WithMany()
           .HasForeignKey(t => t.QuestionId);

            builder.HasOne(y => y.Field)
           .WithMany()
           .HasForeignKey(t => t.FieldId);

            builder.HasOne(y => y.EnterpriseCategory)
           .WithMany()
           .HasForeignKey(t => t.EnterpriseCategoryId);

            builder.HasOne(y => y.ReportPeriod)
           .WithMany()
           .HasForeignKey(t => t.ReportPeriodId);
        }

    }
}
