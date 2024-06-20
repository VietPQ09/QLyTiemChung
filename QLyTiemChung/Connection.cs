using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLyTiemChung
{
    public class Connection
    {
        public static string stringConnection = @"Data Source=VIETPHAM\SQLEXPRESS;Initial Catalog=VaccinationSys;Integrated Security=True";
        public static  SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
