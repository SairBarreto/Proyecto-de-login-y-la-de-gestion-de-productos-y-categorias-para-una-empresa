using AccesoDeDatos;
using Dominio;
using Microsoft.Win32;
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
    public partial class FormLogin : Form
    {
        string nombreUsuario;
        Log registro;
        public FormLogin()
        {
            InitializeComponent();
            cargarImagen();
            registro = new Log();
            txtContrasenia.PasswordChar = '*';
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cargarImagen()
        {
            string rutaCarpeta = AppDomain.CurrentDomain.BaseDirectory;
            string rutaImagen = Path.Combine(rutaCarpeta, "ImagenLogin", "FondoLogin2.jpg");

            if (File.Exists(rutaImagen))
            {
                // Cargar la imagen y asignarla como fondo del panel
                panelPrincipal.BackgroundImage = Image.FromFile(rutaImagen);
                panelPrincipal.BackgroundImageLayout = ImageLayout.Stretch; // Ajuste de la imagen
            }
            else
            {
                MessageBox.Show("La imagen de fondo no se encontró en la ruta especificada.");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombreLogin.Text == "") throw new Exception("Debe ingresar su Usuario.");
                if (txtContrasenia.Text == "") throw new Exception("Debe ingresar su contraseña.");

                Usuario usuarioDatos = new Usuario();
                UsuarioModelo usuario = new UsuarioModelo();
                
                if (usuario.intentosLLegoAlMaximo(txtNombreLogin.Text)) throw new Exception("El usuario a sido bloqueado, comuniquese con el administrador");
                var loginValido = usuario.Login(txtNombreLogin.Text, txtContrasenia.Text, usuarioDatos);
                nombreUsuario = usuarioDatos.Nombre + usuarioDatos.Apellido;

                if (loginValido)
                {
                    registro.registrarOperacion("Inicio de Sesion", nombreUsuario);
                    FormPrincipal mainMenu = new FormPrincipal();
                    mainMenu.cargarDatosUsuario(usuarioDatos);
                    mainMenu.Show();
                    mainMenu.FormClosed += Logout;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrestos. \nIntente de nuevo.");
                    txtContrasenia.Clear();
                    txtNombreLogin.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            registro.registrarOperacion("Cierre de Sesion", nombreUsuario);
            txtNombreLogin.Clear();
            txtContrasenia.Clear();
            this.Show();
            txtNombreLogin.Focus();
        }
    }
}
