
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

            builder.Property(x => x.Nome)
            .HasColumnName("NOME");

            builder.Property(x => x.Email)
            .HasColumnName("EMAIL");

            builder.Property(x => x.DataNascimento)
            .HasColumnName("DATA_NASCIMENTO");

            builder.Property(x => x.Telefone)
            .HasColumnName("TELEFONE");

            builder.Property(x => x.Descricao)
            .HasColumnName("DESCRICAO");

        }    
    }
}
