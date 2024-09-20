using AccesoDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CategoriaModelo
    {
        CategoriasLogin categorias = new CategoriasLogin();

        public void cargarCategorias(List<Categorias> lista) => categorias.cargarCategorias(lista);
        public void agregarCategoria(string nombre) => categorias.agregarCategoria(nombre);
        public void borrarCategoria(int Id_Categoria) => categorias.borrarCategoria(Id_Categoria);
        public void actualizarCategoria(Categorias categoriaActualizada) => categorias.actualizarCategoria(categoriaActualizada);
    }
}
