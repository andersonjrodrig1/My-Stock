using Microsoft.EntityFrameworkCore;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVenda.Repositorio.Repositorio
{
    public class UsuarioRepositorioImpl : BaseRepositorioImpl<Usuario>, IUsuarioRepositorio
    {
        private readonly ApplicationDbContext _dbContext;

        public UsuarioRepositorioImpl(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Usuario> GetUsuarioAutentication(string email, string senha) => await _dbContext.Set<Usuario>().AsQueryable()
                                                                                                          .AsNoTracking()
                                                                                                          .FirstOrDefaultAsync(x => x.Email.Equals(email) && x.Senha.Equals(senha));
    }
}
