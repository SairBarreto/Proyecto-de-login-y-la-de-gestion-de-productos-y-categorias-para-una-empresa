using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS_TP3
{
    internal class Provincia
    {

        public int Id_Provincia { get; set; }
        public string Nombre { get; set; }
        public Provincia(int id_Provincia, string nombre)
        {
            this.Id_Provincia = id_Provincia;
            this.Nombre = nombre;
        }
        public Provincia(object[] datos) : this(Convert.ToInt32(datos[0]), Convert.ToString(datos[1])) { }
    }
}
