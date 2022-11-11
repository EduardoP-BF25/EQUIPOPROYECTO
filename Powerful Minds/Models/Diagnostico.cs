using WebApi.Models.Base;

namespace WebApi.Models;

    public class Diagnostico : Model
    {
        public int? IdPaciente {get; set;}
        public int? IdTest {get; set;}

        public string? Name {get; set; }

    }
