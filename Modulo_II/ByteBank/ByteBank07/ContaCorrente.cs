using ByteBank07;
using System;
using System.Runtime.InteropServices;

namespace ByteBank_07
{
    class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
                
        public int Agencia {get;}
                
        public int NumeroConta {get;}

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        //Construtor, esse construtor está fazendo uso dos geters e seters da agencia e conta, obrigatoriamente validando os campos para não serem inicializados zerados
        public ContaCorrente(int agencia, int numeroConta)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento Agencia deve ser maior que zero.", nameof(agencia));
            }

            if (numeroConta <= 0)
            {
                throw new ArgumentException("O argumento Numero da Conta deve ser maior que zero.", nameof(numeroConta));
            }

            Agencia = agencia;
            NumeroConta = numeroConta;

            TotalDeContasCriadas++;

            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return this._saldo;
            }
            set
            {
                if (value < 0)
                    return;

                this._saldo = value;
            }
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                ContadorSaquesNaoPermitidos++;
                throw new ArgumentException("Valor Invalido para efetuar o saque." + nameof(valor));
            }

            if (this._saldo < valor)
            {
                throw new SaldoInsuficienteException(_saldo, valor);
            }            

            this._saldo -= valor;
            
        }

        public string Depositar(double valor)
        {
            this._saldo += valor;
            return "Deposito efetuado com Sucesso de " + valor + ". Seu saldo agora é : " + this._saldo;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor Invalido para efetuar a transferência." + nameof(valor));
            }

            try
            {
                this.Sacar(valor);  
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorSaquesNaoPermitidos++;
                throw new Exception("Transferencia não permitida!", ex);
            }

            contaDestino.Depositar(valor);
        }

        public static void Metodo()
        {
            TestaDivisao(0);
        }
        public static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
        public static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }
    }
}