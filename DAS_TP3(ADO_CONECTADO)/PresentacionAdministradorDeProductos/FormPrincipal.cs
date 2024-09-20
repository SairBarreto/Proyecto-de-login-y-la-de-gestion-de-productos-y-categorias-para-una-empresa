using AccesoDeDatos;
using Dominio;
using Microsoft.VisualBasic;

namespace PresentacionAdministradorDeProductos
{
    public partial class FormPrincipal : Form
    {
        Usuario usuarioDatos;
        List<Productos> listaProductos;
        List<Categorias> listaCategorias;
        ProductoModelo productoModel;
        CategoriaModelo categoriaModel;
        Log registro;
        string nombreLogin;
        public FormPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void cargarDatosUsuario(Usuario datosCargar)
        {
            usuarioDatos = new Usuario(datosCargar.Id_Usuario, datosCargar.Email, datosCargar.Nombre, datosCargar.Apellido, datosCargar.TipoDeUsuario);
            nombreLogin = usuarioDatos.Nombre + usuarioDatos.Apellido;
            if (datosCargar.TipoDeUsuario != "Admin")
            {
                btnVerOperaciones.Visible = false;
                btnUsuariosBloqueados.Visible = false;
            }
        }

        private void cargarDatosUsuario()
        {
            lbNombreUsuario.Text = usuarioDatos.Nombre + " " + usuarioDatos.Apellido;
            lbEmailUsuario.Text = "Email: " + usuarioDatos.Email;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            cargarDatosUsuario();
            registro = new Log();
            productoModel = new ProductoModelo();
            categoriaModel = new CategoriaModelo();
            listaProductos = new List<Productos>();
            listaCategorias = new List<Categorias>();
            cargarListaCategorias();
            cargarListaProductos();
            mostrarEnDGV(dgvProductos, listaProductos.ToList());
            mostrarEnDGV(dgvCategorias, listaCategorias.ToList());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres cerrar la aplicación?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cargarListaProductos()
        {
            listaProductos.Clear();
            productoModel.cargarProductos(listaProductos);
        }
        private void cargarListaCategorias()
        {
            listaCategorias.Clear();
            categoriaModel.cargarCategorias(listaCategorias);
        }
        private void mostrarEnDGV(DataGridView DGV, object lista)
        {
            DGV.DataSource = null;
            DGV.DataSource = lista;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = pedirNombreDeCategoria();

                categoriaModel.agregarCategoria(nombre);
                cargarListaCategorias();
                registro.registrarOperacion("Agrego Categoria", nombreLogin);
                mostrarEnDGV(dgvCategorias, listaCategorias.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private static string pedirNombreDeCategoria(string titulo = "", string actual = "")
        {
            var nombre = Interaction.InputBox("Nombre de Categoria", titulo, actual);
            if (nombre == "") throw new Exception("Debe ingresar un nombre para la Categoria");
            return nombre;
        }

        private void btnBorrarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategorias.Rows.Count == 0) throw new Exception("No hay categorias para borrar");
                var id_categoria = dgvCategorias.SelectedRows[0].Cells[0].Value;

                categoriaModel.borrarCategoria(Convert.ToInt32(id_categoria));
                cargarListaCategorias();
                registro.registrarOperacion("Borro Categoria", nombreLogin);
                mostrarEnDGV(dgvCategorias, listaCategorias.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategorias.Rows.Count == 0) throw new Exception("No hay categorias para modificar");
                var id_categoria = dgvCategorias.SelectedRows[0].Cells[0].Value;
                string nombre = pedirNombreDeCategoria("Modificando...", dgvCategorias.SelectedRows[0].Cells[1].Value.ToString());

                categoriaModel.actualizarCategoria(new Categorias(Convert.ToInt32(id_categoria), nombre));
                cargarListaCategorias();
                registro.registrarOperacion("Actualizo la Categoria de ID: " + id_categoria, nombreLogin);
                mostrarEnDGV(dgvCategorias, listaCategorias.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private bool categoriaExiste(int Id_Categoria)
        {
            bool existe = false;
            foreach (var categoria in listaCategorias)
            {
                if (categoria.Id_Categoria == Id_Categoria) { existe = true; break; }
            }
            return existe;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreProducto, precio, stock, id_categoria;
                pedirDatosProducto(out nombreProducto, out precio, out stock, out id_categoria, new string[] { "", "", "", "", "" });

                productoModel.agregarProducto(new Productos(0, nombreProducto, Convert.ToDecimal(precio), Convert.ToInt32(stock), Convert.ToInt32(id_categoria)));
                cargarListaProductos();
                registro.registrarOperacion("Agrego Producto", nombreLogin);
                mostrarEnDGV(dgvProductos, listaProductos.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void pedirDatosProducto(out string nombreProducto, out string precio, out string stock, out string id_categoria, string[] vector)
        {
            nombreProducto = Interaction.InputBox("Nombre del Producto", vector[0], vector[1]);
            if (nombreProducto == "") throw new Exception("Debe ingresar un nombre para el Producto");

            precio = Interaction.InputBox("Precio del Producto", vector[0], vector[2]);
            if (!Information.IsNumeric(precio)) throw new Exception("Ingrese un precio correcto");

            stock = Interaction.InputBox("Ingrese el Stock del Producto", vector[0], vector[3]);
            if (!Information.IsNumeric(stock)) throw new Exception("Ingrese un stock correcto");

            id_categoria = Interaction.InputBox("Ingrese el Id de la categoria del producto", vector[0], vector[4]);
            if (!Information.IsNumeric(id_categoria)) throw new Exception("Ingrese una categoria correcta");
            if (!categoriaExiste(Convert.ToInt32(id_categoria))) throw new Exception($"Categoria de Id:{id_categoria} no existe");
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.Rows.Count == 0) throw new Exception("No hay productos para borrar");
                var id_producto = dgvProductos.SelectedRows[0].Cells[0].Value;

                productoModel.borrarProducto(Convert.ToInt32(id_producto));
                cargarListaProductos();
                registro.registrarOperacion("Borro Producto", nombreLogin);
                mostrarEnDGV(dgvProductos, listaProductos.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.Rows.Count == 0) throw new Exception("No hay productos para modificar");
                var id_producto = dgvProductos.SelectedRows[0].Cells[0].Value;

                string nombreProducto, precio, stock, id_categoria;
                pedirDatosProducto(out nombreProducto, out precio, out stock, out id_categoria, new string[] { "Modificando...", dgvProductos.SelectedRows[0].Cells[1].Value.ToString(), dgvProductos.SelectedRows[0].Cells[2].Value.ToString(), dgvProductos.SelectedRows[0].Cells[3].Value.ToString(), dgvProductos.SelectedRows[0].Cells[4].Value.ToString() });

                productoModel.actualizarProducto(new Productos(Convert.ToInt32(id_producto), nombreProducto, Convert.ToDecimal(precio), Convert.ToInt32(stock), Convert.ToInt32(id_categoria)));
                cargarListaProductos();
                registro.registrarOperacion($"Actualizo Producto de ID: {id_producto}", nombreLogin);
                mostrarEnDGV(dgvProductos, listaProductos.ToList());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnVerOperaciones_Click(object sender, EventArgs e)
        {
            FormRegistros registrosForm = FormRegistros.ventanaUnica();
            registrosForm.Show();
            registrosForm.Focus();
        }

        private void btnUsuariosBloqueados_Click(object sender, EventArgs e)
        {
            FormUsuarios usuarios = FormUsuarios.ventanaUnica();
            usuarios.cargarUsuario(nombreLogin);
            usuarios.Show();
            usuarios.Focus();
        }
    }
}
