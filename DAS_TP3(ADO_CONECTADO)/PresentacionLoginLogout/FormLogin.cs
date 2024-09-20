using AccesoDeDatos;
using Dominio;

namespace PresentacionLoginLogout
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            cargarImagen();
            txtContrasenia.PasswordChar = '*';
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void cargarImagen()
        {
            string rutaCarpeta = AppDomain.CurrentDomain.BaseDirectory;
            string rutaImagen = Path.Combine(rutaCarpeta, "ImagenLogin", "FondoLogin.jpg");

            if (File.Exists(rutaImagen))
            {
                // Cargar la imagen y asignarla como fondo del panel
                panelImagen.BackgroundImage = Image.FromFile(rutaImagen);
                panelImagen.BackgroundImageLayout = ImageLayout.Stretch; // Ajuste de la imagen
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
                
                if (loginValido)
                {
                    if(usuarioDatos.TipoDeUsuario == "Admin")
                    {
                        FormAdministrador mainMenu = new FormAdministrador();
                        mainMenu.cargarDatosUsuario(usuarioDatos);
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide(); //Oculta el login
                    }
                    else
                    {
                        FormUsuario mainMenu = new FormUsuario();
                        mainMenu.cargarDatosUsuario(usuarioDatos);
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                }
                else
                {
                    usuario.bloqueoUsuario(txtNombreLogin.Text);
                    MessageBox.Show("Usuario y/o Contraseña incorrestos. \nIntente de nuevo.");
                    txtContrasenia.Clear();
                    txtNombreLogin.Focus();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtNombreLogin.Clear();
            txtContrasenia.Clear();
            this.Show();
            txtNombreLogin.Focus();
        }
    }
}
