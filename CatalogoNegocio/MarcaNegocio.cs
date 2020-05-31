using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDominio;
using System.Data.SqlClient;

namespace CatalogoNegocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar()
        {
			List<Marca> lista = new List<Marca>();
			SqlDataReader lector;
			Marca aux;
			SqlConnection con = new SqlConnection();
			SqlCommand com = new SqlCommand();
			try
			{
				con.ConnectionString= "data source=DESKTOP-EEH48JR\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=sspi";
				com.CommandType = System.Data.CommandType.Text;
				com.CommandText = "Select Id, Descripcion FROM MARCAS";
				com.Connection = con;
				con.Open();
				lector = com.ExecuteReader();
				while(lector.Read())
				{

					aux = new Marca((int)lector["Id"],(string)lector["Descripcion"]);
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
