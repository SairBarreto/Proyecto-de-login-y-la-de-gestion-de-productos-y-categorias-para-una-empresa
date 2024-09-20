using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS_TP3
{
    internal class Socio
    {
        public int Id_Socio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public int Id_Pais { get; set; }
        public int Id_Provincia { get; set; }
        private int Activo { get; set; }

        public Socio(int id_Socio, string nombre, string apellido, string email, int id_Pais, int id_Provincia, int activo)
        {
            this.Id_Socio = id_Socio;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
            this.Id_Pais = id_Pais;
            this.Id_Provincia = id_Provincia;
            this.Activo = activo;
        }

        public Socio(object[] datos) : this(Convert.ToInt32(datos[0]), Convert.ToString(datos[1]), Convert.ToString(datos[2]), Convert.ToString(datos[3]), Convert.ToInt32(datos[4]), Convert.ToInt32(datos[5]), Convert.ToInt16(datos[6])) { }

        public bool socioActivo() => this.Activo == 1;
    }
}
