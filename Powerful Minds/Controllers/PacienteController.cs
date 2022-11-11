using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;


namespace WebAppi.Controllers;

    [ApiController, Route ("api/[controller]")]

    public class PacienteController : ApiControllerBase<Paciente>
    {
        public PacienteController(DataContext context, ILogger<Paciente> logger) : base (context, logger){
        
    }
    }
