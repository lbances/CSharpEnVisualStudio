using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using pClientes.ViewModel;
using pClientes.Model;

namespace pClientes
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        public List<ClientesDTO> ObtenerClientes()
        {
            try
            {
                using (BD_OlvaEntities _context = new BD_OlvaEntities())
                {
                    var consulta = (from n in _context.Clientes
                                     select new ClientesDTO { 
                                        Id = n.Id,
                                        TipoDoc = n.TipoDoc,
                                        NumDoc = n.NumDoc,
                                        Nombres = n.Nombres,
                                        Apellidos = n.Apellidos,
                                        Correo = n.Correo,
                                        Direccion = n.Direccion,
                                        FechaNac = n.FechaNac,
                                        Telefono = n.Telefono,
                                        IdEmpleado = n.IdEmpleado}
                                     ).ToList();
                    return consulta;
                }
            }
            catch
            {
                throw;
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ObtenerClientes();
        }
    }
}
