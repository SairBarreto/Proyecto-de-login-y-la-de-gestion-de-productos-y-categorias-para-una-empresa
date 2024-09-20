using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PresentacionJuego
{
    public class JuegoLogin
    {
        private SQLConexion conexion { get; set; }
        public int Id_Juego { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public JuegoLogin()
        {
            conexion = new SQLConexion();
        }
        public JuegoLogin(int id_Juego, string nombre, string descripcion)
        {
            conexion = new SQLConexion();
            this.Id_Juego = id_Juego;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }
        public JuegoLogin(Object[] datos) : this(Convert.ToInt32(datos[0]), Convert.ToString(datos[1]), Convert.ToString(datos[2])) { }

        public void cargarListaJuegos(List<JuegoLogin> lista)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Select * from Juego";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Object[] datos = new object[reader.FieldCount];
                        reader.GetValues(datos);
                        lista.Add(new JuegoLogin(datos));
                    }
                }
            }
        }

        public void agregarJuego(string nombreJuego, string descripcionJuego)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using(var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Insert into Juego (Nombre, Descripcion) values ('{nombreJuego}', '{descripcionJuego}')";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void borrarJuego(int Id_Juego)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Delete from Juego where Id_Juego={Id_Juego}";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizarJuego(JuegoLogin juego)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Update Juego set Nombre='{juego.Nombre}', Descripcion='{juego.Descripcion}' where Id_Juego={juego.Id_Juego}";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
