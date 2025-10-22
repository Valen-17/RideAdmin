using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHerramientas
{
    internal class ConexionBD
    {
        public static SqlConnection Conectar()
        {
            SqlConnection connect = new SqlConnection("Data Source = .\\SQLEXPRESS; Initial Catalog = RideAdminDB; Integrated Security = True");
            connect.Open();
            return connect;
        }
    }
}
