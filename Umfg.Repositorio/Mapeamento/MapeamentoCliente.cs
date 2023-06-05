using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Umfg.Dominio.Entidades;

namespace Umfg.Repositorio.Mapeamento
{
    internal sealed class MapeamentoCliente : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Documento).HasColumnName("NR_DOCUMENTO");
            builder.Property(x => x.Nome).HasColumnName("NM_CLIENTE");
            builder.Property(x => x.Endereco).HasColumnName("DS_ENDERECO");
            builder.Property(x => x.Celular).HasColumnName("NR_CELULAR");
            builder.Property(x => x.Email).HasColumnName("DS_EMAIL");
            builder.Property(x => x.Observacao).HasColumnName("DS_OBSERVACAO");

            builder.Property(x => x.Documento).IsRequired();
            builder.Property(x => x.Nome).IsRequired();
            builder.Property(x => x.Endereco).IsRequired();
            builder.Property(x => x.Celular).IsRequired();
            builder.Property(x => x.Email).IsRequired();
        }
    }

}

