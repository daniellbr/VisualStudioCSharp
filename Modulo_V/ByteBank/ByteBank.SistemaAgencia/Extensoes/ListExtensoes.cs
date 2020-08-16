using System.Collections.Generic;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        static void TestaListaGenerica()
        {
            List<int> idades = new List<int>();

            idades.Add(12);
            idades.Add(43);
            idades.Add(12);
            
            idades.AdicionarVarios<int>(23, 54, 12, 65, 786, 89);

           // ListExtensoes<int>.AdicionarVarios(idades, 43, 43, 657, 2, 4365, 76);

            List<string> nome = new List<string>();

            nome.Add("Codorna");
            nome.AdicionarVarios("Joao", "Maria", "Pedro", "Paulo");
           // ListExtensoes<string>.AdicionarVarios(nome, "carla, Pedro, Paulo");


        }


    }
}
