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
    public partial class frmQR : Form
    {
        public frmQR()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmQR_Load(object sender, EventArgs e)
        {
            pbQRyape.Visible = false;
            pbQRplin.Visible = false;
            pbQRtunki.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pbQRyape.Visible = true;
            pbQRplin.Visible = false;
            pbQRtunki.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pbQRyape.Visible = false;
            pbQRplin.Visible = true;
            pbQRtunki.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pbQRyape.Visible = false;
            pbQRplin.Visible = false;
            pbQRtunki.Visible = true;
        }
    }
}
