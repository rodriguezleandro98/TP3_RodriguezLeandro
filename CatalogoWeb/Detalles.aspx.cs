using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CatalogoDominio;
using CatalogoNegocio;

namespace CatalogoWeb
{
    public partial class Detalles : System.Web.UI.Page
    {
        public Articulo articulo { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArticulo;
            try
            {
                listaArticulo = negocio.listar();
                var artseleccionado = Convert.ToInt32(Request.QueryString["idart"]);
                articulo = listaArticulo.Find(J => J.ID == artseleccionado);


            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        protected void btnAñadir_Click(object sender, EventArgs e)
        {
            CarritoNegocio negocio = new CarritoNegocio();
            ArtCarrito item = new ArtCarrito();
            List<ArtCarrito> listaCarrito = new List<ArtCarrito>();
            item = negocio.agregarItem(articulo);
            item.Cantidad = Convert.ToInt32(txtBoxCantidad.Text);


            if(Session["listaCarrito"] != null)
            {
                listaCarrito = (List<ArtCarrito>)Session["listaCarrito"];
                Session["listaCarrito"] = negocio.cargarlista(listaCarrito, item);
                Response.Redirect("Articulos.aspx");
            }
            else
            {
                Session["listaCarrito"] = listaCarrito;
                Session["listaCarrito"] = negocio.cargarlista(listaCarrito, item);
                Response.Redirect("Articulos.aspx");
            }

        }
    }
}