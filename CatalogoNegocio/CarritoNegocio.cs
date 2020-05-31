using CatalogoDominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoNegocio
{
    public class CarritoNegocio
    {

        public ArtCarrito agregarItem(Articulo articulo)
        {
            ArtCarrito artCarrito = new ArtCarrito();
            artCarrito.ID = articulo.ID;
            artCarrito.Codigo = articulo.Codigo;
            artCarrito.Nombre = articulo.Nombre;
            artCarrito.Descripcion = articulo.Descripcion;
            artCarrito.Marca = articulo.Marca;
            artCarrito.Categoria = articulo.Categoria;
            artCarrito.Precio = articulo.Precio;
            artCarrito.Imagen = articulo.Imagen;

            return artCarrito;
        }
        public decimal SumarImporte(List<ArtCarrito> listaCarro)
        {
            decimal result = 0;

            foreach (ArtCarrito item in listaCarro)
            {
                result += item.Precio * item.Cantidad;
            }

            return result;
        }
        public List<ArtCarrito> cargarlista(List<ArtCarrito> listaCarrito, ArtCarrito item)
        {
            bool banItem = false;

            foreach (ArtCarrito producto in listaCarrito)
            {
                if (producto.Codigo == item.Codigo)
                {
                    producto.Cantidad += item.Cantidad;
                    banItem = true;
                }
            }

            if (!banItem)
            {
                listaCarrito.Add(item);
            }

            return listaCarrito;
        }
    }
}
