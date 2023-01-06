using System;
using System.Collections.Generic;

namespace Prueba_Dav.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nombre { get; set; }

    public string? Cedula { get; set; }

    public string? Direccion { get; set; }

    public string? Correo { get; set; }

    public string? Telefono { get; set; }

    public virtual ICollection<UnidadesRegistrada> UnidadesRegistrada { get; } = new List<UnidadesRegistrada>();
}
