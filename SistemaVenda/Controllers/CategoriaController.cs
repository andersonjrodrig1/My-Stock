using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Servico.Interface;
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

        [Route("Categoria/Cadastro/{id?}")]
        public async Task<IActionResult> Cadastro(int? id)
        {
            var model = new CategoriaViewModel();

            if (id.HasValue)
            {
                model = await _categoriaServicoApp.GetCategoria(id.Value);
            }

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
