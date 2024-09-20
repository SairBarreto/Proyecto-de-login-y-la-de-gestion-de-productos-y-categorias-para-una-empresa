using System.Data.SqlClient;

namespace AccesoDeDatos
{
    public abstract class ConexionSQL
    {
        private string cadenaDeConexion;

        public ConexionSQL()
        {
            this.cadenaDeConexion = @"Data Source=; Initial Catalog=DAS_TP3; Integrated Security=True";
        }

        protected SqlConnection getConexion() => new SqlConnection(this.cadenaDeConexion);
    }
}
