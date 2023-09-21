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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == "")
            {
                epUsuario.SetError(txtUsuario, "El campo Usuario es requerido.");
                epContraseña.SetError(txtContraseña, "El campo Contraseña es requerido.");
                txtUsuario.Focus();
            }

            else
            {
                epUsuario.Clear();
            }
        }

        private void txtContraseña_Validated(object sender, EventArgs e)
        {
            if (txtContraseña.Text.Trim() == "")
            {
                epContraseña.SetError(txtContraseña, "El campo Contraseña es requerido.");
                txtContraseña.Focus();
            }

            else
            {
                epContraseña.Clear();
            }
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario1" && txtContraseña.Text == "123456")
            {
                frmPrincipal Principal = new frmPrincipal();
                this.Hide();
                Principal.Show();
            }

            else
            {
                MessageBox.Show("El usuario o contraseña ingresados son incorrectos.", "Olva Curier", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblRestablecer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRestablecer Restablecer = new frmRestablecer();
            this.Hide();
            Restablecer.Show();
        }
    }
}
