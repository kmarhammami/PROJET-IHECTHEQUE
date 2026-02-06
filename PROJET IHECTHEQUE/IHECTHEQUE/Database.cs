using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHECTHEQUE
{
    internal static class Database
    {
        public static string ConnectionString =
    @"Data Source=TIMC\SSMS;Initial Catalog=GestionBibliotheque;Integrated Security=True;";


        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
