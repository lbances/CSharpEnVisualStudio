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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            String[] Nombres = new string[5];
            Nombres[0] = "Luis";
            Nombres[1] = "Francisco";
            Nombres[2] = "Hugo";
            Nombres[3] = "Juan";
            Nombres[4] = "Miguel";
            
            for (int i = 0; i < 5; i++)
            {
                lstUsuarios.Items.Add(Nombres[i]);
            }

            lblContador.Text = "0";

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblContador.Text = lstUsuarios.Text.Length.ToString();
        }

        private void lstUsuarios_SelectedValueChanged(object sender, EventArgs e)
        {
            lblContador.Text = lstUsuarios.Text.Length.ToString();
        }

        private void lstUsuarios_ChangeUICues(object sender, UICuesEventArgs e)
        {
            //lblContador.Text = lstUsuarios;   //ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegistrar formulario = new frmRegistrar();
            formulario.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro que desea eliminar", "Eliminar ",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmRegistrar formulario = new frmRegistrar();
            formulario.ShowDialog();
        }
    }
}
