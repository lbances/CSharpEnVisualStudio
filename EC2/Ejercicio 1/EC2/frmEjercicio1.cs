using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EC2
{
    public partial class frmEjercicio1 : Form
    {
        public frmEjercicio1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] Nombres = new string[14];
            Nombres[0] = "Luis";
            Nombres[1] = "Francisco";
            Nombres[2] = "Hugo";
            Nombres[3] = "Juan";
            Nombres[4] = "Miguel";
            Nombres[5] = "Felix";
            Nombres[6] = "Ramón";
            Nombres[7] = "Fidel";
            Nombres[8] = "Fernando";
            Nombres[9] = "Luciana";
            Nombres[10] = "Sandra";
            Nombres[11] = "Mathias";
            Nombres[12] = "Samantha";
            Nombres[13] = "Felipe";
            for (int i = 0; i < 14; i++)
            {
                lstNombres.Items.Add(Nombres[i]);
            }

            String[] Productos = new string[14];
            Productos[0] = "Zapatos";
            Productos[1] = "Buzo";
            Productos[2] = "Zapatos";
            Productos[3] = "Camisas";
            Productos[4] = "Buzo";
            Productos[5] = "Zapatos";
            Productos[6] = "Zapatos";
            Productos[7] = "Camisa";
            Productos[8] = "Pantalón";
            Productos[9] = "Camisa";
            Productos[10] = "Pantalón";
            Productos[11] = "Camisa";
            Productos[12] = "Buzo";
            Productos[13] = "Zapato";
            for (int i = 0; i < 14; i++)
            {
                lstProductos.Items.Add(Productos[i]);
            }

            int[] Cantidad = new int[14];
            Cantidad[0] = 4;
            Cantidad[1] = 1;
            Cantidad[2] = 2;
            Cantidad[3] = 3;
            Cantidad[4] = 3;
            Cantidad[5] = 1;
            Cantidad[6] = 2;
            Cantidad[7] = 3;
            Cantidad[8] = 2;
            Cantidad[9] = 2;
            Cantidad[10] = 3;
            Cantidad[11] = 1;
            Cantidad[12] = 2;
            Cantidad[13] = 1;
            for (int i = 0; i < 14; i++)
            {
                lstCantidad.Items.Add(Cantidad[i]);
            }

            double[] Precio = new double[14];
            Precio[0] = 90.00;
            Precio[1] = 98.00;
            Precio[2] = 100.00;
            Precio[3] = 100.00;
            Precio[4] = 110.00;
            Precio[5] = 150.00;
            Precio[6] = 130.00;
            Precio[7] = 140.00;
            Precio[8] = 75.50;
            Precio[9] = 135.20;
            Precio[10] = 98.00;
            Precio[11] = 200.00;
            Precio[12] = 79.00;
            Precio[13] = 150.00;
            for (int i = 0; i < 14; i++)
            {
                lstPrecio.Items.Add(Precio[i]);
            }

            double[] Total = new double[14];
            Total[0] = 360.00;
            Total[1] = 98.00;
            Total[2] = 200.00;
            Total[3] = 300.00;
            Total[4] = 330.00;
            Total[5] = 150.00;
            Total[6] = 260.00;
            Total[7] = 420.00;
            Total[8] = 151.00;
            Total[9] = 270.00;
            Total[10] = 294.00;
            Total[11] = 200.00;
            Total[12] = 158.00;
            Total[13] = 150.00;
            for (int i = 0; i < 14; i++)
            {
                lstTotal.Items.Add(Total[i]);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            double totalCamisas = 0;
            totalCamisas = 300.00 + 420.00 + 270.40 + 200.00;
            txt1.Text = "Los clientes pagaron S/" + totalCamisas + " por sus camisas";

            txt2.Text = "El producto mas barato fue el pantalón";

            double totalIGV = 0;
            totalIGV = (360.00 + 98.00 + 200.00 + 300.00 + 330.00 + 150.00 + 260.00 + 420.00 + 151.00 + 270.00 + 294.00 + 200.00 + 158.00 + 150.00) * 0.18;
            txt3.Text = "Los clientes en IGV pagaron S/" + totalIGV;

            txt4.Text = "El producto mas comprado fue el zapato";
        }
    }
    
}
