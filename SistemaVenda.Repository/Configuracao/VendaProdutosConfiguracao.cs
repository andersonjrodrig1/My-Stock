using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Repositorio.Configuracao
{
    public class VendaProdutosConfiguracao : IEntityTypeConfiguration<VendaProdutos>
    {
        public void Configure(EntityTypeBuilder<VendaProdutos> builder)
        {
            builder.ToTable("VENDA_PRODUTOS");

            builder.HasKey(v => new { v.CodigoProduto, v.CodigoVenda });
            builder.Property(v => v.CodigoProduto).HasColumnName("CODIGO_PRODUTO").IsRequired();
            builder.Property(v => v.CodigoVenda).HasColumnName("CODIGO_VENDA").IsRequired();
            builder.Property(v => v.Quantidade).HasColumnName("QUANTIDADE").IsRequired();
            builder.Property(v => v.ValorUnitario).HasColumnName("VALOR_UNITARIO").HasColumnType("decimal(9,2)").IsRequired();
            builder.Property(v => v.ValorTotal).HasColumnName("VALOR_TOTAL").HasColumnType("decimal(9,2)").IsRequired();

            builder.HasOne(v => v.Venda).WithMany().HasForeignKey(v => v.CodigoVenda).HasConstraintName("FK_VENDA_PRODUTO_VENDA_CODIGO_VENDA").OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(v => v.Produto).WithMany().HasForeignKey(v => v.CodigoProduto).HasConstraintName("FK_VENDA_PRODUTO_PRODUTO_CODIGO_PRODUTO").OnDelete(DeleteBehavior.Restrict);
        }
    }
}
