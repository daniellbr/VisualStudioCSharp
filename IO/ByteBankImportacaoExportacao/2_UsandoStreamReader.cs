using System;
using System.IO;

namespace ByteBankImportacaoExportacao.Modelos
{
    partial class Program
    {
        static void UsarStreamReader()
        {
            var enderecoDoArquivo = "contas.txt";

            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine(); // Retorna uma linha por vez
                    var contaCorrente = ConverterStringParaContaCorrente(linha);
                    var msg = $"Nome Cliente {contaCorrente.Titular.Nome}, Número Agencia {contaCorrente.Agencia}, Número Conta {contaCorrente.Numero}, e Saldo {contaCorrente.Saldo}";
                    Console.WriteLine(msg);
                    //Console.WriteLine(linha);
                }
            };
            // var linha = leitor.ReadLine();  // Retorna um unico Byte
            // var linha = leitor.ReadToEnd(); // Retorna todo array de String até o final *** Cuidado com este ***
            // Sempre que utilizarmos a interface Idisposable não esquecer de implementar a diretiva Using
            Console.ReadLine();
        }
        static ContaCorrente ConverterStringParaContaCorrente(string linhas)
        {
            var campos = linhas.Split(',');

            var agencia = campos[0];
            var numeroConta = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nome = campos[3];

            var agenciaInt = int.Parse(agencia);
            var numeroContaInt = int.Parse(numeroConta);
            var SaldoDouble = double.Parse(saldo);

            var resultado = new ContaCorrente(agenciaInt, numeroContaInt);
            resultado.Depositar(SaldoDouble);
            var cliente = new Cliente();
            cliente.Nome = nome;
            resultado.Titular = cliente;

            return resultado;

        }
    }

}
