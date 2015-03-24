using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaLP2Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numeros = new ArrayList();
            int num = 1;
            int soma = 0;
            int resultado;
            // Loop para realizar as operações e contar os números

            for (int i = 0; num != 0; i++)
            {
                Console.WriteLine("Digite um valor para n: ");
                num = int.Parse(Console.ReadLine());

                numeros.Add(num);
                numeros.Remove(0);

                soma += num;
            }
            Console.WriteLine();

            resultado = soma / numeros.Count;
            Console.WriteLine("A média aritmética é: " + resultado);

        }
    }
}
