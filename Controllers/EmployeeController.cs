using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitTestDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController()
        {
            Console.Write("test");  
        }
    }
}
