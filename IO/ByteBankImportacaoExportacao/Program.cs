using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("escrevendoComAClasseFile.txt", "Teste123Teste!@4");

            Console.WriteLine("arquivoCriado");


            var bytesArqvuivo = File.ReadAllBytes("contas.txt");

            Console.WriteLine($"Arquivo contas.txt possui {bytesArqvuivo.Length}");

            Console.ReadLine();

            var texto = File.ReadAllText("contas.txt"); // tambem le todo o arquivo de uma vez retorna uma string

            var linhas = File.ReadAllLines("contas.txt"); //Le todo o arquivo fr uma vez

            Console.WriteLine(linhas.Length);

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }
            Console.ReadLine();


            Console.WriteLine("Digite uma frase!");

            var literal = Console.ReadLine();

            Console.WriteLine(literal);

            UsarStreamDeEntrada();
            GravandoArquivoBinario();
            LendoArquivoBinario();
            CriarCaminhoComWriter();
            TestaArquivoGravado();
            //CriarArquivo();

            Console.ReadLine();
        }
    }
}