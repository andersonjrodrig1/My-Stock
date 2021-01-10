using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Repositorio.Configuracao
{
    public class VendaConfiguracao : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("VENDA");

            builder.HasKey(v => v.Codigo);
            builder.Property(v => v.Codigo).HasColumnName("CODIGO").UseSqlServerIdentityColumn().IsRequired();
            builder.Property(v => v.Data).HasColumnName("DATA").HasColumnType("datetime").IsRequired();
            builder.Property(v => v.CodigoCliente).HasColumnName("CODIGO_CLIENTE").IsRequired();
            builder.Property(v => v.Total).HasColumnName("TOTAL").HasColumnType("decimal(9,2)").IsRequired();

            builder.HasOne(v => v.Cliente).WithMany(v => v.Vendas).HasForeignKey(v => v.CodigoCliente).HasConstraintName("FK_VENDA_CLIENTE_CODIGO_CLIENTE").OnDelete(DeleteBehavior.Restrict);
        }
    }
}
