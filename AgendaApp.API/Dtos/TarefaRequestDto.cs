using System.ComponentModel.DataAnnotations;

namespace AgendaApp.API.Dtos
{
    public class TarefaRequestDto
    {
        [MaxLength(100, ErrorMessage = "O nome da tarefa deve ter no máximo {1} caracteres.")]
        [MinLength(8, ErrorMessage = "O nome da tarefa deve ter no mínimo {1} caracteres.")]
        [Required(ErrorMessage = "Informe o nome da tarefa.")]
        public string? Nome { get; set; }

        [RegularExpression(@"^\d{4}-\d{2}-\d{2}$", ErrorMessage = "A data deve estar no formato AAAA-MM-DD. Exemplo: 2023-10-01")]
        [Required(ErrorMessage = "Informe a data da tarefa.")]
        public string? Data { get; set; }

        [RegularExpression(@"^\d{2}:\d{2}$", ErrorMessage = "A hora deve estar no formato HH:mm. Exemplo: 14:30")]
        [Required(ErrorMessage = "Informe a hora da tarefa.")]
        public string? Hora { get; set; }

        [Required(ErrorMessage = "Informe a prioridade da tarefa.")]
        [Range(1, 3, ErrorMessage = "A prioridade deve estar entre (1) Alta, (2) Media ou (3) Baixa.")]
        public int? Prioridade { get; set; }
        [Required(ErrorMessage = "Informe o id da tarefa.")]
        public Guid? CategoriaId { get; set; }

    }
}
