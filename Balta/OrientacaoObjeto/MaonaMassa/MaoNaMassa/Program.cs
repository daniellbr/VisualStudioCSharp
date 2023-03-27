using System;
using System.Collections.Generic;
using MaoNaMassa.ContentContext;
using MaoNaMassa.ContentContext.Enums;

namespace MaoNaMassa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var course = new Course("Curso de OOP", "C#");
            course.Level = EContentLevel.Advance;
            course.Level = ContentContext.Enums.EContentLevel.Intermediary;

            var carrer = new Carrer("Curso Balta", ".Net");
            carrer.Items.Add(new CarrerItem());
            Console.WriteLine(carrer.TotalCourses);

            var articles = new List<Article>();
            articles.Add(new Article("Curso do Balta Construtor", "Balta.IO"));
            articles.Add(new Article("Curso do Orientacao Obj", "Balta.IO-obj"));
            articles.Add(new Article("Curso do C#", "Balta"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
        }
    }
}
