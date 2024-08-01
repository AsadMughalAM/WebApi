using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
           return Ok(dbContext.Employees.ToList());
        }
    }
}
