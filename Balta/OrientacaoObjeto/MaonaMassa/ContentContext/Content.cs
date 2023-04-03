using System;
using MaoNaMassa.SharedContext;

namespace MaoNaMassa.ContentContext
{
    //Content ou conteudo por ser uma classe abstrata, não podemos instanciar uma classe
    //E sim ela somente pode ser herdada, logo vamos torna-la abstrata
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            Title = title;
            Url = url;
        }

        public string Title { get; set; }
        public string Url { get; set; }
    }
}