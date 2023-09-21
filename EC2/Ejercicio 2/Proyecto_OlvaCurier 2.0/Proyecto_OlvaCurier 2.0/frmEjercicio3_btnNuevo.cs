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
    public partial class frmEjercicio3_btnNuevo : Form
    {

        public frmPrincipal Principal;

        public frmEjercicio3_btnNuevo()
        {
            InitializeComponent();
        }

        //public class Datos
        //{
        //    public string TipoDoc { get; set; }
        //    public string NumeroDoc { get; set; }
        //    public string Nombres { get; set; }
        //    public string Apellidos { get; set; }
        //    public string Correo { get; set; }
        //    public string Direccion { get; set; }
        //    public string FechaNac { get; set; }
        //    public string Telefono { get; set; }
        //}

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmEjercicio3 ejercicio3 = new frmEjercicio3();
            //ejercicio3.MdiParent = this;
            ejercicio3.Show();
        }

        private void frmEjercicio3_btnNuevo_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Datos info;

            //info.TipoDoc = txtTipoDoc.Text;
            //info.NumeroDoc = txtNumeroDoc.Text;
            //info.Nombres = txtNombres.Text;
            //info.Apellidos = txtApellidos.Text;
            //info.Correo = txtCorreo.Text;
            //info.Direccion = txtDireccion.Text;
            //info.FechaNac = txtFechaNac.Text;
            //info.Telefono = txtTelefono.Text;

            //frmEjercicio3 Listado = new frmEjercicio3(info);

            MessageBox.Show("¿Está seguro de los datos ingresados?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        }
    }
}
