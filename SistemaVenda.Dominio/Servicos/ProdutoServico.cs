using Microsoft.Extensions.Logging;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interface;
using SistemaVenda.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Servicos
{
    public class ProdutoServico : IProdutoService
    {
        private IProdutoRepositorio _produtoRepositorio;
        private ILogger _logger;

        public ProdutoServico(IProdutoRepositorio produtoRepositorio, ILogger<ProdutoServico> logger)
        {
            _produtoRepositorio = produtoRepositorio;
            _logger = logger;
        }
        public async Task<IEnumerable<Produto>> GetProdutos()
        {
            try
            {
                _logger.LogInformation("Busca dos produtos cadastrados");

                return await _produtoRepositorio.GetAll();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao buscar produtos. Detalhes: {ex.Message}");
                throw;
            }
        }

        public void Dispose()
        {
            _produtoRepositorio = null;
            _logger = null;
        }
    }
}
