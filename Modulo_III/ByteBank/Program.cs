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
            CalculaBonificacao();

            Console.ReadLine();
        }

        public static void CalculaBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            //Criando utilizando o polimorfismo pois a variavel criada pedro é do tipo Funcionário mas a variavel criada é do tipo Designer que herda as funcionalidades de funcionário
            Funcionario pedro = new Designer("132.445.889-20");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor("321.323.545-34");
            roberta.Nome = "Roberta";

            Funcionario igor = new Auxiliar("443.443.545-42");
            igor.Nome = "Igor";

            Funcionario camila = new GerenteDeConta("995.546.767-55");
            igor.Nome = "Camila";

            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("O total de bonificação deste mês foi: " + gerenciadorBonificacao.GetTotalBonificacao());

            Console.WriteLine("O maior salario da empresa é: " + Funcionario.MaiorSalario(pedro.Salario, roberta.Salario, igor.Salario));

        }











        // Comentado para fazer de uma maneira mais limpa pois assim está muito desorganizado


        //GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

        //Funcionario joao = new Funcionario(2000, "113.446.223-56");
        //joao.Nome = "Joao Francisco";                    
        //Console.WriteLine("total de funcionarios " + Funcionario.TotalDeFuncionarios);
        //Console.WriteLine("Salario inicial " + joao.Nome + ' ' + joao.Salario);
        ////joao.Salario = joao.Salario + joao.GetBonificacao();
        //gerenciador.Registrar(joao);
        //Console.WriteLine("Salario com bonificação " + joao.Nome + ' ' + joao.Salario);
        //Console.WriteLine();
        //Console.WriteLine("O total de bonificação até o momento é : " + gerenciador.GetTotalBonificacao());

        //Console.WriteLine();
        //Console.WriteLine();

        //Funcionario carlos = new Funcionario(1000, "522.556.665-20");            
        //carlos.Nome = "Carlos Delaviega";
        //Console.WriteLine("total de funcionarios " + Funcionario.TotalDeFuncionarios);                                   
        //Console.WriteLine("Salario inicial " + carlos.Nome + ' ' + carlos.Salario);            
        ////carlos.Salario = carlos.Salario + carlos.GetBonificacao();
        //gerenciador.Registrar(carlos);
        //Console.WriteLine("Salario com bonificação " + carlos.Nome + ' ' + carlos.Salario);
        //carlos.AumentarSalario();
        //Console.WriteLine("Salario após aumento salario" + carlos.Nome + ' ' + carlos.Salario);
        //Console.WriteLine();
        //Console.WriteLine("O total de bonificação até o momento é : " + gerenciador.GetTotalBonificacao());

        //Console.WriteLine();
        //Console.WriteLine();

        //Diretor roberta = new Diretor(5000, "444.535.564 - 20");
        //roberta.Nome = "Roberta";            
        //Console.WriteLine("total de funcionarios " + Funcionario.TotalDeFuncionarios);
        //Console.WriteLine("Salario inicial " + roberta.Nome + roberta.Salario);            
        //gerenciador.Registrar(roberta);
        //Console.WriteLine("Salario com bonificação " + roberta.Nome + ' ' + roberta.Salario);
        //roberta.AumentarSalario();
        //Console.WriteLine("Salario após o aumento " + roberta.Nome + roberta.Salario);

        //Console.WriteLine();
        //Console.WriteLine("O total de bonificação até o momento é : " + gerenciador.GetTotalBonificacao());

        //Console.WriteLine();
        //Console.WriteLine();

        //Console.WriteLine("O maior salário é " + Funcionario.MaiorSalario(joao.Salario, carlos.Salario, roberta.Salario));


    }
}
