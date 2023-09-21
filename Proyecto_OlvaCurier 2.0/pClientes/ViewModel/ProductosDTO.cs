using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pClientes.ViewModel
{
    public class ProductosDTO
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaEnvio { get; set; }
        public string DireccionDestino { get; set; }
        public Nullable<double> Precio { get; set; }
        public Nullable<int> IdDestinatario { get; set; }
        public Nullable<int> IdCliente { get; set; }

        
    }
}
