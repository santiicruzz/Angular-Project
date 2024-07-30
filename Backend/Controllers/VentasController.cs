using Backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasController : ControllerBase
    {
        private MotosContext _motosContext;
        public VentasController(MotosContext motosContext)
        {
            _motosContext = motosContext;
        }
        // GET: api/<VentasController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VentasController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "caca";
        }

        // POST api/<VentasController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Venta ventaObj)
        {
            if (ventaObj != null)
            {
                var venta = new Venta
                {
                    Fecha = ventaObj.Fecha,
                    TipoPago = ventaObj.TipoPago,
                    Precio = ventaObj.Precio,
                    IdMoto = ventaObj.IdMoto,
                    IdVendedor = ventaObj.IdVendedor,
                    NombreVendedor = ventaObj.NombreVendedor,
                    ApellidoVendedor = ventaObj.ApellidoVendedor,
                    TipoDocumento = ventaObj.TipoDocumento,
                    NumeroDocumento = ventaObj.NumeroDocumento,
                    NombreCliente = ventaObj.NombreCliente,
                    ApellidoCliente = ventaObj.ApellidoCliente,
                    CorreoCliente = ventaObj.CorreoCliente
                };
                await _motosContext.AddAsync(venta);
                await _motosContext.SaveChangesAsync();
            }
            return Ok(new {mensaje="Venta Creada"});
        }

        // PUT api/<VentasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VentasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
