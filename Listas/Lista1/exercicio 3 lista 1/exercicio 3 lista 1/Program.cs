using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3_lista_1
{
    class program 
    {
        // variaveis
        int numeroFuncionarios;
        int i = 0;

        public void calculaNewSalary()
        {
            Console.WriteLine();
            Console.WriteLine("Informe o numero de funcionários: ");
            numeroFuncionarios = int.Parse(Console.ReadLine());

            string[] nomeFuncionarios = new string[numeroFuncionarios];
            double[] salary = new double[numeroFuncionarios];
            double[] NewSalary = new double[numeroFuncionarios];
            //laço

            while (i < numeroFuncionarios)
            {
                Console.WriteLine("Nome do funcionário: ");
                nomeFuncionarios[i] = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Informe o salário que este funcionário recebe:  ");
                salary[i] = double.Parse(Console.ReadLine());

                if (salary[i] >= 0 && salary[i] <= 2999)
                {
                    NewSalary[i] = salary[i] + (salary[i] / 100) * 25;
                }
                else if (salary[i] >= 3000 && salary[i] <= 3999)
                {
                    NewSalary[i] = salary[i] + (salary[i] / 100) * 20;
                }
                else if (salary[i] >= 4000 && salary[i] <= 4999)
                {
                    NewSalary[i] = salary[i] + (salary[i] / 100) * 15;
                }
                else
                {
                    NewSalary[i] = salary[i] + (salary[i] / 100) * 10;
                }
                i++;
            }

            for (int y = 0; y < numeroFuncionarios; y++)
            {
                Console.WriteLine("funcionário(a) " + nomeFuncionarios[y] + " Atual salario: " + salary[y] + " Salário novo: " + NewSalary[y]);
            }

        }
    }
}
