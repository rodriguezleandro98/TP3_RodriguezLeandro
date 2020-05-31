using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDominio;
using System.Data.SqlClient;
using CatalogoNegocio;


namespace CatalogoNegocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            
			List<Articulo> lista = new List<Articulo>();
            Articulo aux;
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexion.ConnectionString = "data source=DESKTOP-EEH48JR\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Codigo, A.ImagenUrl, A.Precio, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.Nombre, A.IdMarca, A.IdCategoria, A.Id " +
                    "FROM ARTICULOS as A INNER JOIN MARCAS AS M ON M.Id = A.IdMarca INNER JOIN CATEGORIAS AS C ON C.Id = A.IdCategoria";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read())
                { 

                    aux = new Articulo();
                    aux.Marca = new Marca();
                    aux.Categoria = new Categoria();
                    aux.Codigo = lector["Codigo"].ToString();
                    aux.Imagen = lector["ImagenUrl"].ToString();
                    aux.Precio = lector.GetDecimal(2);
                    aux.Descripcion = lector["Descripcion"].ToString();
                    aux.Marca.Codigo = lector.GetInt32(7);
                    aux.Categoria.Codigo = lector.GetInt32(8);
                    aux.Marca.Nombre = lector["Marca"].ToString();
                    aux.Categoria.Nombre = lector["Categoria"].ToString();
                    aux.Nombre = lector["Nombre"].ToString();
                    aux.ID = lector.GetInt32(9);
                    
                   
                    
                    lista.Add(aux);

                }
                return lista;

            }
			catch (Exception ex)
			{

				throw ex;
			}
            finally
            {
                conexion.Close();
            }
        }
        public void agregar(Articulo articulo)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            
            try
            {
                conexion.ConnectionString = "data source = DESKTOP-EEH48JR\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "INSERT INTO ARTICULOS VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Codigo", articulo.Codigo);
                comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                comando.Parameters.AddWithValue("@IdMarca", articulo.Marca.Codigo);
                comando.Parameters.AddWithValue("@IdCategoria", articulo.Categoria.Codigo);
                comando.Parameters.AddWithValue("@ImagenUrl", articulo.Imagen);
                comando.Parameters.AddWithValue("@Precio", articulo.Precio);

                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void eliminar(int id)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();
            try
            {
                conexion.ConnectionString = "data source = DESKTOP-EEH48JR\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "DELETE FROM ARTICULOS WHERE Id =" + id;
                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificar(Articulo articulo)
        {
            SqlCommand comando = new SqlCommand();
            SqlConnection conexion = new SqlConnection();

            try
            {
                conexion.ConnectionString = "data source = DESKTOP-EEH48JR\\SQLEXPRESS; initial catalog = CATALOGO_DB; integrated security = sspi";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                comando.CommandText = "UPDATE ARTICULOS SET Codigo=@Codigo, Nombre=@Nombre, Descripcion=@Descripcion, IdMarca=@IdMarca, IdCategoria=@IdCategoria, ImagenUrl=@ImagenUrl, Precio=@Precio WHERE Id = @Id";
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Id", articulo.ID);
                comando.Parameters.AddWithValue("@Codigo", articulo.Codigo);
                comando.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                comando.Parameters.AddWithValue("@IdMarca", articulo.Marca.Codigo);
                comando.Parameters.AddWithValue("@IdCategoria", articulo.Categoria.Codigo);
                comando.Parameters.AddWithValue("@ImagenUrl", articulo.Imagen);
                comando.Parameters.AddWithValue("@Precio", articulo.Precio);

                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        
    }
    
}
