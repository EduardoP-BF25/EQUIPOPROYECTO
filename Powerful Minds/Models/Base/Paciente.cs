using WebApi.Models.Base;

namespace WebApi.Models;

    public class Paciente : Model
    {
        public int? Id {get; set;}
        public string? Name {get; set; }

        public int? Tel {get; set;}

        public string? Correo {get; set;}

        public int? Edad {get; set;}

    }
