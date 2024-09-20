using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionJuego
{
    public class JugadoresLogin
    {
        private SQLConexion conexion { get; set; }
        public int Id_Jugador { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id_Bando { get; set; }

        public JugadoresLogin()
        {
            this.conexion = new SQLConexion();
        }

        public JugadoresLogin(int id_Jugador, string nombre, string apellido, int id_Bando)
        {
            this.conexion = new SQLConexion();
            this.Id_Jugador = id_Jugador;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Id_Bando = id_Bando;
        }

        public JugadoresLogin(Object[] datos) : this(Convert.ToInt32(datos[0]), Convert.ToString(datos[1]), Convert.ToString(datos[2]), Convert.ToInt32(datos[3])) { }

        public void cargarListaJugadores(List<JugadoresLogin> lista)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Select * from Jugadores";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Object[] datos = new object[reader.FieldCount];
                        reader.GetValues(datos);
                        lista.Add(new JugadoresLogin(datos));
                    }
                }
            }
        }

        public void agregarJugadore(string nombre, string apellido, int id_Bando)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Select * from Bando where Id_Bando={id_Bando}";
                    if (cmd.ExecuteScalar() == null) throw new Exception($"El id {id_Bando} del bando no existe");
                    cmd.CommandText = $"Insert into Jugadores (Nombre, Apellido, Id_Bando) values ('{nombre}', '{apellido}', {id_Bando})";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void borrarJugadores(int id_Juagdor)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Delete from Jugadores where Id_Jugador={id_Juagdor}";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizarJugador(JugadoresLogin jugador)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Select * from Bando where Id_Bando={jugador.Id_Bando}";
                    if (cmd.ExecuteScalar() == null) throw new Exception($"El id {jugador.Id_Bando} del bando no existe");
                    cmd.CommandText = $"Update Jugadores set Nombre='{jugador.Nombre}', Apellido='{jugador.Apellido}', Id_Bando={jugador.Id_Bando} where Id_Jugador={jugador.Id_Jugador}";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
