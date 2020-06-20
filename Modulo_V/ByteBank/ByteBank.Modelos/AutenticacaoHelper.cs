
namespace ByteBank.Modelos
{
    internal class AutenticacaoHelper
    {
        public bool ComparaSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaVerdadeira == senhaTentativa;
        }
    }
}
