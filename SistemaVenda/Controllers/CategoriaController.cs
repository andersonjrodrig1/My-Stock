using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Interface;
using SistemaVenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaServicoApp _categoriaServicoApp;

        public CategoriaController(ICategoriaServicoApp categoriaServicoApp)
        {
            _categoriaServicoApp = categoriaServicoApp;
        }

        public IActionResult Index()
        {
            return View(_categoriaServicoApp.GetCategorias());
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
