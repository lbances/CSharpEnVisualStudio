using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC3_Grupo7
{
    public partial class frmEjercicio1 : Form
    {

        List<string> listDocCliente = new List<string>();
        List<string> listNombreCliente = new List<string>();
        List<string> listBaseIm = new List<string>();
        List<string> listTotalComprobante = new List<string>();

        public void laBaseImponible()
        {
            //double BaseImponile;
            //double totalComprobante;
            //BaseImponile = Double.Parse(txtBaseIm.Text);

            //if (cbTipoComprobantes.SelectedIndex == 1)
            //{
            //    totalComprobante = BaseImponile * 0.18;
            //}

            //else
            //{
            //    totalComprobante = BaseImponile;
            //}
        }

        public void comboBox()
        {
            if (cbTipoComprobantes.SelectedIndex == 1)
            {
                txtDocumento.MaxLength = 11;
                txtIGV.Text = "18%";
                txtIGV.Enabled = false;
            }

            else if (cbTipoComprobantes.SelectedIndex == 2)
            {
                txtDocumento.MaxLength = 8;
                txtIGV.Text = "0%";
                txtIGV.Enabled = false;
            }
        }

        public void vacioComboBox()
        {
            if (cbTipoComprobantes.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar un Tipo de comprobante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void vacioTxtDocumento()
        {
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("El campo Doc cliente no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void vacioTxtNombre()
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El campo Nombre cliente no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void vacioTxtBaseIm()
        {
            if (txtBaseIm.Text == "")
            {
                MessageBox.Show("El campo Base imponible no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void vacioTxtIGV()
        {
            if (txtIGV.Text == "")
            {
                MessageBox.Show("El campo IGV no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void vacioTxtTotalComprobante()
        {
            if (txtTotalComprobante.Text == "")
            {
                MessageBox.Show("El campo Total comprobante no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void aletarCamposVacios()
        {
            if (txtDocumento.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Error Olva Curier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtNombre.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Error Olva Curier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtBaseIm.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Error Olva Curier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtIGV.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Error Olva Curier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtTotalComprobante.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Error Olva Curier", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void borrarControles()
        {
            cbTipoComprobantes.Text = "Seleccionar";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtBaseIm.Text = "";
            txtIGV.Text = "";
            txtTotalComprobante.Text = "";
        }

        public frmEjercicio1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTipoComprobantes.Items.Add("Seleccionar");
            cbTipoComprobantes.Items.Add("Factura");
            cbTipoComprobantes.Items.Add("Boleta");

            //cbTipoComprobantes.Text = "Seleccionar";

            //comboBox();

            lstTipoComprobanteError.Visible = false;
            txtIGV.Enabled = false;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (cbTipoComprobantes.SelectedIndex == 0)
            {
                aletarCamposVacios();
                lstTipoComprobanteError.Visible = false;
                lstTipoComprobanteError.Items.Add("");
            }

            else if (cbTipoComprobantes.SelectedIndex == 0)
            {
                vacioComboBox();
            }
            

            else if (txtDocumento.Text == "")
            {
                vacioTxtDocumento();
            }

            else if(txtNombre.Text == "")
            {
                vacioTxtNombre();
            }

            else if (txtBaseIm.Text == "")
            {        
                vacioTxtBaseIm();
            }

            if (cbTipoComprobantes.SelectedIndex == 1 && txtDocumento.Text.Length >1 && txtNombre.Text.Length > 1 && txtBaseIm.Text.Length > 1)
            {
                lstTipoComprobante.Items.Add(cbTipoComprobantes.SelectedItem.ToString());
                string docCliente;
                string nombreCliente;
                string baseImponible;
                //double BaseImponile;
                string igv;
                string TotalComprobante;

                //BaseImponile = Double.Parse(txtBaseIm.Text);

                //if (cbTipoComprobantes.SelectedIndex == 1)
                //{
                //    TotalComprobante = BaseImponile * 0.18;
                //}

                //else if (cbTipoComprobantes.SelectedIndex == 2)
                //{
                //    TotalComprobante = BaseImponile;
                //}

                docCliente = txtDocumento.Text;
                nombreCliente = txtNombre.Text;
                baseImponible = txtBaseIm.Text;
                igv = txtIGV.Text;
                TotalComprobante = txtTotalComprobante.Text;

                lstDocumento.Items.Add(docCliente);
                lstNombre.Items.Add(nombreCliente);
                lstBaseIm.Items.Add(baseImponible);

                if (cbTipoComprobantes.SelectedIndex == 1)
                {
                    igv = "18%";
                }

                else if (cbTipoComprobantes.SelectedIndex == 2)
                {
                    igv = "0%";
                }

                lstIGV.Items.Add(igv);
                lstTotalComprobante.Items.Add(TotalComprobante);

                borrarControles();
            }

            else if (cbTipoComprobantes.SelectedIndex == 2 && txtDocumento.Text.Length > 1 && txtNombre.Text.Length > 1 && txtBaseIm.Text.Length > 1 && txtIGV.Text.Length > 1 && txtTotalComprobante.Text.Length > 1)
            {
                lstTipoComprobante.Items.Add(cbTipoComprobantes.SelectedItem.ToString());
                string docCliente;
                string nombreCliente;
                string baseImponible;
                string totalComprobante;
                int igv = 18;

                docCliente = txtDocumento.Text;
                nombreCliente = txtNombre.Text;
                baseImponible = txtBaseIm.Text;
                totalComprobante = txtTotalComprobante.Text;

                lstDocumento.Items.Add(docCliente);
                lstNombre.Items.Add(nombreCliente);
                lstBaseIm.Items.Add(baseImponible);
                //lstIGV.Items.Add(igv + "%");
                lstTotalComprobante.Items.Add(totalComprobante);

                borrarControles();
            }

            

            //string docCliente;
            //string nombreCliente;
            //string baseImponible;
            //string totalComprobante;
            //int igv = 18;

            //docCliente = txtDocumento.Text;
            //nombreCliente = txtNombre.Text;
            //baseImponible = txtBaseIm.Text;
            //totalComprobante = txtTotalComprobante.Text;

            //lstDocumento.Items.Add(docCliente);
            //lstNombre.Items.Add(nombreCliente);
            //lstBaseIm.Items.Add(baseImponible);
            ////lstIGV.Items.Add(igv + "%");
            //lstTotalComprobante.Items.Add(totalComprobante);

            //borrarControles();

            //lstDocumento.Add(txtDocumento);
            //lstNombre.Items.Add(txtNombre.ToString());
            //lstBaseIm.Items.Add(txtBaseIm.ToString());
            //lstIGV.Items.Add(txtIGV.ToString());
            //lstTotalComprobante.Items.Add(txtTotalComprobante.ToString());
            //borrarControles();



            //lstTipoComprobanteError.Items.Add("");
            //borrarControles();
            //aletarCampoVacios();
            ////lstTipoComprobante.Items.Clear();
            //}
            //else
            //{
            //    lstTipoComprobante.Items.Add(cbTipoComprobantes.SelectedItem.ToString());
            //    lstTipoComprobante.Items.Add(txtDocumento);
            //    lstTipoComprobante.Items.Add(txtNombre);
            //    lstTipoComprobante.Items.Add(txtBaseIm);
            //    lstTipoComprobante.Items.Add(txtIGV);
            //    lstTipoComprobante.Items.Add(txtTotalComprobante);
            //    borrarControles();
            //}

            //lstTipoComprobante.Items.Add(cbTipoComprobantes.SelectedItem.ToString());

            //try
            //{


            //    //cbTipoComprobantes.SelectedIndex == 1;
            //    //cbTipoComprobantes.Items.Add("Factura");
            //    //cbTipoComprobantes.Items.Add("Boleta");

            //    precioSinIgv = Double.Parse(txtBaseIm.Text.ToString());

            //    lstBaseIm.Items.Add(precioSinIgv);

            //    borrarControles();
            //}

            //catch (Exception)
            //{
            //    MessageBox.Show("Oa");
            //}
        }

        private void cbTipoComprobantes_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox();
        }
    }
}
