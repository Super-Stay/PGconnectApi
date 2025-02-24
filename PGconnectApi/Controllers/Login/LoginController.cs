using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PGconnectApi.Data;
using PGconnectApi.Models;
using PGconnectApi.Models.LoginModels;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PGconnectApi.Controllers.Login
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly PgConnectDbContext dbContext;

        public LoginController(PgConnectDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // GET api/<LoginController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<login_master>> GetById(int id)
        {
            var loginDetails = await dbContext.LoginMaster.FirstOrDefaultAsync(temp => temp.LOGIN_ID == id);
            if (loginDetails == null)
            {
                return NotFound();
            }
            return Ok(loginDetails);
        }

        //localhost:5001/api/Login/GetLoginDetails
        // GET: api/<LoginController>
        [HttpGet("GetLoginDetails")]
        public async Task<ActionResult<IEnumerable<login_master>>> GetLoginDetails()
        {
            var LoginDetails = await dbContext.LoginMaster.ToListAsync();
            if (LoginDetails.Count < 1)
            {
                return NotFound();
            }
            return LoginDetails;
        }

        // POST api/<LoginController>
        [HttpPost]
        public void PostLoginDetails([FromBody] string value)
        {
        }

        // PUT api/<LoginController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LoginController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
