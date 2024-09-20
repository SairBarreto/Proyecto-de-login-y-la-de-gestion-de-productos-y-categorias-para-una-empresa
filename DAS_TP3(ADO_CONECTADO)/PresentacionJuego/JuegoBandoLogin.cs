using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionJuego
{
    public class JuegoBandoLogin
    {
        private SQLConexion conexion { get; set; }
        public int Id_Juego { get; set; }
        public int Id_Jugador { get; set; }

        public JuegoBandoLogin()
        {
            this.conexion = new SQLConexion();
        }

        public JuegoBandoLogin(int id_Juego, int id_Jugador)
        {
            this.conexion = new SQLConexion();
            this.Id_Juego = id_Juego;
            this.Id_Jugador = id_Jugador;
        }
        public JuegoBandoLogin(Object[] datos) : this(Convert.ToInt32(datos[0]), Convert.ToInt32(datos[1])) { }

        public void cargarListaJugoBando(List<JuegoBandoLogin> lista)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Select * from Juego_Bando";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Object[] datos = new object[reader.FieldCount];
                        reader.GetValues(datos);
                        lista.Add(new JuegoBandoLogin(datos));
                    }
                }
            }
        }
        public bool verificaQueIdJuegoExista(int id_juego)
        {
            bool existe = false;
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Select * from Juego where Id_Juego={id_juego}";
                    if (cmd.ExecuteScalar() != null) { existe = true; }
                }
            }
            return existe;
        }
        public bool verificaQueIdJugadorExista(int id_jugador)
        {
            bool existe = false;
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Select * from Jugadores where Id_Jugador={id_jugador}";
                    if (cmd.ExecuteScalar() != null) { existe = true; }
                }
            }
            return existe;
        }
        public void agregarJuegoBando(int id_Juego, int id_Jugador)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Insert into Juego_Bando (Id_Juego, Id_Jugador) values ({id_Juego},{id_Jugador})";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void borrarJurgoBando(int id_Juego, int id_Jugador)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Delete from Juego_Bando where Id_Juego={id_Juego} and Id_Jugador={id_Jugador}";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizar(int id_Juego, int id_Jugador, int id_JuegoNuevo, int id_JugadorNuevo)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Update Juego_Bando set Id_Juego={id_JuegoNuevo}, Id_Jugador={id_JugadorNuevo} where Id_Juego={id_Juego} and Id_Jugador={id_Jugador}";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
