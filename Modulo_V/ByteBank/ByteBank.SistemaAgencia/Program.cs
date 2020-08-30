using Humanizer;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ByteBank.SistemaAgencia.Extensoes;
using ByteBank.SistemaAgencia.Comparadores;
using System.Linq;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
       static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente (341, 45343),
                null,
                new ContaCorrente (344, 43465),
                null,
                new ContaCorrente (919, 23234),
                new ContaCorrente (010, 23233),
                null
            };

            //Validação de contas nulas e classificação em uma unica expressão
            //É possivel devido tanto ao Where quanto o OrderBy retornarem u
            var contasOrdenadas = contas.
                Where(conta => conta !=null).
                OrderBy(conta => conta.NumeroConta);

            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine($"Conta número {conta.NumeroConta}, Agência {conta.Agencia}");

            }


            //contas.Sort(); --> Chama a implementação que criamos no IComparable

            // contas.Sort(new ComparadorContaCorrentePorAgencia()); --> Chama a função ICompare

            //IOrderedEnumerable<ContaCorrente> contaOrdenada =
            //    contas.OrderBy(conta =>
            //    {
            //        if (conta == null)
            //        {
            //            return int.MaxValue;
            //        }
            //        return conta.NumeroConta;
            //    });
            //foreach (var conta in contaOrdenada)
            //{
            //    if (conta != null)
            //    {
            //        Console.WriteLine($"Agencia {conta.Agencia} e conta {conta.NumeroConta}");
            //    } else
            //    { 
            //        Console.WriteLine("Conta nula"); 
            //    };
            //}

            var meses = new List<string>() { "JANEIRO", "FEVEREIRO", "MARCO", "ABRIL", "MARIO", "JUNHO", "JULHO", "AGOSTO", "SETEMBRO", "OUTUBRO", "NOVEMBRO", "DEZEMBRO" };

            Console.WriteLine($"Meses do ano { meses}");
                      
            var mesesOrdenados = meses.OrderBy(mes => mes);

            Console.WriteLine($"Meses do ano ordenado: { mesesOrdenados}"); 

            Console.ReadLine();
        }

        public static void TestaSort()
        {
            var idades = new List<int>();

            idades.Add(5);
            idades.Add(12);
            idades.Add(12);
            idades.Add(45);
            idades.Remove(45);

            idades.AdicionarVarios(3, 45, 6, 8, 89, 4, 2, 2);

            idades.Sort();

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }

            var nomes = new List<string>()
            {
                "joao",
                "Pedro",
                "Paulo",
                "Ana"
            };

            nomes.Sort();

            foreach (var nome in nomes)
            {

                Console.WriteLine(nome);
            }

        }
        public static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(23);
            listaDeIdades.Adicionar(44);
            listaDeIdades.AdicionarVarios(43, 54, 45, 33);


            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice{i}: idade [idade]");
            }


            ListaDeContaCorrente lista = new ListaDeContaCorrente(capacidadeInicial: 0);
            ContaCorrente contaTeste = new ContaCorrente(33333, 4343343);


            lista.AdicionarVarios(new ContaCorrente(323, 434533),
                                  new ContaCorrente(565, 877987),
                                  new ContaCorrente(121, 545323),
                                  new ContaCorrente(121, 111564),
                                                      contaTeste,
                                  new ContaCorrente(121, 545671),
                                  new ContaCorrente(121, 545672),
                                  new ContaCorrente(121, 545673),
                                  new ContaCorrente(121, 545674),
                                  new ContaCorrente(121, 545675),
                                  new ContaCorrente(121, 545676),
                                  new ContaCorrente(121, 545677),
                                  new ContaCorrente(121, 545678),
                                  new ContaCorrente(121, 545679),
                                  new ContaCorrente(121, 545610),
                                  new ContaCorrente(121, 545611));

            lista.Remover(contaTeste);

            lista.EscreverListaNaTela();
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

        public void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(334,4343553),
                new ContaCorrente(334,5454334),
                new ContaCorrente(334,4553432)
            };

            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente contaAtual = contas[i];
                Console.WriteLine($"Conta{i}: {contaAtual.NumeroConta}");
            }
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
