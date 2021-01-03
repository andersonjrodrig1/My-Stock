using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Models
{
    public class ClienteViewModel
    {
        public int Codigo { get; set; }
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF_CNPJ é obrigatório.")]
        public string CPF_CNPJ { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Celular é obrigatório.")]
        public string Celular { get; set; }
    }
}
