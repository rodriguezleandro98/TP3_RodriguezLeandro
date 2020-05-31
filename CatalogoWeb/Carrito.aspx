<%@ Page Title="Carrito" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="CatalogoWeb.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body" runat="server">
    <asp:Label Style="margin-top: 15px; margin-left: 15px"  CssClass="display-3" ID="lblBienvenida" Text="Hola " runat="server" />
    <h2 style="margin-bottom:15px; margin-top:15px; margin-left:15px;">Bienvenidos a su carrito de compras</h2>
    <div class="container container-fluid">
        <div class="row">
            <div class="col">
                <table class="table table-dark">
                    <thead>
                        <tr>
                            <th scope="col">Codigo</th>
                            <th scope="col">Nombre</th>
                            <th scope="col">Descripcion</th>
                            <th scope="col">Categoria</th>
                            <th scope="col">Cantidad</th>
                            <th scope="col">Eliminar</th>
                        </tr>
                    </thead>
                    <tbody>
                        <%foreach (var item in listaCarrito)
                            {%>
                        <tr>
                            <th scope="row"><% = item.Codigo %></th>
                            <td><% = item.Nombre %></td>
                            <td><% = item.Descripcion %></td>
                            <td><% = item.Categoria.Nombre %></td>
                            <td><% = item.Cantidad %></td>
                            <td>
                                <a href="Carrito.aspx?idArt=<% = item.ID.ToString() %>">
                                    <svg class="bi bi-trash text-danger" width="2em" height="2em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                                        <path d="M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z" />
                                        <path fill-rule="evenodd" d="M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4L4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z" />
                                    </svg>
                                </a>
                            </td>
                        </tr>
                        <%} %>
                    </tbody>
                </table>
                <div class="row">
                    <div class="form-group">
                        <asp:Label Style="margin-left: 25px" Text="Precio Final: $" ID="lblTextPrecio" runat="server" />
                        <asp:Label Text="0,00" ID="lblPrecioFinal" runat="server" />
                    </div>
                </div>
                <div class="row">
                    <a href="Articulos.aspx" id="btnVolver" style="margin-top: 10px; margin-left: 20px; margin-bottom: 10px" class="btn btn-primary">Volver</a>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
