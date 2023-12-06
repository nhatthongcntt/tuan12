using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace lienket_sql_qlnv
{
    internal class Connection
    {
        private static String StrCon = @"Data Source=DESKTOP-G925OAP;Initial Catalog=nhanvien;Integrated Security=True;TrustServerCertificate=True";
        public static SqlConnection getSqlConnection()
        {
            return new SqlConnection(StrCon);
        }
    }
}
