using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDeDatos;

namespace PresentacionLoginLogout
{
    public partial class FormUsuario : Form
    {
        Usuario usuarioDatos;
        public FormUsuario()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public void cargarDatosUsuario(Usuario datosCargar)
        {
            usuarioDatos = new Usuario(datosCargar.Id_Usuario, datosCargar.Email, datosCargar.Nombre, datosCargar.Apellido, datosCargar.TipoDeUsuario);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Quieres cerrar la aplicación?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cargarDatosUsuario()
        {
            lbBienvidenido.Text += " " + usuarioDatos.Nombre + " " + usuarioDatos.Apellido;
            lbEmailUsuario.Text = "Email: " + usuarioDatos.Email;
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            cargarDatosUsuario();
        }
    }
}
