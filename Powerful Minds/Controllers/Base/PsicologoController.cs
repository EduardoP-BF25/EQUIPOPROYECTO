using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebAppi.Controllers;

[ApiController, Route ("api/[controller]")]

public class PsicologoController : ApiControllerBase<Psicologo>
{
    public PsicologoController(DataContext context, ILogger<Psicologo> logger) : base (context, logger){
        
    }
}