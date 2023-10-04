using System;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;
namespace DAL
{
    public class KetNoi : IKetNoi
    {

        private static KetNoi obj = null;
        private SqlConnection connection=null;
        private string key = "";
        private KetNoi()
        {

        }
        public static KetNoi LayDoiTuong() 
        {
            if (obj == null) obj = new KetNoi();           
            return obj;
        }


        public void ThucThi(string query)
        {
            using (connection=new SqlConnection(key)) 
            {
                connection.Query(query);
            }
        }

        public List<T> TruyVan<T>(string query)
        {
            List<T> danhsach = null;
            using (connection = new SqlConnection(key))
            {
                danhsach = connection.Query<T>(query).AsList();
            }
            return danhsach;
        }
    }
}
