using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            var list = new List<Produto>()
            {
                new Produto() { Codigo = 1, Descricao = "Gol G6 1.6 v8", Quantidade = 8, Valor = 48000.00m, CodigoCategoria = 1, Categoria = new Categoria() { Codigo = 1, Descricao = "Automóveis" } },
                new Produto() { Codigo = 2, Descricao = "Fox 1.6 v8", Quantidade = 10, Valor = 58000.00m, CodigoCategoria = 1, Categoria = new Categoria() { Codigo = 1, Descricao = "Automóveis" } }
            };

            return View(list);
        }

        public IActionResult Cadastro()
        {
            var model = new ProdutoViewModel()
            {
                Codigo = 1,
                Descricao = "Gol G6 1.6 v8",
                Quantidade = 8,
                Valor = 48000.00m,
                CodigoCategoria = 1,
                Categorias = new List<SelectListItem>()
                {
                    new SelectListItem() { Value = "1", Text = "Automóveis" },
                    new SelectListItem() { Value = "2", Text = "Livros" }
                }
            };

            return View(model);
        }
    }
}
