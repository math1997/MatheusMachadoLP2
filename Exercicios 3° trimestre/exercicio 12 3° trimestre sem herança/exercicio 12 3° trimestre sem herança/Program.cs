using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12_3__trimestre_sem_herança
{
    class Program
    {
        static void Main(string[] args)
        { int qtdFuncionarios;
            double despesa_da_empresa = 0;
            string tipoFuncionario;
             funcionariosdaempresaClass1 f = new funcionariosdaempresaClass1();

      
            Console.WriteLine("Informe a quantidade de funcionários: ");
            qtdFuncionarios = Convert.ToInt32(Console.ReadLine());
           
            Classterceirizados terceirizado = new Classterceirizados();
            Classtrabalhador trabalhador = new Classtrabalhador();
            classgerente gerente = new classgerente();

            
            List<Classterceirizados> terceirizados = new List<Classterceirizados>();
            List<Classtrabalhador> trabalhadores = new List<Classtrabalhador>();
            List<classgerente> gerentes = new List<classgerente>();

            int j = 0;
            int k = 0;
            int l = 0;

            for (int i = 0; i < qtdFuncionarios; i++)
            {
                Console.WriteLine("Informe se o funcionário em questão é um terceirizado, trabalhador ou gerente: ");
                tipoFuncionario = Console.ReadLine();
                Console.WriteLine();

                if (tipoFuncionario == "terceirizado")
                {
                    Console.Write("Nome: ");
                    terceirizado.Nome = Console.ReadLine();

                    Console.WriteLine("Matrícula: ");
                    terceirizado.Matricula = Console.ReadLine();

                    Console.Write("Data Nascimento: ");
                    terceirizado.Data_nascimento = Console.ReadLine();

                    Console.Write("CPF: ");
                    terceirizado.cpf = Console.ReadLine();

                    Console.Write("CNPJ: ");
                    terceirizado.cnpj = Console.ReadLine();

                    terceirizados.Add(terceirizado);
                    k++;
                }

                else if (tipoFuncionario == "trabalhador")
                {
                    double valeAlimentacaoTrabalhador = trabalhador.valor_vale_alimentacao();

                    Console.Write("Nome: ");
                    trabalhador.Nome = Console.ReadLine();

                    Console.Write("Matrícula: ");
                    trabalhador.Matricula = Console.ReadLine();

                    Console.Write("Data Nascimento: ");
                    trabalhador.Data_nascimento = Console.ReadLine();

                    Console.Write("CPF: ");
                    trabalhador.cpf = Console.ReadLine();

                    trabalhadores.Add(trabalhador);
                    j++;
                }

                else if (tipoFuncionario == "gerente")
                {
                    Console.Write("Nome: ");
                    gerente.Nome = Console.ReadLine();

                    Console.Write("Matrícula: ");
                    gerente.Matricula = Console.ReadLine();

                    Console.Write("Data Nascimento: ");
                    gerente.Data_nascimento = Console.ReadLine();

                    Console.Write("CPF: ");
                    gerente.cpf = Console.ReadLine();

                    Console.Write("Área de Atuação: ");
                    gerente.AreaAtuacao = Console.ReadLine();

                    Console.WriteLine();

                    gerentes.Add(gerente);
                    l++;
                }

            }
             
                if(terceirizados.Count > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Terceirizados");
                    Console.WriteLine();

                   for (int m = 0; m < terceirizados.Count; m++)
                   {
                    Console.WriteLine("Nome: " + terceirizados[m].Nome);
                    Console.WriteLine("Terceirizado: " + terceirizados[m].Matricula);
                    Console.WriteLine("Data Nascimento: " + terceirizados[m].Data_nascimento);
                    Console.WriteLine("CPF: " + terceirizados[m].cpf);
                    Console.WriteLine("CNPJ: " + terceirizados[m].cnpj);
                    Console.WriteLine();
                    }
                }
                
             if(gerentes.Count > 0)
              {
                Console.WriteLine();
                Console.WriteLine("Gerentes");
                Console.WriteLine();

                for (int n = 0; n < gerentes.Count; n++)
                {
                    double valeAlimentacaoGerente = gerentes[n].valor_vale_alimentacao();

                    Console.WriteLine("Nome" + gerentes[n].Nome);
                    Console.WriteLine("Matrícula: " + gerentes[n].Matricula);
                    Console.WriteLine("Data de nascimento: " + gerentes[n].Data_nascimento);
                    Console.WriteLine("CPF: " + gerentes[n].cpf);
                    Console.WriteLine("Salário: " + gerentes[n].Salario());
                    Console.WriteLine("Área de atuação: " + gerentes[n].AreaAtuacao);
                    Console.WriteLine("Vale Alimentação: " + valeAlimentacaoGerente);
                    Console.WriteLine();
                    
                    despesa_da_empresa += gerentes[n].Salario() + valeAlimentacaoGerente;
                }
               }

             if(trabalhadores.Count > 0)
             {
                Console.WriteLine();
                Console.WriteLine("Trabalhadores");
                Console.WriteLine();

                for (int o = 0; o < trabalhadores.Count; o++)
                {
                    double valeAlimentacaoTrabalhador = trabalhadores[o].valor_vale_alimentacao();
                    Console.WriteLine("Name: " + trabalhadores[o].Nome);
                    Console.WriteLine("Matrícula: " + trabalhadores[o].Matricula);
                    Console.WriteLine("Data Nascimento: " + trabalhadores[o].Data_nascimento);
                    Console.WriteLine("CPF : " + trabalhadores[o].cpf);
                    Console.WriteLine("Salário: " + trabalhadores[o].Salario());
                    Console.WriteLine("Vale alimentação: " + valeAlimentacaoTrabalhador);
                    Console.WriteLine();

                    despesa_da_empresa += trabalhadores[o].Salario() + trabalhadores[o].valor_vale_alimentacao();
                }
             }

                Console.WriteLine();
                Console.WriteLine("Despesa da empresa com o salário mensal dos seus funcionários: " + despesa_da_empresa);
            }
            
        }
    }

