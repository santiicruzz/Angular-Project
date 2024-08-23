using Backend.Data;
using Backend.Data.SP;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IEnumerable<SpVentasListar>> GetVentas()
        {
            IEnumerable<SpVentasListar> listadoVenta = await _motosContext.SpVentaListar();
            return listadoVenta;
        }


        // GET api/<VentasController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVentaById (int id)
        {
            var venta = await _motosContext.Ventas.FindAsync(id);
            if (venta != null)
            {
                return Ok(venta);
            }
            return NotFound();
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
        [HttpPut]
        public async Task<IActionResult> PutVenta([FromBody] Venta ventaObj)
        {
            var venta = await _motosContext.Ventas.FindAsync(ventaObj.IdVenta);
            if (venta == null)
            {
                return BadRequest();
            }
            venta.Fecha = ventaObj.Fecha;
            venta.TipoPago = ventaObj.TipoPago;
            venta.Precio = ventaObj.Precio;
            venta.IdMoto = ventaObj.IdMoto;
            venta.IdVendedor = ventaObj.IdVendedor;
            venta.NombreVendedor = ventaObj.NombreVendedor;
            venta.ApellidoVendedor = ventaObj.ApellidoVendedor;
            venta.TipoDocumento = ventaObj.TipoDocumento;
            venta.NumeroDocumento = ventaObj.NumeroDocumento;
            venta.NombreCliente = ventaObj.NombreCliente;
            venta.ApellidoCliente = ventaObj.ApellidoCliente;
            venta.CorreoCliente = ventaObj.CorreoCliente;
           
            _motosContext.Entry(venta).State=EntityState.Modified;
            await _motosContext.SaveChangesAsync();
            return Ok(new { mensaje = "Venta actualizada"});
        
        }

        // DELETE api/<VentasController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVenta(int id)
        {
            try
            {
                var venta = await _motosContext.Ventas.FindAsync(id);
                if (venta == null)
                    return BadRequest();
                _motosContext.Ventas.Remove(venta);
                await _motosContext.SaveChangesAsync();
                return Ok(new { mensaje = "Venta eliminada" });
            }
            catch(Exception ex) 
            {
                  return BadRequest(ex.ToString());
            }
        }
    }
}
