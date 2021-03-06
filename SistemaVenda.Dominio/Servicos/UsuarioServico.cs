﻿using SistemaVenda.Dominio.Repositorio;
using System;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Helpers;
using Microsoft.Extensions.Logging;
using SistemaVenda.Dominio.Interface;
using System.Threading.Tasks;

namespace SistemaVenda.Dominio.Servicos
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private ILogger _logger;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio, ILogger<UsuarioServico> logger)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _logger = logger;
        }

        public async Task<Usuario> GetUsuarioAutenticacao(string email, string senha)
        {
            try
            {
                _logger.LogInformation("Validando senha informada pelo usuário.");

                var senhaMD5hash = Criptografia.GetStringMD5Hash(senha);

                _logger.LogInformation($"Busca do usuário com email: {email} para autenticação.");

                return await _usuarioRepositorio.GetUsuarioAutentication(email, senhaMD5hash);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Erro ao autenticar usuário. Detalhes: {ex.Message}");
                throw;
            }
        }
    }
}
