using Microsoft.AspNetCore.Mvc;
using WebApi.Controllers.Base;
using WebApi.Data;
using WebApi.Models;

namespace WebAppi.Controllers;

[ApiController, Route ("api/[controller]")]

public class TestController : ApiControllerBase<Test>
{
    public TestController(DataContext context, ILogger<Test> logger) : base (context, logger){
        
    }
}