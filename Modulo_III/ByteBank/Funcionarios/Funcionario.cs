using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string  CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {
            TotalDeFuncionarios++;

           // CPF = cpf;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }      
            
        public static double MaiorSalario(double a, double b, double c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }
}
