using Model;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class Operations
    {
        private readonly Connection _connection;

        public Operations()
        {
            _connection = new Connection();
        }

        public void InsertWorker(Worker worker)
        {
            var sql = $"INSERT INTO TB_Worker (Nome, Email, Cpf, DataNascimento) VALUES (@Nome, @Email, @Cpf, @DataNascimento)";
            var parameters = new Dictionary<string, object>
            {
                { "@Nome", worker.Nome },
                { "@Email", worker.Email },
                { "@Cpf", worker.Cpf },
                { "@DataNascimento", worker.DataNascimeto}
            };

            ExecuteCommand(sql, parameters);
        }

        public List<Worker> GetAllWorker()
        {
            string sql = "SELECT Id_Worker, Nome, Email, Cpf, DataNascimento FROM TB_Worker order by DataNascimento";

            var result = ExecuteQuery(sql);

            return result.ToList();
        }

        public Worker GetWorker(int id)
        {
            string sql = $"SELECT Id_Worker, Nome, Email, Cpf, DataNascimento FROM TB_Worker WHERE ID_Worker = @Id_Worker ORDER BY Nome";
            var parameters = new Dictionary<string, object>
            {
                { "@Id_Worker", id }
            };

            var result = ExecuteQuery(sql, parameters);

            return result.First();
        }

        private void ExecuteCommand(string sql, IDictionary<string, object> parameters)
        {
            _connection.OpenDB();

            var cmd = _connection.Conn.CreateCommand();

            cmd.CommandText = sql;
            cmd.Prepare();

            if(parameters != null && parameters.Any())
            {
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }
            }

            cmd.ExecuteNonQuery();

            _connection.CloseDB();
        }

        private IEnumerable<Worker> ExecuteQuery(string sql, IDictionary<string, object> parameters = null)
        {
            _connection.OpenDB();

            var cmd = _connection.Conn.CreateCommand();

            cmd.CommandText = sql;
            cmd.Connection = _connection.Conn;

            if (parameters != null && parameters.Any())
            {
                cmd.Prepare();
                foreach (var parameter in parameters)
                {
                    cmd.Parameters.AddWithValue(parameter.Key, parameter.Value);
                }
            }

            var dataReader = cmd.ExecuteReader();

            var workers = new List<Worker>();

            while (dataReader.Read())
            {
                workers.Add
                (
                    new Worker
                    {
                        Id = Convert.ToInt32(dataReader["Id_Worker"]),
                        Cpf = dataReader["Cpf"].ToString(),
                        DataNascimeto = (DateTime)dataReader["DataNascimento"],
                        Email = dataReader["Email"].ToString(),
                        Nome = dataReader["Nome"].ToString()
                    }
                );
            }

            _connection.CloseDB();

            return workers;
        }
    }
}
