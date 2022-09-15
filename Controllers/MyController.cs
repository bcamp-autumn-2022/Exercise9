using Microsoft.AspNetCore.Mvc;
namespace Exercise9.Controllers;
[ApiController]
[Route("[controller]")]

    public class MyController: ControllerBase
    {
        [HttpGet()]
        public string GetFirst(){
            return "I am the first test";
        }
        
    }
