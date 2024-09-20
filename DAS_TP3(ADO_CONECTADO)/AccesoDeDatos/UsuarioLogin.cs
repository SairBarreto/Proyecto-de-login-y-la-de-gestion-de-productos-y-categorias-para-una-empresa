using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos
{
    public class UsuarioLogin : ConexionSQL
    {
        public bool Login(string nombreLogin, string contrasenia, Usuario usuarioDatos)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Select * from Usuarios where NombreLogin='{nombreLogin}' and Password={contrasenia}";

                    //Verifica si el reader devolvio la fila si el nombreLogin y possword son correctas
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            usuarioDatos.Id_Usuario = reader.GetInt32(0);
                            usuarioDatos.Email = reader.GetString(3);
                            usuarioDatos.Nombre = reader.GetString(4);
                            usuarioDatos.Apellido = reader.GetString(5);
                            usuarioDatos.TipoDeUsuario = reader.GetString(6);
                        }
                        reader.Close();
                        cmd.CommandText = $"Update Usuarios set IntentosDeLogin=0 where NombreLogin='{nombreLogin}'";
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    else return false;
                }
            }
        }

        public void bloqueaUsuario(string nombreLogin)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Select * from Usuarios where NombreLogin='{nombreLogin}'";
                    SqlDataReader reader = cmd.ExecuteReader();
                    int Id_Usuario = 0;
                    int intentosDeLogin = 0;

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Id_Usuario = reader.GetInt32(0);
                            reader.Close();

                            cmd.CommandText = $"Update Usuarios set IntentosDeLogin=IntentosDeLogin+1 where Id_Usuario={Id_Usuario}";
                            cmd.ExecuteNonQuery();
                            
                            cmd.CommandText = $"Select * from Usuarios where Id_Usuario={Id_Usuario}";
                            reader = cmd.ExecuteReader(); //Vuelvo a abrir el reader
                            while(reader.Read()) intentosDeLogin = reader.GetInt32(8);
                        }
                    }

                    if (intentosDeLogin == 3 && Id_Usuario != 0)
                    {
                        reader.Close();
                        cmd.CommandText = $"Update Usuarios set Activo=0 where Id_Usuario={Id_Usuario}";
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public bool intentosLLegoAlMaximo(string nombreLogin)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Select * from Usuarios where NombreLogin='{nombreLogin}'";
                    SqlDataReader reader = cmd.ExecuteReader();
                    int intentosDeLogin = 0;

                    if (reader.HasRows)
                    {
                        while (reader.Read()) intentosDeLogin = reader.GetInt32(8);
                    }

                    if (intentosDeLogin == 3) return true;
                    else return false;
                }
            }
        }

        public void cargarUsuariosBloqueados(List<Usuario> listaUsuariosBloqueados)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Select * from Usuarios where Activo=0";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Object[] datos = new object[reader.FieldCount];
                        reader.GetValues(datos);
                        listaUsuariosBloqueados.Add(new Usuario(datos));
                    }
                }
            }
        }

        public void desbloquearUsuario(int Id_Usuario)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Update Usuarios set Activo=1, IntentosDeLogin=0 where Id_Usuario={Id_Usuario}";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void altaUsuario(Usuario nuevoUsuario, string password)
        {
            string nombreLogin = nuevoUsuario.Nombre + nuevoUsuario.Apellido;
            string nombre = nuevoUsuario.Nombre;
            string apellido = nuevoUsuario.Apellido;
            string tipo = nuevoUsuario.TipoDeUsuario;
            string email = nuevoUsuario.Email;

            using (var cx = getConexion())
            {
                cx.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = cx;
                    cmd.CommandText = $"Insert into Usuarios (NombreLogin, Password, Email, Nombre, Apellido, TipoDeUsuario, Activo, IntentosDeLogin) values ('{nombreLogin}', '{password}', '{email}', '{nombre}', '{apellido}', '{tipo}', 1, 0)";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
