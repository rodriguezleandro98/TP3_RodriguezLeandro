using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CatalogoView;
using CatalogoNegocio;
using CatalogoDominio;

namespace CatalogoView
{
    public partial class frmAgregar : Form
    {
        private Articulo articulo = null;
        public frmAgregar()
        {
            InitializeComponent();
        }
        public frmAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que deseas salir?","Salir",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            MarcaNegocio MarcaNegocio = new MarcaNegocio();
            CategoriaNegocio CategoriaNegocio = new CategoriaNegocio();

            
            try
            {
                cboMarca.DataSource = MarcaNegocio.listar();
                cboCategoria.DataSource = CategoriaNegocio.listar();
                cboMarca.ValueMember= "Codigo";
                cboCategoria.ValueMember = "Codigo";
                cboMarca.DisplayMember = "Nombre";
                cboCategoria.DisplayMember = "Nombre";
               
                if (articulo != null)
                {
                    Text = "Modificar articulo";
                    btnAgregar.Text = "Modificar";
                    txtCodigoA.Text = articulo.Codigo;
                    txtNombreA.Text = articulo.Nombre;
                    txtDescripcionA.Text = articulo.Descripcion;
                    txtImagenA.Text = articulo.Imagen;
                    txtPrecioA.Text = articulo.Precio.ToString(string.Format("F2"));
                    cboMarca.SelectedValue = articulo.Marca.Codigo;
                    cboCategoria.SelectedValue = articulo.Categoria.Codigo;
                    
                    
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
               if(articulo==null)
                {
                   articulo = new Articulo();
                }
                articulo.Codigo = txtCodigoA.Text;
                articulo.Nombre = txtNombreA.Text;
                articulo.Descripcion = txtDescripcionA.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Imagen = txtImagenA.Text;
                articulo.Precio = Convert.ToDecimal(txtPrecioA.Text);
                if(articulo.ID != 0)
                {
                    articuloNegocio.modificar(articulo);
                    Dispose();
                }
                else
                {
                     articuloNegocio.agregar(articulo);
                     Dispose();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
