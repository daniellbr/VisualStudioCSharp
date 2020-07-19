using System;

namespace ByteBank
{
    /// <summary>
    /// Define uma Conta Corrente para o Banco ByteBank
    /// </summary>
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
                
        public int Agencia {get;}
                
        public int NumeroConta {get;}

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        /// <summary>
        ///    Cria a instância de ContaCorrente com os argumentos utilizados no parâmetros de entrada
        /// </summary>
        /// <param name="agencia"> Representa o valor da propriedade <see cref="Agencia"/> e deve possuir um valor maior que zero.</param>
        /// <param name="numeroConta">Representa o valor da propriedade <see cref="NumeroConta"/> e deve possuir um valor maior que zero.</param>
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
        /// <summary>
        /// Realiza o saque e atualiza o valor da propriedade <see cref="Saldo"/>
        /// </summary>
        /// <exception cref="SaldoInsuficienteException"> Exceção lançada quando o valor de <paramref name="valor"/> é maior que o valor da propriedade <see cref="Saldo" é insuficiente./></exception> 
        /// <exception cref="ArgumentException"> Exeção lançada quando um valor negativo é utilizado no <paramref name="valor"/></exception>
        /// <param name="valor"> Representa o valor do saque, deve ser maior que 0 e menor que o <see cref="Saldo"/></param>
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

        public override string ToString()
        {
            return $"Número {NumeroConta}, Agêcia {Agencia}, Saldo {Saldo}";
            //Esta  é uma maneira acima, é um pouco mais limpa para apresentar os valores sem ter a necessidade de concatenar.
            //return "Número " + NumeroConta + ", Agencia " + Agencia + " Saldo " + Saldo;
        }

        public override bool Equals(object obj)
        {
            ContaCorrente outraConta = obj as ContaCorrente;

            if (outraConta == null)
            {
                return false;
            }

            return outraConta.Agencia == Agencia && outraConta.NumeroConta == NumeroConta; //Como estamos retornando um bool não há necessidade de fazermos um IF
            
        }

    }
}