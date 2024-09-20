using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos
{
    public class CategoriasLogin : ConexionSQL
    {
        public void cargarCategorias(List<Categorias> lista)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Select * from Categorias";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Object[] datos = new object[reader.FieldCount];
                        reader.GetValues(datos);
                        lista.Add(new Categorias(datos));
                    }
                }
            }
        }

        public void agregarCategoria(string nombre)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Insert into Categorias (NombreCategoria) values ('{nombre}')";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void borrarCategoria(int Id_Categoria)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Delete from Categorias where Id_Categoria={Id_Categoria}";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizarCategoria(Categorias categoriaActualizada)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Update Categorias set NombreCategoria='{categoriaActualizada.Nombre}' " +
                                      $"where Id_Categoria={categoriaActualizada.Id_Categoria}";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
