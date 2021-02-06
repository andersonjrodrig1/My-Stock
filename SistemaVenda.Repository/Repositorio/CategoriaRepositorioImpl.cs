using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using System.Threading.Tasks;

namespace SistemaVenda.Repositorio.Repositorio
{
    public class CategoriaRepositorioImpl : BaseRepositorioImpl<Categoria>, ICategoriaRepositorio
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoriaRepositorioImpl(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
