using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Controllers
{
    public class CategoriaController : Controller
    {
        public IActionResult Index()
        {
            //mock para renderização
            var list = new List<Categoria>() 
            { 
                new Categoria { Codigo = 1, Descricao = "Livros" },
                new Categoria { Codigo = 2, Descricao = "Bebidas" },
                new Categoria { Codigo = 3, Descricao = "Computadores" }
            };


            return View(list);
        }

        public IActionResult Cadastro()
        {
            //mock para renderização
            CategoriaViewModel model = new CategoriaViewModel();
            model.Codigo = 1;
            model.Descricao = "Livros";

            return View(model);
        }
    }
}
