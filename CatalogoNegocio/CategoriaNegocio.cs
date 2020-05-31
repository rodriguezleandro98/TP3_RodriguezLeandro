using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDominio;
using System.Data.SqlClient;

namespace CatalogoNegocio
{
    public class CategoriaNegocio
    {
		public List<Categoria> listar()
		{
			List<Categoria> lista = new List<Categoria>();
			SqlDataReader lector;
			Categoria aux;
			SqlConnection con = new SqlConnection();
			SqlCommand com = new SqlCommand();
			try
			{
				con.ConnectionString = "data source=DESKTOP-EEH48JR\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
				com.CommandType = System.Data.CommandType.Text;
				com.CommandText = "Select Id, Descripcion FROM CATEGORIAS";
				com.Connection = con;
				con.Open();
				lector = com.ExecuteReader();
				while (lector.Read())
				{

					aux = new Categoria((int)lector["Id"], (string)lector["Descripcion"]);
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
				con.Close();
			}
		}
	}
}
