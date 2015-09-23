using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12_3__trimestre_sem_herança
{
    class classgerente
    {
        public double Salario { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Matricula { get; set; }

        public string CPF { get; set; }

        public string áreaGenciada { get; set; }

        public double Adicional { get; set; }

        public double SalarioTotal()
        {
            return Salario + Adicional;
        }
    }
}