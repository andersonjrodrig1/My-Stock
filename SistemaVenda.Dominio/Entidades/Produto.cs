using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Entidades
{
    public class Produto
    {
        public int? Codigo { get; set; }
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public decimal Valor { get; set; }

        #region Categoria
        public int CodigoCategoria { get; set; }
        public Categoria Categoria { get; set; }
        #endregion
    }
}
