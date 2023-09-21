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

        public List<ClientesDTO> ObtenerClientes() //Metodo
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

        public List<ProductosDTO> ObtenerProductos() //Metodo
        {
            try
            {
                using (BD_OlvaEntities _context = new BD_OlvaEntities())
                {
                    var consulta = (from n in _context.Productoes
                                    select new ProductosDTO
                                    {
                                        Id = n.Id,
                                        Descripcion = n.Descripcion,
                                        FechaEnvio = n.FechaEnvio,
                                        DireccionDestino = n.DireccionDestino,
                                        Precio = n.Precio,
                                        IdDestinatario = n.IdDestinatario,
                                        IdCliente = n.IdCliente}
                                     ).ToList();
                    return consulta;
                }
            }
            catch
            {
                throw;
            }
        }

        public List<EmpleadoDTO> ObtenerEmpleado() //Metodo
        {
            try
            {
                using (BD_OlvaEntities _context = new BD_OlvaEntities())
                {
                    var consulta = (from n in _context.Empleadoes

                                    select new EmpleadoDTO
                                    {
                                        Id = n.Id,
                                        Nombres = n.Nombres,
                                        Apellidos = n.Apellidos,
                                        Dni = n.Dni,
                                        Cargo = n.Cargo,
                                        Telefono = n.Telefono,
                                        FechaNac = n.FechaNac
                                    }
                                     ).ToList();
                    return consulta;
                }
            }
            catch
            {
                throw;
            }
        }

        public List<DestinatarioDTO> ObtenerDestinatario() //Metodo
        {
            try
            {
                using (BD_OlvaEntities _context = new BD_OlvaEntities())
                {
                    var consulta = (from n in _context.Destinatarios
                                    select new DestinatarioDTO
                                    {
                                        Id = n.Id,
                                        Nombres = n.Nombres,
                                        Apellidos = n.Apellidos,
                                        Dni= n.Dni,                                       
                                        Direccion = n.Direccion,
                                        Telefono = n.Telefono,
                                        Correo = n.Correo                                    
                                    }
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
            dataGridView1.DataSource = ObtenerEmpleado();
            dataGridView2.DataSource = ObtenerDestinatario();
            dataGridView3.DataSource = ObtenerClientes();
            dataGridView4.DataSource = ObtenerProductos();
        }
    }
}
