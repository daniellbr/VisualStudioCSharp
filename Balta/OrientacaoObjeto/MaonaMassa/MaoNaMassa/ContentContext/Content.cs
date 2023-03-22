using System;

namespace MaoNaMassa.ContentContext
{
    //Content ou conteudo por ser uma classe abstrata, não podemos instanciar uma classe
    //E sim ela somente pode ser herdada, logo vamos torna-la abstrata
    public abstract class Content
    {
        public Content()
        {
            Id = Guid.NewGuid(); //Cria um GUID novo um valor de 36 caracteres                 
                                 //Id = new Guid(); Cria um id do tipo Guid porém zerado
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}