using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Entidades
{
    public class Produto : ClasseBase
    {
        public string Descricao { get; set; }
        public double Quantidade { get; set; }
        public decimal Valor { get; set; }

        #region Categoria
        public int CodigoCategoria { get; set; }
        public virtual Categoria Categoria { get; set; }
        #endregion
    }
}
