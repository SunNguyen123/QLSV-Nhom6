using System.Collections.Generic;
using System.Data;
using Dapper;
namespace DAL
{
   public interface IKetNoi
    {
        List<T> TruyVan<T>(string query);
        void ThucThi(string query);
    }
}
