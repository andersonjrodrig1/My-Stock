using Microsoft.EntityFrameworkCore;
using SistemaVenda.Dominio.Entidades;
using SistemaVenda.Dominio.Repositorio;
using System.Linq;

namespace SistemaVenda.Repositorio.Repositorio
{
    public class UsuarioRepositorioImpl : BaseRepositorioImpl<Usuario>, IUsuarioRepositorio
    {
        private readonly ApplicationDbContext _dbContext;

        public UsuarioRepositorioImpl(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Usuario GetUsuarioAutentication(string email, string senha) => 
            _dbContext.Set<Usuario>().AsQueryable()
                                     .AsNoTracking()
                                     .FirstOrDefault(x => x.Email.Equals(email) && x.Senha.Equals(senha));
    }
}
