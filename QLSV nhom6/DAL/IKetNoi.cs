using System.Collections.Generic;
using System.Data;
using Dapper;
namespace DAL
{
   public interface IKetNoi
    {
        string Key { set;  }
        List<T> TruyVan<T>(string query);
        void ThucThi(string query);
    }
}
