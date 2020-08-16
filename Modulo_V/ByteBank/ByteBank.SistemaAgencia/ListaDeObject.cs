using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeObject
    {
        private object[] _itens;
        public int _proximaPosicao;

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }
        public ListaDeObject(int capacidadeInicial = 5)
        {
            _itens = new object[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public ListaDeObject(int capacidadeFinal, int capacidadeInicial = 5)
        {
            _proximaPosicao = 0;
        }

        public void Adicionar(object item)
        {
            VerificaCapacidade(_proximaPosicao + 1);
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void AdicionarVarios(params object[] items)
        {
            foreach (object item in items)
            {
                Adicionar(item);
            }
        }


        public void Remover(object item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                object itemAtual = _itens[i];
                // if (_itens[i] == item)   //Essa comparação não é valida pois compara o valor da referencia da variavel
                //                          //sendo assim nunca seriam igual pois cada uma aponta para um endereço na memoria
                if (itemAtual.Equals(item)) //Utilizando o método Equals, devemos sobrescrever a implementação padrão para a nossa implementação
                {
                    indiceItem = i;
                    break;
                }
            }

            //laço para deslocar o indice para esquerda e setar como nulo o ultimo registro valido
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
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
                object conta = _itens[i];
              //  Console.WriteLine($"Conta no indice {i}: numero {conta.Agencia} {conta.NumeroConta}");
            }
        }

        public object GetItemNoIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return _itens[indice];
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

            object[] novoArray = new object[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
            }
            _itens = novoArray;
        }

        public object this[int indice]
        {
            get
            {
                return GetItemNoIndice(indice);
            }
        }
    }
}

