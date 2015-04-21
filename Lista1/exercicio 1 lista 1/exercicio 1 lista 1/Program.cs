using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1_lista_1
{
    class Program
    {
        static void Main(string[] args)

        {
            // criação variaveis
            int fact = 1;
            int fat = 0;
            
            Console.WriteLine("Digite um numero, cujo fatorial voce quer obter");
            // conversão para inteiro
            fat = int.Parse(Console.ReadLine());
            // fatoração
            for (int i = 0; i < fat; i++)
            {
                fact *= (fat - i);
            }
            Console.WriteLine("O Fatorial de {0} = {1}", fat, fact);         
        }
    }
}
