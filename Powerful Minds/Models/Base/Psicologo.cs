using WebApi.Models.Base;

namespace WebApi.Models;

public class Psicologo: Model
{
    public string? Name {get; set; }

    public string? LastName {get; set; }

    public int? Tel {get; set;}

}