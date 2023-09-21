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
    public partial class frmCalcularEnvio : Form
    {
        public frmCalcularEnvio()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            frmPagos Pagos = new frmPagos();
            this.Hide();
            Pagos.Show();
        }

        private void frmCalcularEnvio_Load(object sender, EventArgs e)
        {

        }
    }
}
