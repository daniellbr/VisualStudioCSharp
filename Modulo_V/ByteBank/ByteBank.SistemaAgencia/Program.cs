using ByteBank.Modelos;
using Humanizer;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {


            string padrao = "[012345679][012345679][012345679][012345679][-][012345679][012345679][012345679][012345679]";

            string textoDeTeste = "Eu tenho um telefone cujo o número é 4599-5509";

            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado);

            Console.ReadLine();


            string endereco = "R. São Carlos do Pinhal nº746";
            string enderecoFormatado = endereco.ToUpper() .Replace("r.", "Rua") .Replace(" nº", ", Número ") .ToUpper();

            Console.WriteLine(enderecoFormatado);






            string urlByteBank = "https://www.bybtebank.com.br/cambio";

            Console.WriteLine(urlByteBank.StartsWith("https://www.bybtebank.com.br"));
            Console.WriteLine(urlByteBank.EndsWith("/cambio."));

            Console.WriteLine(urlByteBank.Contains("ank."));



            Console.ReadLine();



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
