using Backend.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoDocumentoController : ControllerBase
    {
        private MotosContext _TipoDocumentoContext;
        public TipoDocumentoController(MotosContext tipoPagoContext)
        {
            _TipoDocumentoContext = tipoPagoContext;
        }
        // GET: api/<TipoDocumentoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TipoDocumentoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoDocumentoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TipoDocumento tipoDocumentoObj)
        {
            if (tipoDocumentoObj == null)
            {
                var tipoDocumento = new TipoDocumento
                {
                    Id = tipoDocumentoObj.Id,
                    Nombre = tipoDocumentoObj.Nombre
                };
                await _TipoDocumentoContext.AddAsync(tipoDocumento);
                await _TipoDocumentoContext.SaveChangesAsync();
            }
            return Ok(new {mensaje="Nuevo tipo de documento creado"});
        }

        // PUT api/<TipoDocumentoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoDocumentoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
