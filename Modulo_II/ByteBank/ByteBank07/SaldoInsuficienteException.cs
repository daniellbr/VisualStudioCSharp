using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank07
{
   public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException(double saldo, double valoSaque) 
            :this("Tentativa de saque no valor de " + valoSaque + " em uma conta com o saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valoSaque;            
        }

        public SaldoInsuficienteException()
        {

        }

        public SaldoInsuficienteException(string message) :base(message)
        {

        }
    }
}
