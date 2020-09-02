using System;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void LidandoComStreamManualOuDiretamente()
        {
            var enderecoDoArquivo = "contas.txt"; //Este conta.txt é um endereço relativo onde relativo sobre o arquivo executado que está na pasta bin debug

            using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open)) //Utilizando o Using o fechamento do arquivo é implicito pela chamada
            {
                var buffer = new byte[1024]; // 1kb

                int numeroDeBytesLidos = -1;

                while (numeroDeBytesLidos != 0)
                {
                    numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, numeroDeBytesLidos);
                }

            }

            static void EscreverBuffer(byte[] buffer, int bytesLidos)
            {
                var utf8 = new UTF8Encoding();

                var texto = utf8.GetString(buffer, 0, bytesLidos);

                Console.Write(texto);                

                //foreach (var meuByte in buffer)
                //{
                //    Console.Write(meuByte);
                //    Console.Write(" ");
                //}
            }
        }
    }
}
