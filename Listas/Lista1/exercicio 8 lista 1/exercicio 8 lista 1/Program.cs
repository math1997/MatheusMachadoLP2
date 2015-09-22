using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_8_lista_1
{
    class Program
    {
        int M;
        int soma;
        int R;

        public void calcula()
        {
            Console.WriteLine("Digite um número: ");
            M = int.Parse(Console.ReadLine());

            R = M;

            int i = 1;
            while (i < M)
            {
                soma = R + (M - i);
                R = soma;
                i++;
                
            }
            
            Console.WriteLine("O resultado deu: " + soma);
        }
    }
}