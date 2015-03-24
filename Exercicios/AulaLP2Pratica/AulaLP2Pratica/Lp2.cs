using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace AulaLP2Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList numeros = new ArrayList();
         // Criação de variaveis
            int num = 1;
            int quantidade = 0;
            int resultado;
            // Loop para realizar as operações, contar os números e verificar se o numero é maior que zero

            for (int i = 0; num != 0; i++)
            {
                Console.WriteLine("Digite um valor para num: ");
                num = int.Parse(Console.ReadLine());

                numeros.Add(num);
                numeros.Remove(0);

                quantidade += num;
            }
            Console.WriteLine();

            resultado = quantidade / numeros.Count;
            Console.WriteLine("A média aritmética é: " + resultado);

        }
    }
}
