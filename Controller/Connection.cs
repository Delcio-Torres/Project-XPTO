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

         var com = cx.CreateCommand();

         com.CommandText = $"INSERT INTO TB_Worker (Nome, Email, Cpf, DataNascimento) VALUES (@Nome, @Email, @Cpf, @DataNascimento)";
         com.Prepare();

         com.Parameters.AddWithValue("@Nome", worker.Nome);
         com.Parameters.AddWithValue("@Email", worker.Email);
         com.Parameters.AddWithValue("@Cpf", worker.Cpf);
         com.Parameters.AddWithValue("@DataNascimento", worker.DataNascimeto);

         com.ExecuteNonQuery();

         CloseDB();
      }

      public List<Worker> GetAllWorker()
      {
         OpenDB();
         var com = cx.CreateCommand();
         string sql = "SELECT Id_Worker, Nome, Email, Cpf, DataNascimento FROM TB_Worker order by DataNascimento";
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
               DataNascimeto = (DateTime) dr["DataNascimento"]
            };
            workerList.Add(worker);
         }
         dr.Close();
         CloseDB();
         return workerList;
      }

   }
}
