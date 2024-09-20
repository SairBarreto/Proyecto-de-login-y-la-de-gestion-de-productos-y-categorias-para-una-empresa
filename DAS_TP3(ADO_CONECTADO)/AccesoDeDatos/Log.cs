using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos
{
    public class Log : ConexionSQL
    {
        public int Id_Log { get; set; }
        public DateTime Fecha { get; set; }
        public string Operacion { get; set; }
        public string Usuario { get; set; }

        public Log() { }
        public Log(int id_Log, DateTime fecha, string operacion, string usuario)
        {
            this.Id_Log = id_Log;
            this.Fecha = fecha;
            this.Operacion = operacion;
            this.Usuario = usuario;
        }
        public Log(Object[] datos) : this(Convert.ToInt32(datos[0]), Convert.ToDateTime(datos[1]), Convert.ToString(datos[2]), Convert.ToString(datos[3])) { }
        public void registrarOperacion(string Operacion, string usuario)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Insert into Log (Fecha, Operacion, Usuario) " +
                                      $"values ('{DateTime.Now}', '{Operacion}', '{usuario}')";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void cargarListaLog(List<Log> lista)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Select * from Log";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Object[] datos = new object[reader.FieldCount];
                        reader.GetValues(datos);
                        lista.Add(new Log(datos));
                    }
                }
            }
        }
    }
}
