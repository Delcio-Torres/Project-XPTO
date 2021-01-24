using System;
using Model;
using System.Collections.Generic;
using System.Globalization;
using System.Data.SQLite;

namespace Controller
{
   public class Connection
   {
      private SQLiteConnection cx = new SQLiteConnection();
      private SQLiteCommand com = new SQLiteCommand();
      private SQLiteDataAdapter da = new SQLiteDataAdapter();

      string path = $"Data Source = {AppDomain.CurrentDomain.BaseDirectory}/DB/DB_XPTO.db";

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
         string sql = $"INSERT INTO TB_Worker (Nome, Email, Cpf, DataNascimento) VALUES ('{worker.Nome}', '{worker.Email}', '{worker.Cpf}', '{worker.DataNascimeto}')";

         com.CommandText = sql;
         com.Connection = cx;
         com.ExecuteNonQuery();

         CloseDB();
      }

      public List<Worker> GetAllWorker()
      {
         OpenDB();
         string sql = "SELECT Id_Worker, Nome, Email, Cpf, DataNascimento FROM TB_Worker";
         com.CommandText = sql;
         com.Connection = cx;
         SQLiteDataReader dr = com.ExecuteReader();

         List<Worker> workerList = new List<Worker>();

         while (dr.Read())
         {
            Worker worker = new Worker
            {
               Id = Convert.ToInt32(dr["Id_Worker"]),
               Nome = dr["Nome"].ToString(),
               Email = dr["Email"].ToString(),
               Cpf = dr["Cpf"].ToString(),
               DataNascimeto = dr["DataNascimento"].ToString()
            };
            workerList.Add(worker);
         }
         dr.Close();
         CloseDB();
         return workerList;
      }

   }
}
