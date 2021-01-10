using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Entidades
{
    public class Venda : ClasseBase
    {
        public DateTime Data { get; set; }

        #region Cliente
        public int CodigoCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
        #endregion

        public decimal Total { get; set; }
    }
}
