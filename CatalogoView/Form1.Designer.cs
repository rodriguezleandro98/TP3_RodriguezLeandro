namespace CatalogoView
{
    partial class frmInicio
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltarCategoria = new System.Windows.Forms.TextBox();
            this.txtFiltrarMarca = new System.Windows.Forms.TextBox();
            this.txtFiltrarNombre = new System.Windows.Forms.TextBox();
            this.lblFiltrarCategoria = new System.Windows.Forms.Label();
            this.lblFiltrarMarca = new System.Windows.Forms.Label();
            this.lblFiltrarNombre = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 12);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(339, 202);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentDoubleClick);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar.Location = new System.Drawing.Point(12, 243);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Location = new System.Drawing.Point(444, 243);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Location = new System.Drawing.Point(125, 243);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiltarCategoria);
            this.groupBox1.Controls.Add(this.txtFiltrarMarca);
            this.groupBox1.Controls.Add(this.txtFiltrarNombre);
            this.groupBox1.Controls.Add(this.lblFiltrarCategoria);
            this.groupBox1.Controls.Add(this.lblFiltrarMarca);
            this.groupBox1.Controls.Add(this.lblFiltrarNombre);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(376, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por:";
            // 
            // txtFiltarCategoria
            // 
            this.txtFiltarCategoria.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltarCategoria.Location = new System.Drawing.Point(72, 76);
            this.txtFiltarCategoria.Name = "txtFiltarCategoria";
            this.txtFiltarCategoria.Size = new System.Drawing.Size(124, 20);
            this.txtFiltarCategoria.TabIndex = 5;
            this.txtFiltarCategoria.TextChanged += new System.EventHandler(this.txtFiltarCategoria_TextChanged);
            // 
            // txtFiltrarMarca
            // 
            this.txtFiltrarMarca.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltrarMarca.Location = new System.Drawing.Point(72, 50);
            this.txtFiltrarMarca.Name = "txtFiltrarMarca";
            this.txtFiltrarMarca.Size = new System.Drawing.Size(124, 20);
            this.txtFiltrarMarca.TabIndex = 4;
            this.txtFiltrarMarca.TextChanged += new System.EventHandler(this.txtFiltrarMarca_TextChanged);
            // 
            // txtFiltrarNombre
            // 
            this.txtFiltrarNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFiltrarNombre.Location = new System.Drawing.Point(72, 24);
            this.txtFiltrarNombre.Name = "txtFiltrarNombre";
            this.txtFiltrarNombre.Size = new System.Drawing.Size(124, 20);
            this.txtFiltrarNombre.TabIndex = 3;
            this.txtFiltrarNombre.TextChanged += new System.EventHandler(this.txtFiltrarNombre_TextChanged);
            // 
            // lblFiltrarCategoria
            // 
            this.lblFiltrarCategoria.AutoSize = true;
            this.lblFiltrarCategoria.Location = new System.Drawing.Point(6, 77);
            this.lblFiltrarCategoria.Name = "lblFiltrarCategoria";
            this.lblFiltrarCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblFiltrarCategoria.TabIndex = 2;
            this.lblFiltrarCategoria.Text = "Categoria:";
            // 
            // lblFiltrarMarca
            // 
            this.lblFiltrarMarca.AutoSize = true;
            this.lblFiltrarMarca.Location = new System.Drawing.Point(6, 52);
            this.lblFiltrarMarca.Name = "lblFiltrarMarca";
            this.lblFiltrarMarca.Size = new System.Drawing.Size(40, 13);
            this.lblFiltrarMarca.TabIndex = 1;
            this.lblFiltrarMarca.Text = "Marca:";
            // 
            // lblFiltrarNombre
            // 
            this.lblFiltrarNombre.AutoSize = true;
            this.lblFiltrarNombre.Location = new System.Drawing.Point(6, 27);
            this.lblFiltrarNombre.Name = "lblFiltrarNombre";
            this.lblFiltrarNombre.Size = new System.Drawing.Size(47, 13);
            this.lblFiltrarNombre.TabIndex = 0;
            this.lblFiltrarNombre.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Location = new System.Drawing.Point(238, 243);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(603, 281);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Form1_Load);
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFiltarCategoria;
        private System.Windows.Forms.TextBox txtFiltrarMarca;
        private System.Windows.Forms.TextBox txtFiltrarNombre;
        private System.Windows.Forms.Label lblFiltrarCategoria;
        private System.Windows.Forms.Label lblFiltrarMarca;
        private System.Windows.Forms.Label lblFiltrarNombre;
        private System.Windows.Forms.Button btnEliminar;
    }
}

