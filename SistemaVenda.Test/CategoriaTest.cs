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
using FluentAssertions;
using Bogus;

namespace SistemaVenda.Test
{
    [Collection("Categoria")]
    public class CategoriaTest
    {
        private readonly Mock<ICategoriaRepositorio> _categoriaRepositorio;
        private readonly ICategoriaServico _categoriaServico;
        private readonly ILogger<CategoriaServico> _loggerCategoria;

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
            var faker = new Faker<Categoria>("pt_BR").RuleFor(c => c.Codigo, f => f.Random.Int())
                                                     .RuleFor(c => c.Descricao, f => f.Name.ToString());

            _categorias = faker.Generate(100);

            _categoriaRepositorio.Setup(c => c.GetAll()).ReturnsAsync(() => _categorias);
            var categoriaResult = await _categoriaServico.GetCategorias();

            categoriaResult.Should().NotBeEmpty();
        }

        [Fact]
        public async Task GetCategoriaTest()
        {
            _categoria = _fixture.Create<Categoria>();

            _categoriaRepositorio.Setup(c => c.Get(It.IsAny<int>())).ReturnsAsync((int codigo) => _categoria);
            var categoriaResult = await _categoriaServico.GetCategoria(_categoria.Codigo);

            categoriaResult.Should().BeEquivalentTo(_categoria);
        }

        [Fact]
        public async Task SalvarCategoriaTest()
        {
            _categoria = _fixture.Create<Categoria>();

            _categoriaRepositorio.Setup(c => c.Add(It.IsAny<Categoria>())).ReturnsAsync(() => _categoria);
            await _categoriaServico.SaveCategoria(_categoria);

            Assert.True(true);
        }

        [Fact]
        public async Task EditarCategoriaTest()
        {
            _categoria = _fixture.Create<Categoria>();

            _categoriaRepositorio.Setup(c => c.Update(It.IsAny<Categoria>())).ReturnsAsync(() => _categoria);
            await _categoriaServico.EditarCategoria(_categoria);

            Assert.True(true);
        }
    }
}
