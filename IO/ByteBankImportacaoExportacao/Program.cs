using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            GravandoArquivoBinario();
            LendoArquivoBinario();
            CriarCaminhoComWriter();
            TestaArquivoGravado();
            //CriarArquivo();

            Console.ReadLine();
        }
    }
}