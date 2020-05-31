using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CatalogoNegocio;
using CatalogoDominio;
using System.Web.Services.Description;

namespace CatalogoWeb
{
    public partial class Carrito : System.Web.UI.Page
    {
        public List<ArtCarrito> listaCarrito { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                CarritoNegocio negocio = new CarritoNegocio();
                if (Session[Session.SessionID + "nombreusuario"] != null)
                {
                    
                    lblBienvenida.Text += Session[Session.SessionID + "nombreusuario"].ToString();
                }
                else
                {
                    Response.Redirect("Session.aspx");
                }

                var artQuitar = Request.QueryString["idArt"];
                if (artQuitar != null)
                {
                    listaCarrito = (List<ArtCarrito>)Session["listaCarrito"];
                    ArtCarrito articulodelete = listaCarrito.Find(J => J.ID == int.Parse(artQuitar));
                    listaCarrito.Remove(articulodelete);
                    Session[Session.SessionID + "listaCarrito"] = listaCarrito;
                }
                else if(Session["listaCarrito"] != null)
                {
                    listaCarrito = (List<ArtCarrito>)Session["listaCarrito"];
                }
                else
                {
                    listaCarrito = new List<ArtCarrito>();
                    Session["listaCarrito"] = listaCarrito;
                }

                if (listaCarrito.Count > 0)
                {
                    lblPrecioFinal.Visible = true;
                    lblPrecioFinal.Text = negocio.SumarImporte(listaCarrito).ToString("F2");
                    Session["listaCarro"] = listaCarrito;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}