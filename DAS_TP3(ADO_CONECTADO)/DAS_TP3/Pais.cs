using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS_TP3
{
    internal class Pais
    {
        public int Id_Pais { get; set; }
        public string Nombre { get; set; }
        public Pais(int id_Pais, string nombre)
        {
            this.Id_Pais = id_Pais;
            this.Nombre = nombre;
        }
        public Pais(object[] datos) : this(Convert.ToInt32(datos[0]), Convert.ToString(datos[1])) { }
    }
}
