using ByteBank.Modelos;
using ByteBank.Sistema;

namespace ByteBank
{
    public class ParceiroComercial : IAutenticavel
    {
        private AutenticacaoHelper _autenticacaoHelper = new AutenticacaoHelper();
        
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {        
            return _autenticacaoHelper.ComparaSenhas(Senha, senha);
        }
    }
}
