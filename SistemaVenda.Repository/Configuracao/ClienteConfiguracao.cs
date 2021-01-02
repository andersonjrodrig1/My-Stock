using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Repositorio.Configuracao
{
    public class ClienteConfiguracao : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("CLIENTE");

            builder.HasKey(c => c.Codigo);
            builder.Property(c => c.Codigo).HasColumnName("CODIGO").UseSqlServerIdentityColumn().IsRequired();
            builder.Property(c => c.Nome).HasColumnName("NOME").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(c => c.CPF_CNPJ).HasColumnName("CPF_CNPJ").HasColumnType("VARCHAR(15)").HasMaxLength(15).IsRequired();
            builder.Property(c => c.Email).HasColumnName("EMAIL").HasColumnType("VARCHAR(30)").HasMaxLength(30).IsRequired();
            builder.Property(c => c.Celular).HasColumnName("CELULAR").HasColumnType("VARCHAR(15)").HasMaxLength(15).IsRequired();
        }
    }
}
