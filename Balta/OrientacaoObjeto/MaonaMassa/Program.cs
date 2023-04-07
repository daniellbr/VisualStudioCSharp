using System;
using System.Collections.Generic;
using System.Linq;
using MaoNaMassa.ContentContext;
using MaoNaMassa.ContentContext.Enums;
using MaoNaMassa.SubscriptionContext;

namespace MaoNaMassa
{
    class Program
    {
        static void Main(string[] args)
        {
            var course = new Course("Curso de OOP", "fundamento-OOP");
            course.Level = EContentLevel.Advance;
            course.Level = ContentContext.Enums.EContentLevel.Intermediary;

            var carrer = new Career("Curso Balta", ".Net");
            // carrer.Items.Add(new CareerItem(1, "Teste", "", null));
            // Console.WriteLine(carrer.TotalCourses);

            var articles = new List<Article>();
            articles.Add(new Article("Curso do Balta Construtor", "Balta.IO"));
            articles.Add(new Article("Curso do Orientacao Obj", "Balta.IO-obj"));
            articles.Add(new Article("Curso do C#", "Balta"));

            foreach (var article in articles)
            {
                // Console.WriteLine(article.Id);
                // Console.WriteLine(article.Title);
                // Console.WriteLine(article.Url);
            }

            var courses = new List<Course>();
            var courseOOP = new Course("Curso de OOP", "fundamento-OOP");
            //  var courseCsharp = new Course("Curso de Csharp", "fundamento-CSharp");
            var courseCsharp = new Course("Curso de Csharp", null);
            var courseAspNet = new Course("Curso de AspNet", "fundamento-AspNet");
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);



            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .net", ".net");
            var careerCSharp = new Career("Especialista CSharp", "CSharp");
            var careerAspnet = new Career("Especialista AspNet", "AspNet");
            //var careerItem3 = new CareerItem(3, "Finalize por aqui", "", courseOOP);
            var careerItem3 = new CareerItem(3, "Finalize por aqui", "", null);
            var careerItem1 = new CareerItem(1, "Comece por aqui", "", courseAspNet);
            var careerItem2 = new CareerItem(2, "Proximo curso", "", courseCsharp);
            careers.Add(careerDotNet);
            careerDotNet.Items.Add(careerItem3);
            careerDotNet.Items.Add(careerItem1);
            careerDotNet.Items.Add(careerItem2);

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    Console.WriteLine($"{item.Course?.Level} - {item.Course?.Title}");
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }
            }

            var payPalSubscription = new PayPalSubscriptions();
            var student = new Student("Juca", "juca@juca.com", null);
            student.Subscriptions.Add(payPalSubscription);
        }
    }
}
