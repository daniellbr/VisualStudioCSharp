using System;
using MaoNaMassa.ContentContext;
using MaoNaMassa.ContentContext.Enums;

namespace MaoNaMassa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var course = new Course();
            course.Level = EContentLevel.Advance;
            course.Level = ContentContext.Enums.EContentLevel.Intermediary;

            var carrer = new Carrer();
            carrer.Items.Add(new CarrerItem());
            Console.WriteLine(carrer.TotalCourses);
        }
    }
}
