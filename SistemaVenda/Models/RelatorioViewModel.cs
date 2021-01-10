using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Models
{
    public class RelatorioViewModel
    {
        public int CodigoProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Total { get; set; }
    }
}
