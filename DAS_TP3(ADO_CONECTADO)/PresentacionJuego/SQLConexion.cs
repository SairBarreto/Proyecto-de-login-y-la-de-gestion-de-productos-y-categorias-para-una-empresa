using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PresentacionJuego
{
    internal class SQLConexion
    {
        public string cadenaDeConexion { get; set; }
        public SQLConexion()
        {
            this.cadenaDeConexion = @"Data Source=; Initial Catalog=DAS_TP3; Integrated Security=True";
        }

        public SqlConnection getConexion() => new SqlConnection(this.cadenaDeConexion);
    }
}
