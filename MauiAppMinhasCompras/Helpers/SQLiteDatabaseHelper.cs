using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiAppMinhasCompras.Models;
using SQLite;  

namespace MauiAppMinhasCompras.Helpers
{
    public class SQLiteDatabaseHelper
    {
        private readonly SQLiteAsyncConnection _conn;  

        public SQLiteDatabaseHelper(string path)
        {
           
            _conn = new SQLiteasyncConnection(path);
            _conn.CreateTable<Produto>(); 
        }

        public Task<int> InsertAsync(Produto p)
        {
            
            string sql = "UPDATE produto SET descricao = ?, Quantidade = ?, preco = ? WHERE Id = ?";


            return _conn.QueryAsync(sql, p.Descricao, p.Quantidade, p.Preco, p.Id);
        }
    }
}
