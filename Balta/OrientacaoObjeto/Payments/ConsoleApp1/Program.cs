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
        }
    }

    class Pagamento
    {
        //Propriedades
        public DateTime Vencimento;

        //Métodos ou funções do objeto
        public void Pagar()
        {

        }
       
    }

    class PagamentoBoleto : Pagamento
    {
        public string DadosBoleto;
    }

    class PagamentoCartao : Pagamento
    {
        public string DadosCartao;
    }


}
