using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var linhaArquivo = "2345,443344,324521.23,João das Almas";

                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(linhaArquivo);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            }

        }

        static void CriarCaminhoComWriter()
        {
            var camihoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(camihoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8))
            {
                escritor.Write("3232,44334,443.43,Jose");
            }
        }

        static void TestaArquivoGravado()
        {
            var caminhoNovoArquivo = "arquivoNovo.csv";
            using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDoArquivo, Encoding.UTF8))
            {
                for (int i = 0; i < 1000; i++)
                {
                    escritor.WriteLine($"Linha {i}");

                    escritor.Flush(); //grava o arquivo no modo fisico e não somente no buffer

                    Console.WriteLine($"Linha {i} foi gravada no arquivo!");
                    Console.ReadLine();
                }
            }
        }
    }
}
