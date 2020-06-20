using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistema
{
    class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {

            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Ususario logado bem vindo!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta, tente novamente!");
                return false;
            }
        }            
    }
}
