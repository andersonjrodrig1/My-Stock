using Microsoft.AspNetCore.Mvc;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            //mock para renderização
            var list = new List<Cliente>()
            {
                new Cliente { Codigo = 1, Nome = "João", CPF_CNPJ = "01234567890", Email = "joao@teste.com", Celular = "34998877665" },
                new Cliente { Codigo = 2, Nome = "Maria", CPF_CNPJ = "12345678900", Email = "maria@teste.com", Celular = "34993377115" },
                new Cliente { Codigo = 3, Nome = "Jose", CPF_CNPJ = "09923456780", Email = "jose@teste.com", Celular = "34998833365" }
            };


            return View(list);
        }

        public IActionResult Cadastro()
        {
            var model = new ClienteViewModel()
            {
                Codigo = 1,
                Nome = "João",
                CPF_CNPJ = "01234567890",
                Email = "joao@teste.com",
                Celular = "34998877665"
            };

            return View(model);
        }
    }
}
