using Humanizer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        public int _proximaPosicao;

        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public ListaDeContaCorrente(int capacidadeFinal, int capacidadeInicial = 5 )
        {
           // _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;

        }

        public void Adicionar(ContaCorrente item)
        {
            VerificaCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;            
            Console.WriteLine($"Adicionando o indice {_proximaPosicao}, na Agencia/Conta {item.Agencia}-{item.NumeroConta}");
            _proximaPosicao++;
        }

        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente itemAtual = _itens[i];
               // if (_itens[i] == item)   //Essa comparação não é valida pois compara o valor da referencia da variavel
               //                          //sendo assim nunca seriam igual pois cada uma aponta para um endereço na memoria
               if (itemAtual.Equals(item)) //Utilizando o método Equals, devemos sobrescrever a implementação padrão para a nossa implementação
                {                          
                    indiceItem = i;
                    break;
                }
            }

            //laço para deslocar o indice para esquerda e setar como nulo o ultimo registro valido
            for (int i = indiceItem; i < _proximaPosicao -1; i++)
            {
                _itens[i] = _itens[i + 1];
            }
            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente conta = _itens[i];
                Console.WriteLine($"Conta no indice {i}: numero {conta.Agencia} {conta.NumeroConta}");
            }
        }

        public void VerificaCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }
            Console.WriteLine("Lista aumentada");

            int novoTamanho = _itens.Length * 2;

            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;                
            }

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }
            _itens = novoArray;
        }
    }
}
