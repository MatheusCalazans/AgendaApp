using AgendaApp.API.Contexts;
using AgendaApp.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgendaApp.API.Repositories
{
    public class TarefaRepository
    {
        public void Inserir(Tarefa tarefa)
        {
            using (var context = new DataContext())
            {
                context.Add(tarefa);
                context.SaveChanges();
            }
        }

        public void Atualizar(Tarefa tarefa)
        {
            using (var context = new DataContext())
            {
                context.Update(tarefa);
                context.SaveChanges();
            }
        }

        public void Excluir(Tarefa tarefa)
        {
            using (var context = new DataContext())
            {
                context.Remove(tarefa);
                context.SaveChanges();
            }
        }
        
        public List<Tarefa> ObterPorData(DateTime dataHoraInicio, DateTime dataHoraFim)
        {
            using (var context = new DataContext())
            {
                return context
                    .Set<Tarefa>()
                    .Include(t => t.Categoria)
                    .Where(t => t.DataHora >= dataHoraInicio && t.DataHora <= dataHoraFim)
                    .OrderByDescending(t => t.DataHora)
                    .ToList();
            }
        }
        /// <summary>
        /// Método para consultar uma tarefa pelo ID.
        /// </summary>
        
        public Tarefa? ObterPorId(Guid id)
        {
            using (var context = new DataContext())
            {
                return context
                    .Set<Tarefa>()
                    .SingleOrDefault(t => t.Id == id);
            }
        }
    }
}
