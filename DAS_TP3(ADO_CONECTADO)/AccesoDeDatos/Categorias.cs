using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos
{
    public class Categorias
    {
        public int Id_Categoria { get; set; }
        public string Nombre { get; set; }

        public Categorias() { }
        public Categorias(int id_Categorias, string nombre)
        {
            this.Id_Categoria = id_Categorias;
            this.Nombre = nombre;
        }
        public Categorias(object[] datos) : this(Convert.ToInt32(datos[0]), Convert.ToString(datos[1])) { }
    }
}
