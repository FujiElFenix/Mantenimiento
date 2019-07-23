using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CLConexion
{
    public abstract class Conexion
    {
        private readonly string ConectionString;

       public Conexion() {
            ConectionString = "server=PROGRAMADOR3; database=DBMantencion; integrated security=true";
        }
        protected SqlConnection GetConnection() {
            return new SqlConnection(ConectionString);
        }
        
    }
}
