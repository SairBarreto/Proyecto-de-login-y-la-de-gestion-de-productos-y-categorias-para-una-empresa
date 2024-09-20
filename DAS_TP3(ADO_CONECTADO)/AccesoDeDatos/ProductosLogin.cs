using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos
{
    public class ProductosLogin : ConexionSQL
    {
        public void cargarProductos(List<Productos> lista)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Select * from Productos";

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Object[] datos = new object[reader.FieldCount];
                        reader.GetValues(datos);
                        lista.Add(new Productos(datos));
                    }
                }
            }
        }

        public void agregarProducto(Productos productoNuevo)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Insert into Productos (Nombre_Producto, Precio, Stock, Id_Categoria) " +
                                      $"values ('{productoNuevo.Nombre}', {productoNuevo.Precio}, {productoNuevo.Stock}, {productoNuevo.Id_Categoria})";

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void borrarProducto(int Id_Producto)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using(var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Delete from Productos where Id_Producto={Id_Producto}";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void actualizarProducto(Productos productoActualizado)
        {
            using (var conexion = getConexion())
            {
                conexion.Open();

                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = conexion;
                    cmd.CommandText = $"Update Productos " +
                                      $"set Nombre_Producto='{productoActualizado.Nombre}', Precio={productoActualizado.Precio}, Stock={productoActualizado.Stock}, Id_Categoria={productoActualizado.Id_Categoria} " +
                                      $"where Id_Producto={productoActualizado.Id_Producto}";
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
