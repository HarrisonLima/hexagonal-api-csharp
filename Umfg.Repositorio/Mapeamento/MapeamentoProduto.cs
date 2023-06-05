using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umfg.Dominio.Entidades;

namespace Umfg.Repositorio.Mapeamento
{
    internal sealed class MapeamentoProduto : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("ID");
            builder.Property(x => x.Descricao).HasColumnName("DS_PRODUTO");
            builder.Property(x => x.CodigoBarra).HasColumnName("CD_BARRA");
            builder.Property(x => x.Valor).HasColumnName("VL_PRODUTO");

            builder.Property(x => x.Descricao).IsRequired();
            builder.Property(x => x.CodigoBarra).IsRequired();
            builder.Property(x => x.Valor).IsRequired();
        }
    }
}
