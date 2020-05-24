namespace ByteBank_06
{
    class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numeroConta;
        private double saldo = 100;

        public void SetSaldo(double saldo)
        {
            if (saldo < 0)
                return;
            this.saldo += saldo;
        }

        public double GetSalto()
        {
            return this.saldo;
        }


        public bool Sacar(double valor)
        {
            if (this.saldo <= valor)
                return false;

            this.saldo -= valor;
            return true;
        }

        public string Depositar(double valor)
        {
            this.saldo += valor;
            return "Deposito efetuado com Sucesso de " + valor + ". Seu saldo agora é : " + this.saldo;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo <= valor)
                return false;

            this.Sacar(valor);
            contaDestino.Depositar(valor);
            return true;

        }

    }
}