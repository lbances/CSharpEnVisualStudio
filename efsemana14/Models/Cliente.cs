using System;
using System.Collections.Generic;

namespace efsemana14.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public int Numdoc { get; set; }

    public string NomCliente { get; set; } = null!;

    public string ApeCliente { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public int TelCliente { get; set; }

    public string DirCliente { get; set; } = null!;

    public string TipoDocCliente { get; set; } = null!;

    public string? IdRol { get; set; }
}
