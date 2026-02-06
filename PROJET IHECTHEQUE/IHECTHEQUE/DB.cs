using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IHECTHEQUE
{
    public static class DB
    {
        public static SqlConnection GetConnection()
        {
            // ✅ Vérifie bien ici que le nom de ta base est correct !
            return new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=GestionBibliotheque;Integrated Security=true");
        }
    }
}
