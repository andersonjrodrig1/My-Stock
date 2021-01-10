using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Controllers
{
    public class VendaController : Controller
    {
        public IActionResult Index()
        {
            var vendas = new List<Venda>();

            return View(vendas);
        }

        public IActionResult Cadastro()
        {
            var vendaViewModel = new VendaViewModel();

            return View(vendaViewModel);
        }
    }
}
