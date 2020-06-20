using System;

namespace ByteBank
{
   public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(double saldo, double valoSaque) 
            :this("Tentativa de saque no valor de " + valoSaque + " em uma conta com o saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valoSaque;            
        }

        public SaldoInsuficienteException(string message) :base(message)
        {

        }

        public SaldoInsuficienteException(string mensagem, Exception excecaoInterna) 
            : base(mensagem, excecaoInterna)
        {

        }
    }
}
