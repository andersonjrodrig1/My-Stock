using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Repositorio.Configuracao
{
    public class ProdutoConfiguracao : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("PRODUTO");

            builder.HasKey(p => p.Codigo);
            builder.Property(p => p.Codigo).HasColumnName("CODIGO").IsRequired();
            builder.Property(p => p.Descricao).HasColumnName("DESCRICAO").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Quantidade).HasColumnName("QUANTIDADE").IsRequired();
            builder.Property(p => p.Valor).HasColumnName("VALOR").HasColumnType("decimal(9,2)").IsRequired();
            builder.Property(p => p.CodigoCategoria).HasColumnName("CODIGO_CATEGORIA").IsRequired();

            builder.HasOne(p => p.Categoria).WithMany().HasForeignKey(p => p.CodigoCategoria).HasConstraintName("FK_PRODUTO_CATEGORIA_CODIGO_CATEGORIA").OnDelete(DeleteBehavior.Restrict);
        }
    }
}
