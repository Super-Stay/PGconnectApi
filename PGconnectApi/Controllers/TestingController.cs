using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PGconnectApi.Data;
using PGconnectApi.Models;

namespace PGconnectApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestingController : ControllerBase
    {
        private readonly PgConnectDbContext dbContext;

        public TestingController(
            PgConnectDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        //[HttpGet]
        //public IActionResult GetTestingDetails()
        //{
        //    var Testing =  dbContext.Testings.ToList();
        //    return Ok(Testing);
        //}

        [HttpGet]
        public async Task<ActionResult<IEnumerable<testing>>> GetTestingDetails()
        {
            var Details = await dbContext.Testings.ToListAsync();
            return Details;
        }
    }
}
