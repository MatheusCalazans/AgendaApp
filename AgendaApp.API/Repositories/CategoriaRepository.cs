using AgendaApp.API.Contexts;
using AgendaApp.API.Entities;

namespace AgendaApp.API.Repositories
{
    /// <summary>
    /// Repositorio de dados para categoria.
    /// </summary>
    public class CategoriaRepository
    {
        public List<Categoria> ObterTodos()
        {
            using (var context = new DataContext())
            {
                return context
                    .Set<Categoria>()
                    .OrderBy(c => c.Nome)
                    .ToList();
            }
        }
        public bool CategoriaExistente(Guid id)
        {
            using (var context = new DataContext())
            {
                return context
                        .Set<Categoria>()
                        .Any(c => c.Id == id);

            }
        }
    }
}
