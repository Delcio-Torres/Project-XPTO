using System;
using Model;
using System.Collections.Generic;
using System.Globalization;
using System.Data.SQLite;
using System.IO;

namespace Controller
{
    public class Connection
    {
        private const string file = "DB_XPTO.db";
        private readonly string path;

        public SQLiteConnection Conn { get; }

        public Connection()
        {
            Conn = new SQLiteConnection();
            path = $"{AppDomain.CurrentDomain.BaseDirectory}/DB";

            OpenDB();

            CreateTables();

            CloseDB();
        }
            
        public void OpenDB()
        {
            string fullPath = $"{path}/{file}";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (!File.Exists(fullPath))
            {
                File.Create(fullPath).Close();
            }

            Conn.ConnectionString = $"Data Source = {fullPath}";
            Conn.Open();
        }

        public void CloseDB()
        {
            if(Conn.State != System.Data.ConnectionState.Closed)
            {
                Conn.Close();
            }
        }

        private void CreateTables()
        {
            var query = @"
            CREATE TABLE IF NOT EXISTS TB_Worker(
                Id_Worker INTEGER PRIMARY KEY AUTOINCREMENT,
                Nome TEXT,
                Email TEXT,
                Cpf TEXT,
                DataNascimento DATE
            )";

            var com = Conn.CreateCommand();
            com.CommandText = query;
            com.Prepare();

            com.ExecuteNonQuery();
        }
    }
}
