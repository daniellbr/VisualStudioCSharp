using ByteBank.Modelos;
using ByteBank.Sistema;

namespace ByteBank.Funcionarios
{
   public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();


        public string Senha { get; set; }
        public FuncionarioAutenticavel(double salario, string cpf) : base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return _autenticacaoHelper.ComparaSenhas(Senha, senha);
        }

    }
}
