
using LGPD_MDE.Entities.Generated;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LGPD.MDE.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder) 
        {
            builder.ToTable("USUARIO");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
            .HasColumnType("VARCHAR")
            .HasColumnName("NAME").HasMaxLength(150);

            builder.Property(x => x.Email)
            .HasColumnType("VARCHAR")
            .HasColumnName("EMAIL").HasMaxLength(100);

            builder.Property(x => x.Function)
            .HasColumnType("VARCHAR")
            .HasColumnName("FUNCTION").HasMaxLength(100);

            builder.Property(x => x.Mobile)
            .HasColumnType("VARCHAR")
            .HasColumnName("MOBILE").HasMaxLength(100);

            builder.Property(x => x.User)
           .HasColumnType("VARCHAR")
           .HasColumnName("USER").HasMaxLength(100);

            builder.Property(x => x.Password)
           .HasColumnType("VARCHAR")
           .HasColumnName("PASSWORD").HasMaxLength(60);

            builder.Property(x => x.IsActive)
           .HasColumnType("BIT")
           .HasColumnName("IS_ACTIVE");

        }    
    }
}
