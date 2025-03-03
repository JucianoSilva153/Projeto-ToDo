namespace API.ToDo.DTO;

public class AdicionarEditarContaDTO
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Contacto { get; set; }
    public string Password { get; set; }
}

public class AutenticarContaDTO
{
    public string Email { get; set; }
    public string Password { get; set; }
}

public class RetornarContaDTO
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public int Contacto { get; set; }
}