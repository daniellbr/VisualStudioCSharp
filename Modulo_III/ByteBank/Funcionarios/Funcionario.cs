using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; set; }
        public string  CPF { get; set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;

            CPF = cpf;

            Salario = salario;
        }

        public virtual double GetBonificacao()
        {
            return  Salario *= 1.10;
        }      

        public virtual void AumentarSalario()
        {
            Salario *= 1.10;
        }
            
        public static double MaiorSalario(double a, double b, double c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }
}
