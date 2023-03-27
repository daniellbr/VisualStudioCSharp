using System.Collections.Generic;

namespace MaoNaMassa.ContentContext
{
    public class Carrer : Content
    {
        public Carrer()
        {
            Items = new List<CarrerItem>();
        }

        public IList<CarrerItem> Items { get; set; }
        public int TotalCourses => Items.Count;
        //Expression body é a mesma coisa que { get { return Items.Count}  } 
        //Como só tem uma linha não é necessário abrir chaves nem o Get

    }
}