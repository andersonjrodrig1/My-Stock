using Microsoft.Extensions.Logging;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interface;
using SistemaVenda.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<Categoria>> GetCategorias()
        {
            try
            {
                _logger.LogInformation("Buscar das categorias na base de dados.");

                return await _categoriaRepositorio.GetAll();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao buscar categorias. Detalhes: {ex.Message}");
                throw;
            }
        }

        public async Task SaveCategoria(Categoria categoria)
        {
            try
            {
                _logger.LogInformation("Salvando nova categoria.");

                await _categoriaRepositorio.Add(categoria);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao salvar categoria. Detalhes: {ex.Message}");
                throw;
            }
        }
    }
}
