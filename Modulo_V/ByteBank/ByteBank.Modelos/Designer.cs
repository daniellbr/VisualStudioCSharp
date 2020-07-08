using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(3000, cpf)
        {

        }
        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override string ToString()
        {
           return "Eu sou um designer e não ganho muito, meu salário é 3000 e meu cpf é " + CPF;
        }
    }
}
