using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Entidades
{
    public class Venda
    {
        public int Codigo { get; set; }
        public DateTime Data { get; set; }
        public int CodigoCliente { get; set; } 
        public decimal Total { get; set; }
    }
}
