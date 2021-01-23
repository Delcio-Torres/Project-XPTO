using System;
using Model;
using System.Data.SQLite;

namespace Controller
{
   public class Connection
   {
      private SQLiteConnection cx = new SQLiteConnection();
      private SQLiteCommand com = new SQLiteCommand();

      string path = $"Data Source = {AppDomain.CurrentDomain.BaseDirectory}BD_XPTO.db";

      public void OpenDB()
      {
         cx.ConnectionString = path;
         cx.Open();
      }

      public void CloseDB()
      {
         cx.Close();
      }

      public void InsertWorker(Worker worker)
      {
         OpenDB();
         string sql = $"INSERT INTO TB_Worker (Nome, Email, Cpf, DataNascimento) VALUES ('{worker.Nome}', '{worker.Email}', '{worker.Cpf}', '{worker.DataNascimeto.ToString("dd/MM/yy")}')";

         com.CommandText = sql;
         com.Connection = cx;
         com.ExecuteNonQuery();

         CloseDB();
      }

   }
}
