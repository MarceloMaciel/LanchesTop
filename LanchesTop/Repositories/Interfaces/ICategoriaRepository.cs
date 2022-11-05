using LanchesTop.Models;

namespace LanchesTop.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get;  }
    }
}
