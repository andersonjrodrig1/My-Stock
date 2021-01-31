using SistemaVenda.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVenda.Dominio.Interface
{
    public interface IUsuarioServico
    {
        Usuario GetUsuarioAutenticacao(string email, string senha);
    }
}
