namespace Proyecto_OlvaCurier_2._0
{
    partial class frmQR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQR));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pbQRtunki = new System.Windows.Forms.PictureBox();
            this.pbQRplin = new System.Windows.Forms.PictureBox();
            this.pbQRyape = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRtunki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRplin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRyape)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(56, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 19);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yape";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(179, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 19);
            this.radioButton2.TabIndex = 40;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Plin";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(298, 44);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 19);
            this.radioButton3.TabIndex = 41;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Tunki";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(286, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbQRtunki
            // 
            this.pbQRtunki.Image = global::Proyecto_OlvaCurier_2._0.Properties.Resources.qr_tunki;
            this.pbQRtunki.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbQRtunki.InitialImage")));
            this.pbQRtunki.Location = new System.Drawing.Point(56, 81);
            this.pbQRtunki.Name = "pbQRtunki";
            this.pbQRtunki.Size = new System.Drawing.Size(302, 406);
            this.pbQRtunki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQRtunki.TabIndex = 44;
            this.pbQRtunki.TabStop = false;
            // 
            // pbQRplin
            // 
            this.pbQRplin.Image = global::Proyecto_OlvaCurier_2._0.Properties.Resources.qr_plin;
            this.pbQRplin.Location = new System.Drawing.Point(56, 81);
            this.pbQRplin.Name = "pbQRplin";
            this.pbQRplin.Size = new System.Drawing.Size(302, 406);
            this.pbQRplin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQRplin.TabIndex = 43;
            this.pbQRplin.TabStop = false;
            // 
            // pbQRyape
            // 
            this.pbQRyape.Image = global::Proyecto_OlvaCurier_2._0.Properties.Resources.qr_yape;
            this.pbQRyape.Location = new System.Drawing.Point(56, 81);
            this.pbQRyape.Name = "pbQRyape";
            this.pbQRyape.Size = new System.Drawing.Size(302, 406);
            this.pbQRyape.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQRyape.TabIndex = 42;
            this.pbQRyape.TabStop = false;
            // 
            // frmQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbQRtunki);
            this.Controls.Add(this.pbQRplin);
            this.Controls.Add(this.pbQRyape);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olva Curier";
            this.Load += new System.EventHandler(this.frmQR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbQRtunki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRplin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRyape)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.PictureBox pbQRyape;
        private System.Windows.Forms.PictureBox pbQRplin;
        private System.Windows.Forms.PictureBox pbQRtunki;
        private System.Windows.Forms.Label label1;
    }
}