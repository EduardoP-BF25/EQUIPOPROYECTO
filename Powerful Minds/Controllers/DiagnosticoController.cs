using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;


namespace WebAppi.Controllers;

    [ApiController, Route ("api/[controller]")]

    public class DiagnosticoController : ApiControllerBase<Diagnostico>
    {
        public DiagnosticoController(DataContext context, ILogger<Diagnostico> logger) : base (context, logger){
        
    }
    }
