using AccesoDeDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAdministradorDeProductos
{
    public partial class FormUsuarios : Form
    {
        UsuarioModelo usuarioModel;
        List<Usuario> listaUsuariosBloqueados;
        Log registro;
        string nombreLogin;
        private static FormUsuarios instancia = null;
        public static FormUsuarios ventanaUnica()
        {
            if (instancia == null || instancia.IsDisposed) { return instancia = new FormUsuarios(); }
            return instancia;
        }
        public FormUsuarios()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            usuarioModel = new UsuarioModelo();
            registro = new Log();
        }
        public void cargarUsuario(string nombreUserLogin)
        {
            nombreLogin = nombreUserLogin;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres cerrar la aplicación?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            listaUsuariosBloqueados = new List<Usuario>();
            cargarLista();
            mostrarEnDGV(dgvUsuariosBloqueados, listaUsuariosBloqueados.ToList());
        }

        private void mostrarEnDGV(DataGridView DGV, List<Usuario> lista)
        {
            DGV.DataSource = null;
            DGV.DataSource = lista;
        }

        private void cargarLista()
        {
            listaUsuariosBloqueados.Clear();
            usuarioModel.cargarUsuariosBloqueados(listaUsuariosBloqueados);
        }

        private void btnDesbloquearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuariosBloqueados.Rows.Count == 0) throw new Exception("No hay usuarios para desbloquear");
                var usuarioSeleccionado = dgvUsuariosBloqueados.SelectedRows[0].DataBoundItem as Usuario;

                usuarioModel.desbloquearUsuario(usuarioSeleccionado.Id_Usuario);
                cargarLista();
                mostrarEnDGV(dgvUsuariosBloqueados, listaUsuariosBloqueados.ToList());
                MessageBox.Show($"El Usuario: {usuarioSeleccionado.Nombre + " " + usuarioSeleccionado.Apellido} a sido desbloqueado");
                registro.registrarOperacion($"Se desbloqueo al usuario {usuarioSeleccionado.Nombre + " " + usuarioSeleccionado.Apellido}", nombreLogin);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAltaUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text == "" || txtApellido.Text == "" || txtEmail.Text == "" || cbSeleccionTipo.Text == "" || txtPassword.Text == "") throw new Exception("Todos los campos del usuario deben estar completos para dar de alta");

                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string email = txtEmail.Text;
                string tipo = cbSeleccionTipo.Text;

                usuarioModel.altaUsuario(new Usuario(email, nombre, apellido, tipo), txtPassword.Text);
                MessageBox.Show($"El se dio de alta exitosamente el usuario. \nDatos.\nNombre Login: {nombre + apellido} \nEmail: {email}");

                registro.registrarOperacion($"Se creo un cuenta de tipo {tipo}", nombreLogin);
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEmail.Text = "";
                cbSeleccionTipo.Text = "";
                txtPassword.Text = "";
                txtNombre.Focus();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
