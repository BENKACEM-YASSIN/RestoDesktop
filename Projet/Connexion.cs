using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Projet
{
    class Connexion
    {
        public static DataSet ds = new DataSet();
        public static String cs = @"Data Source =KHALILELB;Initial catalog = projetKBv2 ; User ID =sa ; Password =123456";
        public static SqlConnection cn = new SqlConnection();



        public static void ouvrirConnection()
        {


            if (cn.State != ConnectionState.Open)
            {
                cn.ConnectionString = cs;    
                cn.Open();
            }

        }

        public static void fermerConnection()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
    }
}
