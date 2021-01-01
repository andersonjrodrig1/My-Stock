using Microsoft.EntityFrameworkCore;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Repositorio.Configuracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaProdutos> VendaProdutos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VendaProdutosConfiguracao());

            base.OnModelCreating(modelBuilder);
        }
    }
}
