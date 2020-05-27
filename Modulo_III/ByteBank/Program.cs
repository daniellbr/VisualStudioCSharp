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
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario joao = new Funcionario();
            joao.Nome = "Joao Francisco";
            joao.Salario = 2000;
            joao.CPF = "113.446.223-56";
            Console.WriteLine("total de funcionarios " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine("Salario inicial " + joao.Nome + ' ' + joao.Salario);
            joao.Salario = joao.Salario + joao.GetBonificacao();
            gerenciador.Registrar(joao);
            Console.WriteLine("Salario com bonificação " + joao.Nome + ' ' + joao.Salario);
            Console.WriteLine();
            Console.WriteLine("O total de bonificação até o momento é : " + gerenciador.GetTotalBonificacao());

            Console.WriteLine();
            Console.WriteLine();

            Funcionario carlos = new Funcionario();            
            carlos.Nome = "Carlos Delaviega";            
            carlos.Salario = 1000;            
            carlos.CPF = "522.556.665-20";
            Console.WriteLine("total de funcionarios " + Funcionario.TotalDeFuncionarios);                                   
            Console.WriteLine("Salario inicial " + carlos.Nome + ' ' + carlos.Salario);            
            carlos.Salario = carlos.Salario + carlos.GetBonificacao();
            gerenciador.Registrar(carlos);
            Console.WriteLine("Salario com bonificação " + carlos.Nome + ' ' + carlos.Salario);
            Console.WriteLine();
            Console.WriteLine("O total de bonificação até o momento é : " + gerenciador.GetTotalBonificacao());
            
            Console.WriteLine();
            Console.WriteLine();

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.Salario = 5000;
            roberta.CPF = "444.535.564-20";
            Console.WriteLine("total de funcionarios " + Funcionario.TotalDeFuncionarios);
            Console.WriteLine("Salario inicial " + roberta.Nome + roberta.Salario);
            roberta.Salario = roberta.Salario + roberta.GetBonificacao();            
            gerenciador.Registrar(roberta);
            Console.WriteLine("Salario com bonificação " + roberta.Nome + ' ' + roberta.Salario);
            Console.WriteLine();
            Console.WriteLine("O total de bonificação até o momento é : " + gerenciador.GetTotalBonificacao());

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("O maior salário é " + Funcionario.MaiorSalario(joao.Salario, carlos.Salario, roberta.Salario));

            Console.ReadLine();
        }
    }
}
