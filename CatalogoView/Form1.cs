using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatalogoNegocio;
using CatalogoDominio;


namespace CatalogoView
{
    public partial class frmInicio : Form
    {
        private List<Articulo> lista;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();

        }
        private void cargarDatos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                lista = negocio.listar();
                dgvArticulos.DataSource = lista;
                dgvArticulos.Columns[0].Visible = false;
                dgvArticulos.Columns[1].Visible = false;
                dgvArticulos.Columns[2].MinimumWidth = 130;
                dgvArticulos.Columns[3].Visible = false;
                dgvArticulos.Columns[4].MinimumWidth = 100;
                dgvArticulos.Columns[5].MinimumWidth = 100;
                dgvArticulos.Columns[6].Visible = false;
                dgvArticulos.Columns[7].Visible = false;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?","Salir",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar alta = new frmAgregar();
            alta.ShowDialog();
            cargarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo modificar;
            modificar = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregar frmModificar = new frmAgregar(modificar);
            frmModificar.ShowDialog();
            cargarDatos();
        }

        private void dgvArticulos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmVerDetalle VD = new frmVerDetalle();
                Articulo articulo = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                VD.txtCodigoD.Text = articulo.Codigo.ToString();
                VD.txtNombreD.Text = articulo.Nombre.ToString();
                VD.txtDescripcionD.Text = articulo.Descripcion.ToString();
                VD.txtMarcaD.Text = articulo.Marca.ToString();
                VD.txtCategoriaD.Text = articulo.Categoria.ToString();
                VD.txtPrecioD.Text = articulo.Precio.ToString("F2");

                if(articulo.Imagen !="Opcional")
                {
                VD.picArticulo.Load(articulo.Imagen);
                }
                VD.ShowDialog();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            
            
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                int id = ((Articulo)dgvArticulos.CurrentRow.DataBoundItem).ID;
                if (MessageBox.Show("¿Seguro que desea eliminar el articulo seleccionado?", "Eliminar articulo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    negocio.eliminar(id);
                    cargarDatos();
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtFiltrarNombre_TextChanged(object sender, EventArgs e)
        { 
            List<Articulo> listafiltrada = new List<Articulo>();
            try
            {
                if (txtFiltrarNombre.Text == "")
                {
                    listafiltrada = lista;
                    
                    
                }
                else
                {
                    listafiltrada = lista.FindAll(k => k.Nombre.ToLower().Contains(txtFiltrarNombre.Text.ToLower()));
                    
                }
                dgvArticulos.DataSource = listafiltrada;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtFiltrarMarca_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada = new List<Articulo>();
            try
            {
                if (txtFiltrarMarca.Text == "")
                {
                    listafiltrada = lista;


                }
                else
                {
                    listafiltrada = lista.FindAll(k => k.Marca.Nombre.ToLower().Contains(txtFiltrarMarca.Text.ToLower()));

                }
                dgvArticulos.DataSource = listafiltrada;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txtFiltarCategoria_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada = new List<Articulo>();
            try
            {
                if (txtFiltarCategoria.Text == "")
                {
                    listafiltrada = lista;


                }
                else
                {
                    listafiltrada = lista.FindAll(k => k.Categoria.Nombre.ToLower().Contains(txtFiltarCategoria.Text.ToLower()));

                }
                dgvArticulos.DataSource = listafiltrada;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

      
    }
}
