using WebApi.Models.Base;

namespace WebApi.Models;

public class Test: Model
{
    public int? Id {get; set;}

    public string? Name {get; set; }

    public string? Preguntas {get; set;}

    public string? Respuestas {get; set;}

    public int? IdPaciente {get; set;}
    
    public string? Paciente {get; set;}

}