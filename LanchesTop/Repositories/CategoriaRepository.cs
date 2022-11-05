using LanchesTop.Context;
using LanchesTop.Models;
using LanchesTop.Repositories.Interfaces;

namespace LanchesTop.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;

        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
