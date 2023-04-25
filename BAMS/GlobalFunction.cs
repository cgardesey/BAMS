using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using settings = BAMS.Properties.Settings;

namespace BAMS
{
    public sealed class GlobalFunction
    {
        public static string cartNo;
        public static DataTable dt = new DataTable();

        //GET DATA FROM TABLE
    public static System.Data.DataTable getUnitPrice(string sql)
    {
     using (var myAdapter = new SqlDataAdapter(sql, settings.Default.BAMSConnectionString))
     {
         using (dt = new System.Data.DataTable())
         {
             myAdapter.Fill(dt);
            
         }
     }
     return dt;
    }

    }
   
}
