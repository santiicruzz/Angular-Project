using Backend.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoPagoController : ControllerBase
    {
        private MotosContext _tipoPagoContext;
        public TipoPagoController(MotosContext tipoPagoContext)
        {
            _tipoPagoContext = tipoPagoContext;
        }

        // GET: api/<TipoPagoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<TipoPagoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TipoPagoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TipoPago tipoPagoObj)
        {
            if (tipoPagoObj == null)
            {
                var tipoPago = new TipoPago
                {
                    Id = tipoPagoObj.Id,
                    Nombre = tipoPagoObj.Nombre
                };
                await _tipoPagoContext.AddAsync(tipoPago);
                await _tipoPagoContext.SaveChangesAsync();
            }
            return Ok(new {mensaje="Nuevo tipo de pago registrado"});
        }

        // PUT api/<TipoPagoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TipoPagoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}