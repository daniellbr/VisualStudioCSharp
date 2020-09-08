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
        static void GravandoArquivoBinario()
        {
            var enderecoArquivoBinario = "arquivoBinario.txt";

            using (var fluxoDoArquivo = new FileStream(enderecoArquivoBinario, FileMode.Create))
            using (var escritor = new BinaryWriter(fluxoDoArquivo))
            {
                escritor.Write(343);
                escritor.Write(44321);
                escritor.Write(3322.33);
                escritor.Write("Joao da Silva");
                Console.WriteLine();
            }
        }

        static void LendoArquivoBinario()
        {
            using (var fs = new FileStream("arquivoBinario.txt", FileMode.Open))
            using (var leitor = new BinaryReader(fs))
            {
                var agencia = leitor.ReadInt32();
                var conta = leitor.ReadInt32();
                var valor = leitor.ReadDouble();
                var nome = leitor.ReadString();

                Console.WriteLine($" {agencia},{conta},{valor},{nome}");
            }
        }
    }
}
