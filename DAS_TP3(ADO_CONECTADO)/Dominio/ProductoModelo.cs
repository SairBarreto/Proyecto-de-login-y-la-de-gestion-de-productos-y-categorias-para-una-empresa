using AccesoDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ProductoModelo
    {
        ProductosLogin productos = new ProductosLogin();
        public void cargarProductos(List<Productos> lista) => productos.cargarProductos(lista);
        public void agregarProducto(Productos productoNuevo) => productos.agregarProducto(productoNuevo);
        public void borrarProducto(int Id_Producto) => productos.borrarProducto(Id_Producto);
        public void actualizarProducto(Productos productoActualizado) => productos.actualizarProducto(productoActualizado);
    }
}
