using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_11
{
    class Program
    {
        static void Main(string[] args)
        { // criação variaveis
            int n = int.Parse(Console.ReadLine());
            int[] idCarro = new int[n + 1];
            string[] model = new string[n + 1];
            string[] marca = new string[n + 1];
            string[] plc = new string[n + 1];
            int[] capacidadePassageiros = new int[n + 1];
            // execução
            int[] passageiros = new int[n + 1];
            for (int i = 1; i <= n; i++)
                passageiros[i] = 0;

            bool[] lotado = new bool[n + 1];

            for (int i = 1; i <= n; i++)
            {
                idCarro[i] = i;
                model[i] = Console.ReadLine();
                marca[i] = Console.ReadLine();
                plc[i] = Console.ReadLine();
                capacidadePassageiros[i] = int.Parse(Console.ReadLine());
            }

            int id = 0;
            bool todosCarrosLotados = false;
            int carroCheios = 0;

            while (id != -1 && todosCarrosLotados == false)
            {
                id = int.Parse(Console.ReadLine());

                if (id <= n && id > 0)
                {
                    if (lotado[id] != true)
                    {
                        passageiros[id]++;

                        if (passageiros[id] == capacidadePassageiros[id])
                        {
                            lotado[id] = true;
                            Console.WriteLine("Não há vagas restantes");

                            carroCheios = 0;

                            for (int i = 1; i <= n; i++)
                            {
                                if (lotado[i] == true)
                                    carroCheios++;
                            }

                            if (carroCheios == n)
                                todosCarrosLotados = true;
                        }

                        else
                            Console.WriteLine("Há {0} vaga(s) restante(s)", capacidadePassageiros[id] - passageiros[id]);
                    }

                    else
                    {
                        Console.WriteLine("Carro cheio");

                        carroCheios = 0;

                        for (int i = 1; i <= n; i++)
                        {
                            if (lotado[i] == true)
                                carroCheios++;
                        }

                        if (carroCheios == n)
                            todosCarrosLotados = true;
                    }
                }

                else if (id > n)
                    Console.WriteLine("Carro invalido");
            }
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("\r\nCarro {0}: {1} - {2} ({3})", idCarro[i], model[i], marca[i], plc[i]);
                Console.WriteLine("Passageiros : {0}", passageiros[i]);
                if (lotado[i] != true)
                    Console.WriteLine("vagas restante: {0}", capacidadePassageiros[i] - passageiros[i]);

                else
                    Console.WriteLine("Carro cheio");
            }

            int totalPeople = 0;

            for (int i = 1; i <= n; i++)
                totalPeople += passageiros[i];

            Console.WriteLine("\r\nTotal de pessoas na viagem: {0}", totalPeople);
        }
    }
}
