using System;
using System.Collections.Generic;

namespace efsemana14.Models;

public partial class Solicitud
{
    public int IdSoli { get; set; }

    public string NomCliente { get; set; } = null!;

    public string ApeCliente { get; set; } = null!;

    public string TipoDocCli { get; set; } = null!;

    public int Numdoc { get; set; }

    public string DirCliente { get; set; } = null!;

    public int TelCliente { get; set; }

    public string Detalle { get; set; } = null!;

    public string NomSoporte { get; set; } = null!;

    public string NumDocSo { get; set; } = null!;
}
