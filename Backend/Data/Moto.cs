using System;
using System.Collections.Generic;

namespace Backend.Data;

public partial class Moto
{
    public int Id { get; set; }

    public string? Placa { get; set; }

    public string? Marca { get; set; }

    public string? Linea { get; set; }

    public int? Cilindraje { get; set; }

    public int? Modelo { get; set; }

    public int? Precio { get; set; }

    public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
