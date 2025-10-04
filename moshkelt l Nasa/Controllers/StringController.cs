using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using moshkelt_l_Nasa.Data;
using moshkelt_l_Nasa.models;
using moshkelt_l_Nasa.Services.StringApi.Services;

namespace moshkelt_l_Nasa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StringController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StringController(AppDbContext context)
        {
            _context = context;
        }

        // POST api/string  → add one OR multiple records
        [HttpPost("Add")]
        public IActionResult AddStrings([FromBody] List<StringRecord> records)
        {
            if (records == null || records.Count == 0)
                return BadRequest("Request must contain at least one record.");

            // Ensure Id is not set for identity column
            foreach (var record in records)
            {
                record.Id = 0;
            }

            _context.Strings.AddRange(records);
            _context.SaveChanges();

            return Ok($"{records.Count} record(s) added successfully.");
        }

        // GET api/string → get all records
        [HttpGet("Get")]
        public IActionResult GetAll()
        {
            var result = _context.Strings.ToList();
            return Ok(result);
        }
    }
}
 
