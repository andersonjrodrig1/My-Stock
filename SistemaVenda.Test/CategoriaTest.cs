using AutoFixture;
using Microsoft.Extensions.Logging;
using Moq;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interface;
using SistemaVenda.Dominio.Repositorio;
using SistemaVenda.Dominio.Servicos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SistemaVenda.Test
{
    [Collection("Categoria")]
    public class CategoriaTest
    {
        private Mock<ICategoriaRepositorio> _categoriaRepositorio;
        private ICategoriaServico _categoriaServico;
        private ILogger<CategoriaServico> _loggerCategoria;
        private IList<Categoria> _categorias;
        private Categoria _categoria;
        private Fixture _fixture;

        public CategoriaTest()
        {
            _loggerCategoria = new LoggerFactory().CreateLogger<CategoriaServico>();
            _categoriaRepositorio = new Mock<ICategoriaRepositorio>();
            _categoriaServico = new CategoriaServico(_categoriaRepositorio.Object, _loggerCategoria);
            _fixture = new Fixture();
        }

        [Fact]
        public async Task GetCategoriasTest()
        {
            _categorias = new List<Categoria>()
            {
                { new Fixture().Create<Categoria>() },
                { new Fixture().Create<Categoria>() },
                { new Fixture().Create<Categoria>() },
                { new Fixture().Create<Categoria>() }
            };

            var categoriaRepositorioMock = _categoriaRepositorio.Setup(c => c.GetAll()).ReturnsAsync(() => _categorias);
            var categoriaResult = await _categoriaServico.GetCategorias();

            Assert.True(categoriaResult.Any());
        }

        [Fact]
        public async Task GetCategoriaTest()
        {
            _categoria = _fixture.Create<Categoria>();

            var categoriaRepositorioMock = _categoriaRepositorio.Setup(c => c.Get(It.IsAny<int>())).ReturnsAsync((int codigo) => _categoria);
            var categoriaResult = await _categoriaServico.GetCategoria(_categoria.Codigo);

            Assert.Equal(categoriaResult.Codigo, _categoria.Codigo);
            Assert.Equal(categoriaResult.Descricao, _categoria.Descricao);
        }

        [Fact]
        public async Task SalvarCategoriaTest()
        {
            _categoria = _fixture.Create<Categoria>();

            var categoriaRepositorioMock = _categoriaRepositorio.Setup(c => c.Add(It.IsAny<Categoria>())).ReturnsAsync(() => _categoria);
            await _categoriaServico.SaveCategoria(_categoria);

            Assert.True(true);
        }

        [Fact]
        public async Task EditarCategoriaTest()
        {
            _categoria = _fixture.Create<Categoria>();

            var categoriaRepositorioMock2 = _categoriaRepositorio.Setup(c => c.Update(It.IsAny<Categoria>())).ReturnsAsync(() => _categoria);
            await _categoriaServico.EditarCategoria(_categoria);

            Assert.True(true);
        }
    }
}
