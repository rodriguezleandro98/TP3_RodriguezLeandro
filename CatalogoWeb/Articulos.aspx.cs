﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CatalogoNegocio;
using CatalogoDominio;

namespace CatalogoWeb
{
    public partial class Articulos : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                ListaArticulos = negocio.listar();
                if (!IsPostBack)
                {
                    if (Session[Session.SessionID + "nombreusuario"] != null)
                    {
                        lblBienvenida.Visible = true;
                        lblBienvenida.Text += Session[Session.SessionID + "nombreusuario"].ToString();
                    }

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        protected void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                if (IsPostBack)
                {
                    if (txtBuscar.Text != "")
                    {

                        ListaArticulos = ListaArticulos.FindAll(k => k.Nombre.ToLower().Contains(txtBuscar.Text.ToLower()));
                    }
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}