using ByteBank.Funcionarios;

namespace ByteBank
{
    class Diretor : FuncionarioAutenticavel
    {        
        public Diretor(string cpf) : base(5000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        internal protected override double GetBonificacao()
        {
            return Salario * 0.5;
        }

    }
}
