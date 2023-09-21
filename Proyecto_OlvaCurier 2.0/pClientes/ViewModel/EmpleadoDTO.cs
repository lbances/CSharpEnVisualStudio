using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pClientes.ViewModel
{
    public class EmpleadoDTO
    {
        public int Id { get; set; } //variable
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Dni { get; set; }
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public Nullable<System.DateTime> FechaNac { get; set; }
    }
}
