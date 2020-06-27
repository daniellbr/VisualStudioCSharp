using ByteBank.Modelos;
using Humanizer;
using System;
using System.Runtime.InteropServices;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            string url = "www.byebanck.com.br/cambio/conversao/serach?moedaOrigem=real&moedaDestino=dolar";

            ExtratorDeArgumentosURL extrator = new ExtratorDeArgumentosURL(url);

            string testeRemocao = "primeiraParte&parteParaRemover";
            int buscaE = testeRemocao.IndexOf('&');

            string valorRemovido = testeRemocao.Remove(buscaE);

            Console.WriteLine(valorRemovido);
                       
            Console.ReadLine();


            //string palavra = "moedaOrigem=real&moedaDestino=dolar"; 
            //string novoArgumento = "moedaDestino";

            //int indiceInicioArgumento = palavra.IndexOf(novoArgumento);

            //int indiceTamanhoNovoArgumento = novoArgumento.Length;

            //string _arguementos = palavra.Substring(indiceInicioArgumento + indiceTamanhoNovoArgumento + 1);

            //Console.WriteLine(indiceInicioArgumento);
            //Console.WriteLine(indiceTamanhoNovoArgumento);
            //Console.WriteLine(_arguementos);
        








            string texto = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int ind = texto.IndexOf("Gustavo");
            string texto2 = texto.Substring(ind + 1);

            Console.WriteLine("tamanho " + texto.Length); //12
            Console.WriteLine("indice " + ind); //6
            Console.WriteLine(texto2); //Silva

            //TrataDataEHumanize();
            //TratamentoDeStringESubstring();
            Console.ReadLine();
        }
        static void TrataDataEHumanize()
        {
            DateTime dateEndPayment = new DateTime(2018, 4, 21);

            DateTime CurrentDate = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(32);

            string mensagem = "O valor é " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);
        }        

        static void TratamentoDeStringESubstring()
        {
            string url = "pagina?destino";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(url);
            string recebeSubstring = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(recebeSubstring);
        }
    }
}
