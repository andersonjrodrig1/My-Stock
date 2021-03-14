using Moq;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using Xunit;
using AutoFixture;
using System.Threading.Tasks;
using SistemaVenda.Dominio.Servicos;
using SistemaVenda.Dominio.Interface;
using Microsoft.Extensions.Logging;
using FluentAssertions;

namespace SistemaVenda.Test
{
    [Collection("Usuario")]
    public class UsuarioTest
    {
        private Mock<IUsuarioRepositorio> _usuarioRepositorio;
        private IUsuarioServico _usuarioServico;
        private ILogger<UsuarioServico> _logger;
        private Usuario _usuario;
        private Fixture _fixture;

        public UsuarioTest()
        {
            _logger = new LoggerFactory().CreateLogger<UsuarioServico>();
            _usuarioRepositorio = new Mock<IUsuarioRepositorio>();
            _usuarioServico = new UsuarioServico(_usuarioRepositorio.Object, _logger);
            _fixture = new Fixture();
        }

        [Fact]
        public async Task AutenticaUsuarioTest()
        {
            _usuario = _fixture.Create<Usuario>();

            _usuarioRepositorio.Setup(u => u.GetUsuarioAutentication(It.IsAny<string>(), It.IsAny<string>())).ReturnsAsync((string email, string senha) => _usuario);
            var usuarioResult = await _usuarioServico.GetUsuarioAutenticacao(_usuario.Email, _usuario.Senha);

            usuarioResult.Should().BeEquivalentTo(_usuario);
        }
    }
}