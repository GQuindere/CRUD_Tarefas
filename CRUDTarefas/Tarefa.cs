using System.ComponentModel.DataAnnotations;

namespace CRUDTarefas
{
    public class Tarefa
    {
        public int Id { get; set; }
        [StringLength(20)] 
        public string Status { get; set; } = string.Empty;
        [StringLength(20)]
        public string Comentario {get; set;} = string.Empty;
        public TarefaTipo? TarefaTipo { get; set; }
    }
}