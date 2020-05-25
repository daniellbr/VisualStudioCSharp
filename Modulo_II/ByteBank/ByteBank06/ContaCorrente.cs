namespace ByteBank_06
{
    class ContaCorrente
    {      
        public Cliente Titular {get;set;}

        public int agencia;
        public int numeroConta;
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