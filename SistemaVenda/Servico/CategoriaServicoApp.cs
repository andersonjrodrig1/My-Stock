using SistemaVenda.Dominio.Interface;
using SistemaVenda.Interface;
using SistemaVenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public IEnumerable<CategoriaViewModel> GetCategorias()
        {
            var lista = new List<CategoriaViewModel>();
            CategoriaViewModel viewModel = null;

            var categorias = _categoriaServico.GetCategorias();

            //fazer mapeamento dos atributos
            foreach (var categoria in categorias)
            {
                viewModel = new CategoriaViewModel();
                viewModel.Codigo = categoria.Codigo;
                viewModel.Descricao = categoria.Descricao;

                lista.Add(viewModel);
            }

            return lista;
        }

        public CategoriaViewModel SaveCategoria(CategoriaViewModel categoria)
        {
            throw new NotImplementedException();
        }
    }
}
