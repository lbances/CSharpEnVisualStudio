namespace EC3_Grupo7
{
    partial class frmEjercicio1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstTipoComprobante = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoComprobantes = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtBaseIm = new System.Windows.Forms.TextBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.txtTotalComprobante = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstDocumento = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lstNombre = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lstFechaComprobante = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lstBaseIm = new System.Windows.Forms.ListBox();
            this.lstIGV = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lstTotalComprobante = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtNumerosBoletas = new System.Windows.Forms.TextBox();
            this.txtNumerosFacturas = new System.Windows.Forms.TextBox();
            this.txtNumerosComprobantes = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTotalBoletas = new System.Windows.Forms.TextBox();
            this.txtTotalFacturas = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTotalBaseIm = new System.Windows.Forms.TextBox();
            this.txtTotalIGV = new System.Windows.Forms.TextBox();
            this.txtTotalComprobantes = new System.Windows.Forms.TextBox();
            this.lstTipoComprobanteError = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipos de comprobantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doc. cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha comprobante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Base imponible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "IGV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total comprobante";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(531, 101);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 23);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstTipoComprobante
            // 
            this.lstTipoComprobante.FormattingEnabled = true;
            this.lstTipoComprobante.Location = new System.Drawing.Point(30, 187);
            this.lstTipoComprobante.Name = "lstTipoComprobante";
            this.lstTipoComprobante.Size = new System.Drawing.Size(91, 121);
            this.lstTipoComprobante.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tipo Comprobante";
            // 
            // cbTipoComprobantes
            // 
            this.cbTipoComprobantes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoComprobantes.FormattingEnabled = true;
            this.cbTipoComprobantes.Location = new System.Drawing.Point(30, 48);
            this.cbTipoComprobantes.Name = "cbTipoComprobantes";
            this.cbTipoComprobantes.Size = new System.Drawing.Size(121, 21);
            this.cbTipoComprobantes.TabIndex = 10;
            this.cbTipoComprobantes.SelectedIndexChanged += new System.EventHandler(this.cbTipoComprobantes_SelectedIndexChanged_1);
            // 
            // txtDocumento
            // 
            this.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDocumento.Location = new System.Drawing.Point(175, 48);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(288, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(223, 20);
            this.txtNombre.TabIndex = 12;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(30, 102);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(121, 20);
            this.dtpFecha.TabIndex = 13;
            // 
            // txtBaseIm
            // 
            this.txtBaseIm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBaseIm.Location = new System.Drawing.Point(175, 102);
            this.txtBaseIm.Name = "txtBaseIm";
            this.txtBaseIm.Size = new System.Drawing.Size(100, 20);
            this.txtBaseIm.TabIndex = 14;
            // 
            // txtIGV
            // 
            this.txtIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIGV.Location = new System.Drawing.Point(285, 102);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(100, 20);
            this.txtIGV.TabIndex = 15;
            // 
            // txtTotalComprobante
            // 
            this.txtTotalComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalComprobante.Location = new System.Drawing.Point(397, 102);
            this.txtTotalComprobante.Name = "txtTotalComprobante";
            this.txtTotalComprobante.Size = new System.Drawing.Size(100, 20);
            this.txtTotalComprobante.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Doc. cliente";
            // 
            // lstDocumento
            // 
            this.lstDocumento.FormattingEnabled = true;
            this.lstDocumento.Location = new System.Drawing.Point(127, 187);
            this.lstDocumento.Name = "lstDocumento";
            this.lstDocumento.Size = new System.Drawing.Size(91, 121);
            this.lstDocumento.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nombre cliente";
            // 
            // lstNombre
            // 
            this.lstNombre.FormattingEnabled = true;
            this.lstNombre.Location = new System.Drawing.Point(224, 187);
            this.lstNombre.Name = "lstNombre";
            this.lstNombre.Size = new System.Drawing.Size(188, 121);
            this.lstNombre.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(415, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Fecha comprobante";
            // 
            // lstFechaComprobante
            // 
            this.lstFechaComprobante.FormattingEnabled = true;
            this.lstFechaComprobante.Location = new System.Drawing.Point(418, 187);
            this.lstFechaComprobante.Name = "lstFechaComprobante";
            this.lstFechaComprobante.Size = new System.Drawing.Size(93, 121);
            this.lstFechaComprobante.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(514, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Base imponible";
            // 
            // lstBaseIm
            // 
            this.lstBaseIm.FormattingEnabled = true;
            this.lstBaseIm.Location = new System.Drawing.Point(517, 187);
            this.lstBaseIm.Name = "lstBaseIm";
            this.lstBaseIm.Size = new System.Drawing.Size(91, 121);
            this.lstBaseIm.TabIndex = 24;
            // 
            // lstIGV
            // 
            this.lstIGV.FormattingEnabled = true;
            this.lstIGV.Location = new System.Drawing.Point(614, 187);
            this.lstIGV.Name = "lstIGV";
            this.lstIGV.Size = new System.Drawing.Size(91, 121);
            this.lstIGV.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(611, 171);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "IGV";
            // 
            // lstTotalComprobante
            // 
            this.lstTotalComprobante.FormattingEnabled = true;
            this.lstTotalComprobante.Location = new System.Drawing.Point(711, 187);
            this.lstTotalComprobante.Name = "lstTotalComprobante";
            this.lstTotalComprobante.Size = new System.Drawing.Size(91, 121);
            this.lstTotalComprobante.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(708, 171);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Total comprobante";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 346);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Número de boletas:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 384);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Número de facturas:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 429);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Números de comprobantes:";
            // 
            // txtNumerosBoletas
            // 
            this.txtNumerosBoletas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumerosBoletas.Location = new System.Drawing.Point(170, 339);
            this.txtNumerosBoletas.Name = "txtNumerosBoletas";
            this.txtNumerosBoletas.Size = new System.Drawing.Size(100, 20);
            this.txtNumerosBoletas.TabIndex = 32;
            // 
            // txtNumerosFacturas
            // 
            this.txtNumerosFacturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumerosFacturas.Location = new System.Drawing.Point(170, 377);
            this.txtNumerosFacturas.Name = "txtNumerosFacturas";
            this.txtNumerosFacturas.Size = new System.Drawing.Size(100, 20);
            this.txtNumerosFacturas.TabIndex = 33;
            // 
            // txtNumerosComprobantes
            // 
            this.txtNumerosComprobantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumerosComprobantes.Location = new System.Drawing.Point(170, 422);
            this.txtNumerosComprobantes.Name = "txtNumerosComprobantes";
            this.txtNumerosComprobantes.Size = new System.Drawing.Size(100, 20);
            this.txtNumerosComprobantes.TabIndex = 34;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(326, 346);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Total de boletas:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(326, 384);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Total de facturas:";
            // 
            // txtTotalBoletas
            // 
            this.txtTotalBoletas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBoletas.Location = new System.Drawing.Point(422, 339);
            this.txtTotalBoletas.Name = "txtTotalBoletas";
            this.txtTotalBoletas.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBoletas.TabIndex = 37;
            // 
            // txtTotalFacturas
            // 
            this.txtTotalFacturas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalFacturas.Location = new System.Drawing.Point(422, 377);
            this.txtTotalFacturas.Name = "txtTotalFacturas";
            this.txtTotalFacturas.Size = new System.Drawing.Size(100, 20);
            this.txtTotalFacturas.TabIndex = 38;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(581, 346);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "Total base imponible:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(581, 384);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(55, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "Total IGV:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(581, 422);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(104, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "Total comprobantes:";
            // 
            // txtTotalBaseIm
            // 
            this.txtTotalBaseIm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBaseIm.Location = new System.Drawing.Point(691, 339);
            this.txtTotalBaseIm.Name = "txtTotalBaseIm";
            this.txtTotalBaseIm.Size = new System.Drawing.Size(100, 20);
            this.txtTotalBaseIm.TabIndex = 42;
            // 
            // txtTotalIGV
            // 
            this.txtTotalIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalIGV.Location = new System.Drawing.Point(691, 377);
            this.txtTotalIGV.Name = "txtTotalIGV";
            this.txtTotalIGV.Size = new System.Drawing.Size(100, 20);
            this.txtTotalIGV.TabIndex = 43;
            // 
            // txtTotalComprobantes
            // 
            this.txtTotalComprobantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalComprobantes.Location = new System.Drawing.Point(691, 415);
            this.txtTotalComprobantes.Name = "txtTotalComprobantes";
            this.txtTotalComprobantes.Size = new System.Drawing.Size(100, 20);
            this.txtTotalComprobantes.TabIndex = 44;
            // 
            // lstTipoComprobanteError
            // 
            this.lstTipoComprobanteError.FormattingEnabled = true;
            this.lstTipoComprobanteError.Location = new System.Drawing.Point(30, 187);
            this.lstTipoComprobanteError.Name = "lstTipoComprobanteError";
            this.lstTipoComprobanteError.Size = new System.Drawing.Size(91, 121);
            this.lstTipoComprobanteError.TabIndex = 46;
            // 
            // frmEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 481);
            this.Controls.Add(this.lstTipoComprobanteError);
            this.Controls.Add(this.txtTotalComprobantes);
            this.Controls.Add(this.txtTotalIGV);
            this.Controls.Add(this.txtTotalBaseIm);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtTotalFacturas);
            this.Controls.Add(this.txtTotalBoletas);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtNumerosComprobantes);
            this.Controls.Add(this.txtNumerosFacturas);
            this.Controls.Add(this.txtNumerosBoletas);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lstTotalComprobante);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lstIGV);
            this.Controls.Add(this.lstBaseIm);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lstFechaComprobante);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lstNombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lstDocumento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalComprobante);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.txtBaseIm);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.cbTipoComprobantes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lstTipoComprobante);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobantes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstTipoComprobante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipoComprobantes;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtBaseIm;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.TextBox txtTotalComprobante;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lstDocumento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lstFechaComprobante;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstBaseIm;
        private System.Windows.Forms.ListBox lstIGV;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lstTotalComprobante;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtNumerosBoletas;
        private System.Windows.Forms.TextBox txtNumerosFacturas;
        private System.Windows.Forms.TextBox txtNumerosComprobantes;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTotalBoletas;
        private System.Windows.Forms.TextBox txtTotalFacturas;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtTotalBaseIm;
        private System.Windows.Forms.TextBox txtTotalIGV;
        private System.Windows.Forms.TextBox txtTotalComprobantes;
        private System.Windows.Forms.ListBox lstTipoComprobanteError;
    }
}

