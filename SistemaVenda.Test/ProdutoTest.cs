using Bogus;
using Microsoft.Extensions.Logging;
using Moq;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Interface;
using SistemaVenda.Dominio.Repositorio;
using SistemaVenda.Dominio.Servicos;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace SistemaVenda.Test
{
    [Collection("Produto")]
    public class ProdutoTest
    {
        private readonly Mock<IProdutoRepositorio> _produtoRepMock;
        private readonly IProdutoService _produtoService;
        private readonly ILogger<ProdutoServico> _logger;

        private IList<Produto> _produtos;
        private Produto _produto;
        private int _id = 0;

        public ProdutoTest()
        {
            _logger = new LoggerFactory().CreateLogger<ProdutoServico>();
            _produtoRepMock = new Mock<IProdutoRepositorio>();
            _produtoService = new ProdutoServico(_produtoRepMock.Object, _logger);
        }

        [Fact]
        public async Task GetProdutosTest()
        {
            var faker = new Faker<Produto>().RuleFor(p => p.Codigo, ++_id)
                                            .RuleFor(p => p.Descricao, f => f.Name.ToString())
                                            .RuleFor(p => p.Quantidade, f => f.Random.Double())
                                            .RuleFor(p => p.Valor, f => f.Random.Decimal())
                                            .RuleFor(p => p.CodigoCategoria, f => f.Random.Int());

            _produtos = faker.Generate(100);

            _produtoRepMock.Setup(p => p.GetAll()).ReturnsAsync(() => _produtos);
            var produtosRet = await _produtoService.GetProdutos();

            produtosRet.Should().BeEquivalentTo(_produtos);
        }
    }
}
