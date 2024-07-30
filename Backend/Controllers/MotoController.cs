using Backend.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoController : ControllerBase
    {
        private MotosContext _motoContext;
        public MotoController(MotosContext motoContext)
        {
            _motoContext = motoContext;
        }        // GET: api/<MotoController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MotoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MotoController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Moto motoObj)
        {
            if (motoObj == null)
            {
                var moto = new Moto
                {
                    Placa = motoObj.Placa,
                    Marca = motoObj.Marca,
                    Linea = motoObj.Linea,
                    Cilindraje = motoObj.Cilindraje,
                    Modelo = motoObj.Modelo,
                    Precio = motoObj.Precio
                };
                await _motoContext.AddAsync(moto);
                await _motoContext.SaveChangesAsync();
            }
            return Ok(new {mensaje="Nueva moto creada"});
        }

        // PUT api/<MotoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MotoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
