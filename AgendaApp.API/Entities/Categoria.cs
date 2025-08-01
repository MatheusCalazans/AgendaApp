namespace AgendaApp.API.Entities
{
    public class Categoria
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; } = string.Empty;

        #region Relacionamentos

        public List<Tarefa> Tarefas { get; set; } = new();

        #endregion
    }
}
