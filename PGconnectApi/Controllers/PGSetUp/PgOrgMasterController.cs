using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PGconnectApi.Controllers.PGSetUp
{
    [Route("api/[controller]")]
    [ApiController]
    public class PgOrgMasterController : ControllerBase
    {
        // GET: api/<PgOrgMasterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PgOrgMasterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PgOrgMasterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PgOrgMasterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PgOrgMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
