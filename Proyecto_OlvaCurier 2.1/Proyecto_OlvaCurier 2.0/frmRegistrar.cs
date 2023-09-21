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
    public partial class frmRegistrar : Form
    {
        
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            DialogResult r = MessageBox.Show("Seguro que desea registrar o modificar", "Registro de Clientes",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes)
            {
                cmbTipoDoc.Text = "";
                txtNumDocumento.Text = "";
                txtNombre.Text = "";
                txtApellidos.Text = "";
                txtCorreo.Text = "";
                txtDireccion.Text = "";
                date.Text = "";
                txtTelefono.Text = "";
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
