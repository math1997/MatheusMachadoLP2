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
            Console.WriteLine("Escolha a ação desejada: \n 1. Cadastro \n 2. Consulta");
            Console.WriteLine("");
            int escolha = int.Parse(Console.ReadLine());
      

            if (escolha == 1)
            {
                Pessoa pessoa = new Pessoa();
                Console.WriteLine("Nome: ");
                pessoa.nome = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Sobrenome: ");
                pessoa.sobrenome = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Peso: ");
                pessoa.peso = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Altura: ");
                pessoa.altura = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Telefone");
                pessoa.telefone = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("CADASTRO REALIZADO COM SUCESSO!");

                command.CommandText = String.Format("INSERT INTO PESSOA (NOME, SOBRENOME, PESO, ALTURA, TELEFONE) VALUES ('{0}', '{1}', {2}, {3}, '{4}')", pessoa.nome, pessoa.sobrenome, pessoa.peso, pessoa.altura, pessoa.telefone);
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            else if (escolha == 2)
            {
                Console.WriteLine(" 1. ID \n 2. Nome");
                Console.WriteLine("");
                int escolhaConsulta = int.Parse(Console.ReadLine());

                if (escolhaConsulta == 1)
                {
                    Console.WriteLine("ID para consulta: ");
                    int idConsulta = int.Parse(Console.ReadLine());
                    command.CommandText = String.Format("SELECT INTO PESSOA (ID) VALUES ('{0}')", idConsulta);
                }

                else if (escolhaConsulta == 2)
                {
                    Console.WriteLine("Nome para consulta: ");
                    string nomeConsulta = Console.ReadLine();
                    command.CommandText = String.Format("SELECT INTO PESSOA (NOME) VALUES ('{0}')", nomeConsulta);
                }
               
                conn.Open();
                command.ExecuteReader();

                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Pessoa p = new Pessoa();
                        Console.Write("ID: ");
                        p.ID = reader.GetInt32(0);
                        Console.Write("Nome: ");
                        p.nome = reader.GetString(1);
                        Console.Write("Sobrenome: ");
                        p.sobrenome = reader.GetString(2);
                        Console.Write("Peso: ");
                        p.peso = reader.GetDouble(3);
                        Console.Write("Altura: ");
                        p.altura = reader.GetDouble(4);
                        Console.Write("Telefone: ");
                        p.telefone = reader.GetString(5);
                    }
                }
                else
                {
                    Console.Write("INFORMAÇÃO INVÁLIDA!");
                }

                conn.Close();
            }
            else
            {
              
            }
          
        }
    }
}
