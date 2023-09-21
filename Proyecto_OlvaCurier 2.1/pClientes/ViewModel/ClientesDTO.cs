using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pClientes.ViewModel
{
    public class ClientesDTO
    {
        public int Id { get; set; }
        public string TipoDoc { get; set; }
        public string NumDoc { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public Nullable<System.DateTime> FechaNac { get; set; }
        public string Telefono { get; set; }
        public Nullable<int> IdEmpleado { get; set; }

    }
}
