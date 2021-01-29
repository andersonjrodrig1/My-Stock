using Microsoft.Extensions.Logging;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interface;
using SistemaVenda.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Dominio.Servicos
{
    public class CategoriaServico : ICategoriaServico
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        private ILogger _logger;

        public CategoriaServico(ICategoriaRepositorio categoriaRepositorio, ILogger<CategoriaServico> logger)
        {
            _categoriaRepositorio = categoriaRepositorio;
            _logger = logger;
        }

        public IEnumerable<Categoria> GetCategorias()
        {
            try
            {
                _logger.LogInformation("Buscar das categorias na base de dados.");
                
                return _categoriaRepositorio.GetAll();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao buscar categorias. Detalhes: {ex.Message}");
                throw;
            }
        }

        public Categoria SaveCategoria(Categoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}
