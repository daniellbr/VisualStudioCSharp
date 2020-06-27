
using System;
using System.Dynamic;
using System.Security.AccessControl;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorDeArgumentosURL
    {
        public readonly string _arguementos;
        public string Url { get; }

        /// <summary>
        /// Metodo generico para extrair os argumentos dada uma URL 
        /// </summary>
        /// <param name="url">Com este parametro, vamos extrair os argumentos, a URL não pode ser vazia nem nula <paramref name="url"/> "/>"/></param>
        public ExtratorDeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O arqgumento não pode ser nulo ou vazio.", nameof(url));
            }

            int indiceInterrogacao = url.IndexOf('?');

            _arguementos = url.Substring(indiceInterrogacao + 1);
                              

            Url = url;
        }

        /// <summary>
        ///  Método para extrair o valor do argumento de uma URL seguindo a logica de <nome>=valor
        /// </summary>
        /// <param name="nomeParametro"></param>
        /// <returns></returns>
        public string GetValor(string nomeParametro)
        {
            string argumentoEmCaixaAlta = _arguementos.ToUpper(); //Deixa a string em caixa alta para normalizar a pesquisa

            //string palavra = "moedaOrigem=real&moedaDestino=dolar"; exemplo dq pode vir            
            string termo = nomeParametro + '=';

            int indiceInicioArgumento = argumentoEmCaixaAlta.IndexOf(termo);
                        
            string resultado = _arguementos.Substring(indiceInicioArgumento + termo.Length);

            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceEComercial);
        }
    }
}
