using AccesoDeDatos;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionLoginLogout
{
    public partial class FormAdministrador : Form
    {
        Usuario usuarioDatos;
        List<Usuario> listaUsuariosBloqueados;
        public FormAdministrador()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void cargarDatosUsuario(Usuario datosCargar)
        {
            usuarioDatos = new Usuario(datosCargar.Id_Usuario, datosCargar.Email, datosCargar.Nombre, datosCargar.Apellido, datosCargar.TipoDeUsuario);
        }

        private void cargarDatosUsuario()
        {
            lbNombreAdmin.Text = usuarioDatos.Nombre + " " + usuarioDatos.Apellido;
            lbEmailUsuario.Text = "Email: " + usuarioDatos.Email;
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            cargarDatosUsuario();
            listaUsuariosBloqueados = new List<Usuario>();
            cargarLista();
            mostrarEnDGV(dgvUsuariosBloqueados, listaUsuariosBloqueados.ToList());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres cerrar la aplicación?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cargarLista()
        {
            UsuarioModelo usuario = new UsuarioModelo();
            listaUsuariosBloqueados.Clear();
            usuario.cargarUsuariosBloqueados(listaUsuariosBloqueados);
        }

        private void mostrarEnDGV(DataGridView DGV, List<Usuario> lista)
        {
            DGV.DataSource = null;
            DGV.DataSource = lista;
        }

        private void btnDesbloquearUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuariosBloqueados.Rows.Count == 0) throw new Exception("No hay usuarios para desbloquear");
                var usuarioSeleccionado = dgvUsuariosBloqueados.SelectedRows[0].DataBoundItem as Usuario;
                UsuarioModelo usuario = new UsuarioModelo();
                usuario.desbloquearUsuario(usuarioSeleccionado.Id_Usuario);
                cargarLista();
                mostrarEnDGV(dgvUsuariosBloqueados, listaUsuariosBloqueados.ToList());
                MessageBox.Show($"El Usuario: {usuarioSeleccionado.Nombre + " " + usuarioSeleccionado.Apellido} a sido desbloqueado");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
