using SistemaVenda.Dominio.Interface;
using SistemaVenda.Interface;
using SistemaVenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using System.Threading.Tasks;

namespace SistemaVenda.Servico
{
    public class CategoriaServicoApp : ICategoriaServicoApp
    {
        private readonly ICategoriaServico _categoriaServico;

        public CategoriaServicoApp(ICategoriaServico categoriaServico)
        {
            _categoriaServico = categoriaServico;
        }

        public async Task<IEnumerable<CategoriaViewModel>> GetCategorias()
        {
            var lista = new List<CategoriaViewModel>();
            CategoriaViewModel viewModel = null;

            var categorias = await _categoriaServico.GetCategorias();

            if (categorias != null && categorias.Any())
            {
                var configuracao = new MapperConfiguration(conf => conf.CreateMap<SistemaVenda.Dominio.Entidades.Categoria, CategoriaViewModel>());
                var mapeamento = configuracao.CreateMapper();

                categorias.AsParallel().ForAll(categoria =>
                {
                    viewModel = new CategoriaViewModel();
                    viewModel = mapeamento.Map<CategoriaViewModel>(categoria);

                    lista.Add(viewModel);
                });
            }

            return lista;
        }

        public async Task SaveCategoria(CategoriaViewModel viewModel)
        {
            var configuracao = new MapperConfiguration(conf => conf.CreateMap<CategoriaViewModel, SistemaVenda.Dominio.Entidades.Categoria>());
            var mapeamento = configuracao.CreateMapper();
            var categoria = mapeamento.Map<SistemaVenda.Dominio.Entidades.Categoria>(viewModel);

            await _categoriaServico.SaveCategoria(categoria);
        }
    }
}
