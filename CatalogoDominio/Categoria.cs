using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalogoDominio
{
    public class Categoria
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
        public Categoria() { }
        public Categoria(int codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }
    }
}
