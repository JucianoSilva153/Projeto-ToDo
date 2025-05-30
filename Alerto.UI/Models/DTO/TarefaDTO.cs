namespace Todo.Models.DTO;

public class CriaTarefaDTO
{
    public string Tarefa { get; set; }
    public string Prioridade { get; set; }
    public string Descricao { get; set; }
    public string? Categoria { get; set; }
    public string? Lista { get; set; }
    public DateTime Conclusao { get; set; }
}

public class ListaTarefaDTO {
    public Guid Id { get; set; }
    public string Tarefa { get; set; }
    public string Prioridade { get; set; }
    public string Descricao { get; set; }
    public DateTime Conclusao { get; set; }
    public DateTime Criacao { get; set; }
    public bool Concluida { get; set; }
    public string? Categoria { get; set; }
    public string? ListaPertencente { get; set; }
}

public class AlteraTarefaDTO
{
    public Guid Id { get; set; }
    public string Tarefa { get; set; }
    public string Prioridade { get; set; }
    public string Descricao { get; set; }
    public DateTime Conclusao { get; set; }
    public bool Concluida { get; set; }
    public string? Categoria { get; set; }
    public string? ListaPertencente { get; set; }
}