using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_OlvaCurrier
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text == "Grupo7" && txtContraseña.Text == "123456")
            {
                Principal Principal = new Principal();
                this.Hide();
                Principal.Show();

            } 
            
            else
            {
                MessageBox.Show("EL usuario o contraseña es incorrecto. Inténtelo nuevamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }

        private void lblRestablecer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Restablecer Restablecer = new Restablecer();
            this.Hide();
            Restablecer.Show();
        }
    }
}
