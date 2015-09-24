using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12_3__trimestre_sem_herança
{
    class classgerente : funcionariosdaempresaClass1
    {
        funcionariosdaempresaClass1 f = new funcionariosdaempresaClass1();
        private string Data_nascimento;

       

        private string Matricula;

       

        private string Nome;

        

        private string cpf;

        
        private string _area_atuacao;

        public string AreaAtuacao { get; set; }

        public override double Salario()
        {
            double sal = f.Salario() + 4000;
            return sal;
        }

        public override double valor_vale_alimentacao()
        {
            double valeAlimentacao = Salario() * 0.08;
            
            if (valeAlimentacao > 750)
            {
                valeAlimentacao = 750;
            }

            return valeAlimentacao;
        }
    }
}

        
