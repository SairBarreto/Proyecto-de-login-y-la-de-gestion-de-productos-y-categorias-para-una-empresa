using AccesoDeDatos;

namespace Dominio
{
    public class UsuarioModelo
    {
        UsuarioLogin usuarioLogin = new UsuarioLogin();

        public bool Login(string nombreLogin, string contrasenia, Usuario usuarioDatos) => usuarioLogin.Login(nombreLogin, contrasenia, usuarioDatos);
        public void bloqueoUsuario(string nombreLogin) => usuarioLogin.bloqueaUsuario(nombreLogin);
        public bool intentosLLegoAlMaximo(string nombreLogin) => usuarioLogin.intentosLLegoAlMaximo(nombreLogin);
        public void cargarUsuariosBloqueados(List<Usuario> listaUsuariosBloqueados) => usuarioLogin.cargarUsuariosBloqueados(listaUsuariosBloqueados);
        public void desbloquearUsuario(int Id_Usuario) => usuarioLogin.desbloquearUsuario(Id_Usuario);
        public void altaUsuario(Usuario nuevoUsuario, string password) => usuarioLogin.altaUsuario(nuevoUsuario, password);
    }
}
