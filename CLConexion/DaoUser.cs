using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CLConexion
{
    public class DaoUser : Conexion
    {

        public bool Login(string user, string pass)
        {
            using (var Connection = GetConnection())
            {
                Connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = Connection;
                    command.CommandText = "Select * from Usuario where Username=@Username and Password=@Password";
                    command.Parameters.AddWithValue("@Username", user);
                    command.Parameters.AddWithValue("@Password", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}