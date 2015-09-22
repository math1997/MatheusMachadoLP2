using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
namespace exercicio_6_lista_1
{
    class program
    {
        string Rival = "";
        string PTCP;
        int alt;
        ArrayList Participantes = new ArrayList();
        ArrayList Estaturas = new ArrayList();
        ArrayList BiggestEstaturas = new ArrayList();

        public void informaDados()
        {

            int i = 0;

            Console.WriteLine("Entre com a mensagem 'FIM' no campo nome para parar a leitura dos nomes");

            while (Rival != "FIM")
            {
                Console.WriteLine("Entre com o nome: ");
                Rival = Convert.ToString(Console.ReadLine());

                PTCP = Rival;

                if (Rival != "FIM")
                {
                    Console.WriteLine("informe a altura desta concorrente(em cm): ");
                    alt = int.Parse(Console.ReadLine());

                    Participantes.Add(PTCP);
                    Estaturas.Add(alt);

                }

                i++;

            }

            BiggestEstaturas.Add(0);
            BiggestEstaturas.Add(0);
            int q = 1;
            int w = 1;

            for (int u = 0; u < Estaturas.Count; u++)
            {
                if (Convert.ToDouble(Estaturas[u]) >= Convert.ToDouble(BiggestEstaturas[0]))
                {
                    if (Convert.ToDouble(Estaturas[u]) == Convert.ToDouble(BiggestEstaturas[0]))
                    {
                        q++;
                    }
                    BiggestEstaturas[0] = Estaturas[u];
                }

                else if (Convert.ToDouble(Estaturas[u]) >= Convert.ToDouble(BiggestEstaturas[1]))
                {
                    if (Convert.ToDouble(Estaturas[u]) == Convert.ToDouble(BiggestEstaturas[1]))
                    {
                        w++;
                    }
                    BiggestEstaturas[1] = Estaturas[u];
                }
            }



            
           Console.WriteLine("A segunda maior estatura foi: " + BiggestEstaturas[1] + " Quantidade de participantes com essa altura: " + w);
            Console.WriteLine("A maior estatura  foi: " + BiggestEstaturas[0] + " Quantidade de participantes com essa altura: " + q);

        }
    }
}
