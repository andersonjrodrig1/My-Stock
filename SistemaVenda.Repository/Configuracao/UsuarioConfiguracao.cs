using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Repositorio.Configuracao
{
    public class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO");

            builder.HasKey(u => u.Codigo);
            builder.Property(u => u.Codigo).HasColumnName("CODIGO").UseSqlServerIdentityColumn().IsRequired();
            builder.Property(u => u.Nome).HasColumnName("NOME").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(u => u.Email).HasColumnName("EMAIL").HasColumnType("VARCHAR(50)").HasMaxLength(50).IsRequired();
            builder.Property(u => u.Senha).HasColumnName("SENHA").HasColumnType("VARCHAR(100)").HasMaxLength(20).IsRequired();
        }
    }
}
