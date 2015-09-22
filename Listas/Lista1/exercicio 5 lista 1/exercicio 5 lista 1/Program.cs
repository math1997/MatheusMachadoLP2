using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5_lista_1
{
    class  program
    {
        int QTDlitrosTanque = 50;
        int distance = 600;
        int litrosG;
        int DP;

        public void Medidor()
        {
            while (QTDlitrosTanque > 0 && distance >= 0)
            {
                Console.WriteLine("Quantos kms foram percorridos? ");
                DP = int.Parse(Console.ReadLine());

                Console.WriteLine("Quantos litros foram gastos? ");
                litrosG = int.Parse(Console.ReadLine());


                QTDlitrosTanque -= litrosG;
                distance -= DP;

                if (QTDlitrosTanque <= 0 && distance > 0)
                {
                    Console.WriteLine("O carro não chegou ao seu destino por falta de combustível");
                }

               

                else if (QTDlitrosTanque < 0)
                {
                    Console.WriteLine("Há um erro, a quantidade de combustível não pode ser menor que 0");
                }

                else if (QTDlitrosTanque >= 0 && distance <= 0)
                {
                    Console.WriteLine("O carro chegou ao seu destino");
                }
            }

        }
    }
}