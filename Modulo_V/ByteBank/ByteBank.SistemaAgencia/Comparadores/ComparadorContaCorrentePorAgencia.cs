using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ByteBank.SistemaAgencia.Comparadores
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            if (x == y)
            {
                return 0;
            }

            if (x == null)
            {
                return 1;
            }

            if (y == null)
            {
                return -1;
            }

            return x.Agencia.CompareTo(y.Agencia);

            //Existe este tipo de comparacao no Int e também no String
            //Este tipo de comparacao já existe embarcado no proprio .NET não sendo necessário refaze-lo
            //sendo assim a comparação abaixo não é necessária
            //if (x.Agencia < y.Agencia)
            //{
            //    return -1;  //x fica na frente de y
            //}
            //if (x.Agencia == y.Agencia)
            //{
            //    return 0; // são equivalentes
            //}
            //return 1; // y fica na frente de x
        }
    }
}
