using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio 4 lista 1
{
    class program

    {
        // Variaveis
        int player1;
        int player2;
        int EndMatch = 1;
        int finish = 0;
        int totalPointsPlayer1 = 0;
        int totalPointsPlayer2 = 0;

        public void Vencedor()
        {
            // Laço
            while (EndMatch != finish)
            {
                Console.WriteLine();
                Console.WriteLine("Ponto Player 1: ");
                player1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ponto Player 2: ");
                player2 = int.Parse(Console.ReadLine());

                totalPointsPlayer1 += player1;
                totalPointsPlayer2 += player2;

                // Condição
                if (totalPointsPlayer1 == 21 && totalPointsPlayer2 < 20)
                {
                    EndMatch = finish;
                }
                else if (totalPointsPlayer2 == 21 && totalPointsPlayer1 < 20)
                {
                    EndMatch = finish;
                }

                else if (totalPointsPlayer1 > 21 && totalPointsPlayer1 >= totalPointsPlayer2 + 2)
                {
                    EndMatch = finish;
                }
                else if (totalPointsPlayer2 > 21 && totalPointsPlayer2 >= totalPointsPlayer1 + 2)
                {
                    EndMatch = finish;
                }
            }

            if (totalPointsPlayer1 > totalPointsPlayer2)
            {
                Console.WriteLine("O vencedor foi o Player 1 com " + totalPointsPlayer1 + " pontos");
            }
            else
            {
                Console.WriteLine("O vencedor foi o Player 2 com " + totalPointsPlayer2 + " pontos");
            }
            Console.WriteLine();
        }

    }
}