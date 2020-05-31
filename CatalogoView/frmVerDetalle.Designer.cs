namespace CatalogoView
{
    partial class frmVerDetalle
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.picArticulo = new System.Windows.Forms.PictureBox();
            this.lblCodigoD = new System.Windows.Forms.Label();
            this.lblNombreD = new System.Windows.Forms.Label();
            this.lblDescripcionD = new System.Windows.Forms.Label();
            this.lblMarcaD = new System.Windows.Forms.Label();
            this.lblCategoriaD = new System.Windows.Forms.Label();
            this.lblPrecioD = new System.Windows.Forms.Label();
            this.txtCodigoD = new System.Windows.Forms.TextBox();
            this.txtNombreD = new System.Windows.Forms.TextBox();
            this.txtDescripcionD = new System.Windows.Forms.TextBox();
            this.txtMarcaD = new System.Windows.Forms.TextBox();
            this.txtCategoriaD = new System.Windows.Forms.TextBox();
            this.txtPrecioD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(230, 294);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // picArticulo
            // 
            this.picArticulo.Location = new System.Drawing.Point(486, 48);
            this.picArticulo.Name = "picArticulo";
            this.picArticulo.Size = new System.Drawing.Size(193, 209);
            this.picArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArticulo.TabIndex = 2;
            this.picArticulo.TabStop = false;
            // 
            // lblCodigoD
            // 
            this.lblCodigoD.AutoSize = true;
            this.lblCodigoD.Location = new System.Drawing.Point(81, 25);
            this.lblCodigoD.Name = "lblCodigoD";
            this.lblCodigoD.Size = new System.Drawing.Size(61, 13);
            this.lblCodigoD.TabIndex = 3;
            this.lblCodigoD.Text = "COD. ART:";
            // 
            // lblNombreD
            // 
            this.lblNombreD.AutoSize = true;
            this.lblNombreD.Location = new System.Drawing.Point(81, 51);
            this.lblNombreD.Name = "lblNombreD";
            this.lblNombreD.Size = new System.Drawing.Size(57, 13);
            this.lblNombreD.TabIndex = 4;
            this.lblNombreD.Text = "NOMBRE:";
            // 
            // lblDescripcionD
            // 
            this.lblDescripcionD.AutoSize = true;
            this.lblDescripcionD.Location = new System.Drawing.Point(81, 77);
            this.lblDescripcionD.Name = "lblDescripcionD";
            this.lblDescripcionD.Size = new System.Drawing.Size(83, 13);
            this.lblDescripcionD.TabIndex = 5;
            this.lblDescripcionD.Text = "DESCRIPCION:";
            // 
            // lblMarcaD
            // 
            this.lblMarcaD.AutoSize = true;
            this.lblMarcaD.Location = new System.Drawing.Point(81, 177);
            this.lblMarcaD.Name = "lblMarcaD";
            this.lblMarcaD.Size = new System.Drawing.Size(48, 13);
            this.lblMarcaD.TabIndex = 6;
            this.lblMarcaD.Text = "MARCA:";
            // 
            // lblCategoriaD
            // 
            this.lblCategoriaD.AutoSize = true;
            this.lblCategoriaD.Location = new System.Drawing.Point(81, 203);
            this.lblCategoriaD.Name = "lblCategoriaD";
            this.lblCategoriaD.Size = new System.Drawing.Size(72, 13);
            this.lblCategoriaD.TabIndex = 7;
            this.lblCategoriaD.Text = "CATEGORIA:";
            // 
            // lblPrecioD
            // 
            this.lblPrecioD.AutoSize = true;
            this.lblPrecioD.Location = new System.Drawing.Point(81, 229);
            this.lblPrecioD.Name = "lblPrecioD";
            this.lblPrecioD.Size = new System.Drawing.Size(50, 13);
            this.lblPrecioD.TabIndex = 8;
            this.lblPrecioD.Text = "PRECIO:";
            // 
            // txtCodigoD
            // 
            this.txtCodigoD.Location = new System.Drawing.Point(170, 22);
            this.txtCodigoD.Name = "txtCodigoD";
            this.txtCodigoD.ReadOnly = true;
            this.txtCodigoD.Size = new System.Drawing.Size(135, 20);
            this.txtCodigoD.TabIndex = 9;
            // 
            // txtNombreD
            // 
            this.txtNombreD.Location = new System.Drawing.Point(170, 48);
            this.txtNombreD.Name = "txtNombreD";
            this.txtNombreD.ReadOnly = true;
            this.txtNombreD.Size = new System.Drawing.Size(135, 20);
            this.txtNombreD.TabIndex = 10;
            // 
            // txtDescripcionD
            // 
            this.txtDescripcionD.Location = new System.Drawing.Point(170, 74);
            this.txtDescripcionD.Multiline = true;
            this.txtDescripcionD.Name = "txtDescripcionD";
            this.txtDescripcionD.ReadOnly = true;
            this.txtDescripcionD.Size = new System.Drawing.Size(258, 94);
            this.txtDescripcionD.TabIndex = 11;
            // 
            // txtMarcaD
            // 
            this.txtMarcaD.Location = new System.Drawing.Point(170, 174);
            this.txtMarcaD.Name = "txtMarcaD";
            this.txtMarcaD.ReadOnly = true;
            this.txtMarcaD.Size = new System.Drawing.Size(135, 20);
            this.txtMarcaD.TabIndex = 12;
            // 
            // txtCategoriaD
            // 
            this.txtCategoriaD.Location = new System.Drawing.Point(170, 200);
            this.txtCategoriaD.Name = "txtCategoriaD";
            this.txtCategoriaD.ReadOnly = true;
            this.txtCategoriaD.Size = new System.Drawing.Size(135, 20);
            this.txtCategoriaD.TabIndex = 13;
            // 
            // txtPrecioD
            // 
            this.txtPrecioD.Location = new System.Drawing.Point(170, 226);
            this.txtPrecioD.Name = "txtPrecioD";
            this.txtPrecioD.ReadOnly = true;
            this.txtPrecioD.Size = new System.Drawing.Size(135, 20);
            this.txtPrecioD.TabIndex = 14;
            // 
            // frmVerDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(708, 336);
            this.Controls.Add(this.txtPrecioD);
            this.Controls.Add(this.txtCategoriaD);
            this.Controls.Add(this.txtMarcaD);
            this.Controls.Add(this.txtDescripcionD);
            this.Controls.Add(this.txtNombreD);
            this.Controls.Add(this.txtCodigoD);
            this.Controls.Add(this.lblPrecioD);
            this.Controls.Add(this.lblCategoriaD);
            this.Controls.Add(this.lblMarcaD);
            this.Controls.Add(this.lblDescripcionD);
            this.Controls.Add(this.lblNombreD);
            this.Controls.Add(this.lblCodigoD);
            this.Controls.Add(this.picArticulo);
            this.Controls.Add(this.btnVolver);
            this.Name = "frmVerDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle articulo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVerDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblDescripcionD;
        private System.Windows.Forms.Label lblMarcaD;
        private System.Windows.Forms.Label lblCategoriaD;
        private System.Windows.Forms.Label lblPrecioD;
        public System.Windows.Forms.Label lblNombreD;
        public System.Windows.Forms.Label lblCodigoD;
        public System.Windows.Forms.PictureBox picArticulo;
        public System.Windows.Forms.TextBox txtCodigoD;
        public System.Windows.Forms.TextBox txtNombreD;
        public System.Windows.Forms.TextBox txtDescripcionD;
        public System.Windows.Forms.TextBox txtMarcaD;
        public System.Windows.Forms.TextBox txtCategoriaD;
        public System.Windows.Forms.TextBox txtPrecioD;
    }
}