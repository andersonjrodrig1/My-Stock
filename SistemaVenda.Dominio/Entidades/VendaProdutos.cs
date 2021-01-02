using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Entidades
{
    public class VendaProdutos
    {
        #region Venda
        public int CodigoVenda { get; set; }
        public virtual Venda Venda { get; set; }
        #endregion

        #region Produto
        public int CodigoProduto { get; set; }
        public virtual Produto Produto { get; set; }
        #endregion

        public double Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
