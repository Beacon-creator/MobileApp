using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MobileApp.Tables
{
    public class DatabaseHelper
    {
        public SQLiteConnection Ddatabase { get; }

        public DatabaseHelper()
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "mydatabase.db3");
            Ddatabase = new SQLiteConnection(dbPath);
            Ddatabase.CreateTable<User>();
        }

        // Additional database operations (e.g., CRUD operations) can be added here
    }
}
