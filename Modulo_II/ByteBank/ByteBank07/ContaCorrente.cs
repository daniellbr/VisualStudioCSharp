using System.Runtime.InteropServices;

namespace ByteBank_07
{
    class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }

            set
            {
                if (value <= 0)
                    return;

                _agencia = value;
            }
        }

        //Construtor, esse construtor está fazendo uso dos geters e seters da agencia e conta, obrigatoriamente validando os campos para não serem inicializados zerados
        public ContaCorrente(int agencia, int numeroConta)
        {
            Agencia = agencia;
            NumeroConta = numeroConta;

            TotalDeContasCriadas++;
        }

        private int _numeroConta;
        public int NumeroConta
        {
            get
            {
                return _numeroConta;
            }
            set
            {
                if (value <= 0)
                    return;

                _numeroConta = value;

            }
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

        public bool Sacar(double valor)
        {
            if (this._saldo <= valor)
                return false;

            this._saldo -= valor;
            return true;
        }

        public string Depositar(double valor)
        {
            this._saldo += valor;
            return "Deposito efetuado com Sucesso de " + valor + ". Seu saldo agora é : " + this._saldo;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo <= valor)
                return false;

            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;

        }

    }
}