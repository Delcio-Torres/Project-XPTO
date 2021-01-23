using System;

namespace Model
{
    public class Worker
    {
      public int Id { get; private set; }
      public string Nome { get; set; }
      public string Email { get; set; }
      public DateTime DataNascimeto { get; set; }
      public decimal Cpf { get; set; }

      public Worker()
      {
      }

      public Worker(string nome, string email, DateTime dataNascimeto, decimal cpf)
      {
         Nome = nome;
         Email = email;
         DataNascimeto = dataNascimeto;
         Cpf = cpf;
      }

      public Worker(int id, string nome, string email, DateTime dataNascimeto, decimal cpf)
      {
         Id = id;
         Nome = nome;
         Email = email;
         DataNascimeto = dataNascimeto;
         Cpf = cpf;
      }
   }
}

