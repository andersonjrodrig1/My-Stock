using AutoMapper;
using SistemaVenda.Dominio.Interface;
using SistemaVenda.Models;
using SistemaVenda.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Servico
{
    public class ProdutoServicoApp : IProdutoServicoApp
    {
        private readonly IProdutoService _produtoService;

        public ProdutoServicoApp(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        public async Task<IEnumerable<ProdutoViewModel>> GetProdutos()
        {
            var lista = new List<ProdutoViewModel>();
            ProdutoViewModel viewModel = null;

            var produtos = await _produtoService.GetProdutos();

            if (produtos != null && produtos.Any())
            {
                var configuracao = new MapperConfiguration(conf => conf.CreateMap<SistemaVenda.Dominio.Entidades.Produto, ProdutoViewModel>());
                var mapeamento = configuracao.CreateMapper();

                produtos.AsParallel().ForAll(produto =>
                {
                    viewModel = new ProdutoViewModel();
                    viewModel = mapeamento.Map<ProdutoViewModel>(produto);

                    lista.Add(viewModel);
                });
            }

            return lista;
        }

        public void Dispose()
        {
        }
    }
}
