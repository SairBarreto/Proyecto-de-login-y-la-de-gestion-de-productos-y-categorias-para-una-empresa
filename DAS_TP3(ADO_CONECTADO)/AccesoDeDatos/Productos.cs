using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos
{
    public class Productos
    {
        public int Id_Producto { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public int Id_Categoria { get; set; }

        public Productos() { }
        public Productos(int id_Producto, string nombre, decimal precio, int stock, int id_Categoria)
        {
            this.Id_Producto = id_Producto;
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
            this.Id_Categoria = id_Categoria;
        }

        public Productos(object[] datos) : this(Convert.ToInt32(datos[0]), Convert.ToString(datos[1]), Convert.ToDecimal(datos[2]), Convert.ToInt32(datos[3]), Convert.ToInt32(datos[4])) { }
    }
}
