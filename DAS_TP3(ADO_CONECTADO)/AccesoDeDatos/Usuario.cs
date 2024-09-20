using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos
{
    public class Usuario
    {
        public int Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string TipoDeUsuario { get; set; }

        public Usuario() { }
        public Usuario(int id_Usuario, string email, string nombre, string apellido, string tipoDeUsuario)
        {
            this.Id_Usuario = id_Usuario;
            this.Email = email;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoDeUsuario = tipoDeUsuario;
        }
        public Usuario(string email, string nombre, string apellido, string tipoDeUsuario)
        {
            this.Email = email;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.TipoDeUsuario = tipoDeUsuario;
        }
        public Usuario(object[] datos) : this(Convert.ToInt32(datos[0]), Convert.ToString(datos[3]), Convert.ToString(datos[4]), Convert.ToString(datos[5]), Convert.ToString(datos[6])) { }
    }
}
