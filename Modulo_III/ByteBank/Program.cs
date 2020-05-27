using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario carlos = new Funcionario();            
            carlos.Nome = "Carlos Pedro Delaviega";            
            carlos.Salario = 1000;            
            carlos.CPF = "522.556.665-20";


            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;
            roberta.CPF = "444.535.564-20";


            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
                       
            Console.WriteLine(carlos.Salario);            
            carlos.Salario = carlos.Salario + carlos.GetBonificacao();
            gerenciador.Registrar(carlos);
            Console.WriteLine(carlos.Salario);
            Console.WriteLine("O total de bonificação até o momento é : " + gerenciador.GetTotalBonificacao());

            Console.WriteLine(roberta.Salario);
            roberta.Salario = roberta.Salario + roberta.GetBonificacao();            
            gerenciador.Registrar(roberta);
            Console.WriteLine(roberta.Salario);

            Console.WriteLine("O total de bonificação até o momento é : " + gerenciador.GetTotalBonificacao());

            Console.WriteLine(carlos.MaiorSalario(1,2,3));

            Console.ReadLine();
        }
    }
}
