using System.ComponentModel.DataAnnotations.Schema;
namespace Backend.Data.SP
{
    public class SpVentasListar
    {
        [Column("marca")]
        public string marca { get; set; }
        [Column("cilindraje")]
        public int cilindraje { get; set; }
        [Column("modelo")]
        public int modelo { get; set; }
        [Column("precio")]
        public int precio { get; set; }
        [Column("nombre")]
        public string metodoPago { get; set; }
        [Column("fecha")]
        public DateTime fechaVenta { get; set; }
    }
}
