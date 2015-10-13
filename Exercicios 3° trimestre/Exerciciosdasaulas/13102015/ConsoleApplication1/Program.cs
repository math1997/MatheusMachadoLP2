using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;

            int escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {
                Pessoa pessoa = new Pessoa();

                pessoa.nome = Console.ReadLine();
                pessoa.sobrenome = Console.ReadLine();
                pessoa.peso = double.Parse(Console.ReadLine());
                pessoa.altura = double.Parse(Console.ReadLine());
                pessoa.telefone = Console.ReadLine();

                command.CommandText = String.Format("INSERT INTO PESSOA (NOME, SOBRENOME, PESO, ALTURA, TELEFONE) VALUES ('{0}', '{1}', {2}, {3}, '{4}')", pessoa.nome, pessoa.sobrenome, pessoa.peso, pessoa.altura, pessoa.telefone);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            else if (escolha == 2)
            {

                command.CommandText = String.Format("SELECT......");
                conn.Open();
                command.ExecuteReader();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    
                }

                conn.Close();
            }
            else
            {
              
            }
          
        }
    }
}
