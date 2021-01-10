using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Models
{
    public class VendaViewModel
    {
        public int Codigo { get; set; }
        public DateTime? Data { get; set; }
        public int CodigoCliente { get; set; }
        public IEnumerable<SelectListItem> Clientes { get; set; }
        public IEnumerable<SelectListItem> Produtos { get; set; }
        public string JsonProdutos { get; set; }
        public decimal Total { get; set; }
    }
}
