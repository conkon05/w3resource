using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Exerises are written in a link below
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class LINQ4_2 : IExe
    {
        public LINQ4_2()
        {
            Console.WriteLine("\n----Results below are for exerise no.4_2----\n");

            exe_part();

            Console.WriteLine("-----End---------");
        }
        protected class Student
        {
            public byte Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public List<int> scores { get; set; }

        }
        public void exe_part()
        {
            var students = new List<Student>() {
                new Student{
                    Id = 1,
                    FirstName="Ago",
                    LastName="Stun",
                    scores = new List<int>() { 20,30,88}
                },
                new Student{
                    Id = 2,
                    FirstName = "Andy",
                    LastName = "Hathaway",
                    scores = new List<int>(){55,36,87}
                },
                new Student
                {
                    Id = 3,
                    FirstName = "John",
                    LastName = "Diggle",
                    scores = new List<int>(){34,66,98}
                }

            };


            var people = from person in students
                         where person.scores.Max() > 40
                         select new { Id = person.Id, High_score = person.scores.Max() };

            var people2 = students
                .Where(s => s.scores.Min() > 35)
                .Select(s => new {ID2 = s.Id, High_score2 = s.scores.Max() });


            foreach(var p in people)
                Console.WriteLine("Id = {0}, Score = {1}",p.Id,p.High_score);

            Console.WriteLine("\n");
            foreach (var p in people2)
                Console.WriteLine("Id = {0}, Score = {1}", p.ID2, p.High_score2);

        }
    }
}
