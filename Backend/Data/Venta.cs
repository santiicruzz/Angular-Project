using System;
using System.Collections.Generic;

namespace Backend.Data;

public partial class Venta
{
    public int IdVenta { get; set; }

    public DateTime Fecha { get; set; }

    public int TipoPago { get; set; }

    public int Precio { get; set; }

    public int IdMoto { get; set; }

    public int IdVendedor { get; set; }

    public string NombreVendedor { get; set; }

    public string ApellidoVendedor { get; set; }

    public int TipoDocumento { get; set; }

    public int NumeroDocumento { get; set; }

    public string NombreCliente { get; set; }

    public string ApellidoCliente { get; set; }

    public string CorreoCliente { get; set; } = null!;

    public virtual Moto? IdMotoNavigation { get; set; }
}
