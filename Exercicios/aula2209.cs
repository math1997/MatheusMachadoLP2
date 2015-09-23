using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Aulla_BD_22_09_2015
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registro de uma nova pessoa nesse mundão:");

            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            Console.WriteLine("insira o nome do usuário:");
            string n = Console.ReadLine();
            command.CommandText = string.Format("insert into Pessoa (Nome) Values('{0}')", n);
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            Console.WriteLine("Pessoa cadastrada. Obrigado. Vai com Deus. Boa noite. Bons sonhos.");
        }
    }
}
