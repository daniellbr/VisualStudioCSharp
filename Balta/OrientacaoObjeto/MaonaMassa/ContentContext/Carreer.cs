using System.Collections.Generic;

namespace MaoNaMassa.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url) : base(title, url)
        {
            Items = new List<CareerItem>();
        }

        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count;
        //Expression body é a mesma coisa que { get { return Items.Count}  } 
        //Como só tem uma linha não é necessário abrir chaves nem o Get

    }
}