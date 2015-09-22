using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula23062015
{
    class Program
    {
        static void Main(string[] args)
        {    // Criação de variaveis
            int M = int.Parse(Console.ReadLine());
            string[] name = new string[M];
            int[] CPF = new int[M];
            string[] DataNascimento = new string[M];
            double[] salario = new double[M];
            int[] dataAdmi = new int[M];
            double[] salario_reajuste = new double[N];
            // Execução
            for (int i = 0; i < M; i++)
            {
                name[i] = Console.ReadLine();
                CPF[i] = int.Parse(Console.ReadLine());
                DataNascimento[i] = Console.ReadLine();
                salario[i] = double.Parse(Console.ReadLine());
                dataAdmi[i] = int.Parse(Console.ReadLine());

                if (dataAdmi[i] >= 2014)
                {
                    salario_reajuste[i] = salario[i] + 423.45;
                }

                else if (dataAdmi[i] >= 2010 && dataAdmi[i] <= 2013)
                {
                    double aumento = salario[i] * 9.84 / 100;
                    salario_reajuste[i] = salario[i] + aumento;
                }

                else if (dataAdmi[i] >= 2000 && dataAdmi[i] <= 2009)
                {
                    double aumento2 = salario[i] * 16.4 / 100;
                    salario_reajuste[i] = salario[i] + aumento2;
                }

                else if (dataAdmi[i] <= 1999)
                {
                    double aumento3 = salario[i] * 22.6 / 100;
                    salario_reajuste[i] = salario[i] + aumento3;
                }

            }
            // O que será mostrado
            for (int j = 0; j < M; j++)
            {
                Console.WriteLine("CPF: " + CPF[j]);
                Console.WriteLine("Nome: " + name[j]);
                Console.WriteLine("Data de Nascimento: " + DataNascimento[j]);
                Console.WriteLine("Data de admissão: " + dataAdmi[j]);
                Console.WriteLine("Salario: " + salario[j]);
                Console.WriteLine("Novo Salario: " + salario_reajuste[j]);
            }
        }
    }
}