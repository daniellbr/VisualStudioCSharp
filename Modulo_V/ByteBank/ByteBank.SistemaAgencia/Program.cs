using Humanizer;
using System;
using System.Text.RegularExpressions;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
       static void Main(string[] args)
        {

            
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.Adicionar(new ContaCorrente(121, 545454));
            lista.Adicionar(new ContaCorrente(121, 545323));
            lista.Adicionar(new ContaCorrente(121, 546564));
            lista.Adicionar(new ContaCorrente(121, 545671));
            lista.Adicionar(new ContaCorrente(121, 545672));
            lista.Adicionar(new ContaCorrente(121, 545673));
            lista.Adicionar(new ContaCorrente(121, 545674));
            lista.Adicionar(new ContaCorrente(121, 545675));
            lista.Adicionar(new ContaCorrente(121, 545676));
            lista.Adicionar(new ContaCorrente(121, 545677));
            lista.Adicionar(new ContaCorrente(121, 545678));
            lista.Adicionar(new ContaCorrente(121, 545679));
            lista.Adicionar(new ContaCorrente(121, 545610));
            lista.Adicionar(new ContaCorrente(121, 545611));



            Console.ReadLine();
        }

        public static void TestaString()
        {
            string padrao5 = "[012345679][012345679][012345679][012345679][-][012345679][012345679][012345679][012345679]";
            string padrao4 = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"; //Esse padrão o .net reconhece tb pois ele procura dentro do range 0-9
            string padrao3 = "[0-9]{4} [-] [0-9]{4}"; //Esse padrão tb funcina pq ele diz que esse array vai acontecer por 4 vezes
            string padrao2 = "[0-9]{4,5} [-] [0-9]{4}"; //Desta maneira ele aceita 4 ou 5 caracteres 
            string padrao1 = "[0-9]{4,5} [-]{0,1} [0-9]{4}"; //Desta maneira ele aceita 4 ou 5 caracteres para o telefone e também aceita sem o ifem e com o ifem
            string padrao = "[0-9]{4,5}-?[0-9]{4}"; //Assim fica ainda mais enxuto o código por ser somente um carcter e aceitar 0 e 1 pode-se colocar a ?

            string textoDeTeste = "Eu tenho um telefone cujo o número é 4599-5509";

            Console.WriteLine(Regex.IsMatch(textoDeTeste, padrao));

            Match resultado = Regex.Match(textoDeTeste, padrao);

            Console.WriteLine(resultado);

            Console.ReadLine();


            string endereco = "R. São Carlos do Pinhal nº746";
            string enderecoFormatado = endereco.ToUpper().Replace("r.", "Rua").Replace(" nº", ", Número ").ToUpper();

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
            string texto = "pagina?moedaOrigem=real&moedaDestino=dolar";

            int ind = texto.IndexOf("Gustavo");
            string texto2 = texto.Substring(ind + 1);

            Console.WriteLine("tamanho " + texto.Length); //12
            Console.WriteLine("indice " + ind); //6
            Console.WriteLine(texto2); //Silv

            //string palavra = "moedaOrigem=real&moedaDestino=dolar"; 
            //string novoArgumento = "moedaDestino";

            //int indiceInicioArgumento = palavra.IndexOf(novoArgumento);

            //int indiceTamanhoNovoArgumento = novoArgumento.Length;

            //string _arguementos = palavra.Substring(indiceInicioArgumento + indiceTamanhoNovoArgumento + 1);

            //Console.WriteLine(indiceInicioArgumento);
            //Console.WriteLine(indiceTamanhoNovoArgumento);
            //Console.WriteLine(_arguementos);

        }
        static void TrataDataEHumanize()
        {
            DateTime dateEndPayment = new DateTime(2018, 4, 21);

            object data = new DateTime(2222, 4, 21);
            DateTime CurrentDate = DateTime.Now;

            TimeSpan diferenca = TimeSpan.FromMinutes(32);

            string mensagem = "O valor é " + TimeSpanHumanizeExtensions.Humanize(diferenca);

            Console.WriteLine(mensagem);
            Console.WriteLine();
        }        

        static void TratamentoDeStringESubstring()
        {
            string url = "pagina?destino";

            int indiceInterrogacao = url.IndexOf('?');

            Console.WriteLine(url);
            string recebeSubstring = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(recebeSubstring);
        }

        static void EqualsToString()
        {

            Cliente joao = new Cliente();
            joao.Profissao = "Carteiro";
            joao.Nome = "João";
            joao.CPF = "21212121";

            Cliente joao2 = new Cliente();
            joao2.Profissao = "Carteiro";
            joao2.Nome = "João";
            joao2.CPF = "21212121";

            ContaCorrente conta2 = new ContaCorrente(343, 43466);

            if (joao.Equals(conta2))
            {
                Console.WriteLine("São iguais");
            }
            else
            {
                Console.WriteLine("Não são iguais");
            }

            Cliente cliente = new Cliente();
            object conta = new ContaCorrente(223, 434343);
            object designer = new Designer("545065");
            object desenv = new Desenvolvedor("34343");
            Console.WriteLine(cliente);
            Console.WriteLine(conta);
            Console.WriteLine(designer);
            Console.WriteLine(desenv);

            //TestaString();
            //TrataDataEHumanize();
            //TratamentoDeStringESubstring();
        }

        static void TestaArray()
        {

            int[] idades = new int[5];

            idades[0] = 10;
            idades[1] = 12;
            idades[2] = 15;
            idades[3] = 17;
            idades[4] = 19;

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];
                acumulador += idade;

                Console.WriteLine($"O valor da idade é {idade}, no indice  {indice}");
            }

            Console.WriteLine($"A média de idade é {acumulador / idades.Length}");
                                   
            Console.ReadLine();

        }

    }
}
