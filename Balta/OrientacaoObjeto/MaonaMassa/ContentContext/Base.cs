using System;
using MaoNaMassa.NotficationContext;

namespace MaoNaMassa.ContentContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            Id = Guid.NewGuid(); //Cria um GUID novo um valor de 36 caracteres Id = new Guid(); Cria um id do tipo Guid porém zerado
        }

        public Guid Id { get; set; }
    }
}