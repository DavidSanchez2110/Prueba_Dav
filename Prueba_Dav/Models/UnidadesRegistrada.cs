using System;
using System.Collections.Generic;

namespace Prueba_Dav.Models;

public partial class UnidadesRegistrada
{
    public int IdUnidad { get; set; }

    public string? CodCaja { get; set; }

    public string? CodUnidad { get; set; }

    public int? IdCliente { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }
}
