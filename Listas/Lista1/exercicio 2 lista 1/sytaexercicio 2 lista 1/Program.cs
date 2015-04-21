using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sytaexercicio_2_lista_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
        double divisor;
        double dv = 0;
        double Res;
        double resultado = 0;
        

        public void calculoComFatorial()
        {
         EX2 exercicio2 = new EX2 exercicio2();

        Console.WriteLine("Informe o número: "); // Limite = 47
        N = int.Parse(Console.ReadLine());

        int t = 1;
        double D;  
        int DV;
        int dv;
            int D;
        int r = 0;
       int div;
            int result;
            int Res;
            int N;
        while (r <= N)
        {
            div = dv + (dv + 1);
            D = div + (div + 1);
            D = int.Parse();
            DV = D + (D + 1);
            dv = DV;

            Res  = exercicio2.calculaFatorial(t) / div - exercicio2.calculaFatorial(t++) / D;
            result = Res;

            N--; 

            if (r <= N)
            {
                Res = result + exercicio2.calculaFatorial(t++) / DV;
                result = Res;

                N--;
            }

            t++;
            r++;
        }
     
        Console.WriteLine("O resultado é: " + Res);
        Console.WriteLine();
        }
    }
}
