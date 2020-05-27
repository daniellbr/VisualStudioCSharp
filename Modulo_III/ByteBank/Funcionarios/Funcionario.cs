using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string  CPF { get; set; }
        public double Salario { get; set; }


        public double GetBonificacao()
        {
            return Salario * 0.10;
        }      
            
        public double MaiorSalario(double a, double b, double c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }
}
