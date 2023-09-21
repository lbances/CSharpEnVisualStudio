using Microsoft.Win32;
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
    public partial class frmPrincipal : Form
    {



        public string Usuario { get; set; }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrar Registrar = new frmRegistrar();
            Registrar.MdiParent = this;
            Registrar.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta Venta = new frmVenta();
            Venta.MdiParent = this;
            Venta.Show();
        }

        private void tarifarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente ListadoClientes = new frmCliente();
            ListadoClientes.MdiParent = this;
            ListadoClientes.Show();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void tFechaActual_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToString("h:mm:ss");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuario 1";
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmEjercicio3 ejercicio3 = new frmEjercicio3();
            ejercicio3.MdiParent = this;
            ejercicio3.Show();
        }
    }
}
