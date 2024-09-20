using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentacionJuego
{
    public class BandoLogin
    {
        private SQLConexion conexion { get; set; }
        public int Id_Bando { get; set; }
        public string Nombre { get; set; }

        public BandoLogin()
        {
            this.conexion = new SQLConexion();
        }

        public BandoLogin(int id_Bando, string nombre)
        {
            this.conexion = new SQLConexion();
            this.Id_Bando = id_Bando;
            this.Nombre = nombre;
        }
        public BandoLogin(Object[] datos) : this(Convert.ToInt32(datos[0]), Convert.ToString(datos[1])) { }

        public void cargarListaBandos(List<BandoLogin> lista)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Select * from Bando";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Object[] datos = new object[reader.FieldCount];
                        reader.GetValues(datos);
                        lista.Add(new BandoLogin(datos));
                    }
                }
            }
        }

        public void agregarBando(string nombre)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Insert into Bando (Nombre) values ('{nombre}')";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void borrarBando(int id_Bando)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Delete from Bando where Id_Bando={id_Bando}";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizarBando(BandoLogin bando)
        {
            using (var cx = conexion.getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Update Bando set Nombre='{bando.Nombre}' where Id_Bando={bando.Id_Bando}";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
