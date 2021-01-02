using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Repositorio.Configuracao
{
    public class CategoriaConfiguracao : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("CATEGORIA");

            builder.HasKey(c => c.Codigo);
            builder.Property(c => c.Codigo).HasColumnName("CODIGO").UseSqlServerIdentityColumn().IsRequired();
            builder.Property(c => c.Descricao).HasColumnName("DESCRICAO").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
        }
    }
}
