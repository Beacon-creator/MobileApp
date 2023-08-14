using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;

namespace MobileApp.Tables
{
    public class DataBase
    {
      private readonly SQLiteAsyncConnection _database;

        public DataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<User>();    
        }
        public Task<List<User>> GetPeopleAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<int> SavePersonAsync(User person)
        {
            return _database.InsertAsync(person);
        }
    }
}
