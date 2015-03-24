using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP2Pratica
{
    class Program
    {
        static void Main(string[] args)
        { // criação de variaveis
            int numbers = 0;
            int media;
            int z = 1;
            int i = 0;
            // Loop para verificar se o numero é maior que zero
            while (z != 0)
            {
                Console.WriteLine("Digite os numeros: ");
                z = int.Parse(Console.ReadLine());

                numbers += z;
                i++;
            }


            Console.WriteLine();
            media = numbers / (i - 1);

            Console.WriteLine("A média é: " + media);
        }
    }
}
