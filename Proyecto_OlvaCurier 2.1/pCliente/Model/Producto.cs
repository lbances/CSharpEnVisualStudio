//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pCliente.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> FechaEnvio { get; set; }
        public string DireccionDestino { get; set; }
        public Nullable<double> Precio { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Destinatario Destinatario { get; set; }
    }
}
