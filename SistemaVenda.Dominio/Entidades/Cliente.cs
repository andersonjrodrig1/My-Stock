using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Entidades
{
    public class Cliente
    {
        public int? Codigo { get; set; }
        public string Nome { get; set; }
        public string CPF_CNPJ { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
    }
}
