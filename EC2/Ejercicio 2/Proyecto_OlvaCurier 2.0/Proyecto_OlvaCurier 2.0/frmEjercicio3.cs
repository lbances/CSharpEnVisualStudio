using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_OlvaCurier_2._0
{
    public partial class frmEjercicio3 : Form
    {

        public frmEjercicio3()//frmEjercicio3_btnNuevo.Datos info)
        {
            InitializeComponent();
            //lstClientes.Items.Add(info.TipoDoc);
            //lstClientes.Items.Add(info.NumeroDoc);
            //lstClientes.Items.Add(info.Nombres);
            //lstClientes.Items.Add(info.Apellidos);
            //lstClientes.Items.Add(info.Correo);
            //lstClientes.Items.Add(info.Direccion);
            //lstClientes.Items.Add(info.FechaNac);
            //lstClientes.Items.Add(info.Telefono);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea eliminar este elemento?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEjercicio3_btnNuevo Nuevo = new frmEjercicio3_btnNuevo();
            this.Hide();
            Nuevo.Show();
        }
    }
}
