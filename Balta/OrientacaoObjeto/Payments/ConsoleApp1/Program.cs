using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.DadosBoleto = "Pago";
            pagamentoBoleto.Pagar();

            var pagamentoCartao = new PagamentoCartao();
            pagamentoCartao.DadosCartao = "Cartao Black";
            pagamentoCartao.Vencimento = DateTime.Now;
            pagamentoCartao.Pagar();

            var pagamento = new Pagamento();
            pagamento.Vencimento = DateTime.Now;
            pagamento.Pagar();


            var pagamentoPoli = new pagamento();
            pa
        }
    }

    class Pagamento
    {
        //Propriedades
        public DateTime Vencimento;

        //Métodos ou funções do objeto
        public virtual void Pagar()
        {

        }

        public override string ToString()
        {
            return "Vencimento.ToString("dd,mm,aaaa");
        }
       
    }

    class PagamentoBoleto : Pagamento
    {
        public string DadosBoleto;

        public override void Pagar()
        {
            //Regra para o pagamento do boleto
        }
    }

    class PagamentoCartao : Pagamento
    {
        public string DadosCartao;

        public override void Pagar()
        {
            //Regra para o pgamento do Cartão
        }
    }


}
