<%@ Page Title="Detalle" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="CatalogoWeb.Detalles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">

    <div class="card" style="width: 25%">
        <img src="<% = articulo.Imagen %>" class="card-img-top" alt="...">
        <div class="card-body">
            <h5 class="card-title"><% = articulo.Nombre %></h5>
            <p class="card-text"><% = articulo.Codigo %></p>
            <p class="card-text"><% = articulo.Descripcion %></p>
            <p class="card-text"><% = articulo.Precio.ToString("F2") %></p>
            <asp:TextBox class="card-text" ID="txtBoxCantidad" Text="1" runat="server" />
            <asp:Button class="btn btn-success btn-sm" style="margin-bottom:5px" Text="Añadir carrito" runat="server" OnClick="btnAñadir_Click" />
        </div>
    </div>
    <a href="Articulos.aspx" id="btnVolver" style="margin-top:10px; margin-left:10px; margin-bottom:10px" class="btn btn-primary">Volver</a>
    
</asp:Content>


