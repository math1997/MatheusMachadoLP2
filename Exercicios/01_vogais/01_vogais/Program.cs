using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_vogais
{
    class Program
    {
        static void Main(string[] args)
        {
            string vogais = "AEIOUÁÉÍÓÚáéíóúaeiouàÀ";
            int quantidade = -1;
            string frase;
            Console.WriteLine("Digite a frase: ");
            frase = Console.Read().ToString();
            
            
            for (int i = 0; i < frase.Length; i++)
            {
                for (int y = 0; y < vogais.Length; y++)
                {
                    if (frase[i] == vogais[y])
                    {
                        quantidade += 1;
                    }
                }
            }

            if (quantidade > 1)
            {
                Console.WriteLine("a frase possui {0} vogais", quantidade);
            }
            if (quantidade == 0)
            {
                Console.WriteLine("a frase possuí apenas uma vogal");
            }
            else
            {
                Console.WriteLine("a frase não possuí vogais");
            }
            Console.ReadKey();
        }


    }
}
