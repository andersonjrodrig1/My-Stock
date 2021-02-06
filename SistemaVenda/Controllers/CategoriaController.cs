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

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var models = await _categoriaServicoApp.GetCategorias();

            return View(models);
        }

        public IActionResult Cadastro()
        {
            var model = new CategoriaViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Gravar(CategoriaViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _categoriaServicoApp.SaveCategoria(model);

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
