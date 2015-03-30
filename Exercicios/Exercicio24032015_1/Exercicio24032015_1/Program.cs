using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio24032015_1
{
    class Program
    {
        static void Main(string[] args)
        {// criação variaveis
            int n;
            double num;
            double soma = 0;
            double maior = -1;
            double menor = 10000;


            //digitando a quantidade
            Console.WriteLine("Digite a quantidade:");
            n = int.Parse(Console.ReadLine());
            //laço para calculos
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Digite os numeros: ");
                num = int.Parse(Console.ReadLine());
                soma += num;

                if (num > maior);
                {
                    maior = num;   
                }
                if (num < menor)
                {
                    menor = num;
                }

                    
            }

            Console.WriteLine("Somando fica: {0}", soma);
            Console.WriteLine("o menor é: {0}", menor);
            Console.WriteLine("o maior é: {0}", menor);
            }
        }
    }
}
