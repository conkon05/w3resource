using System;
/// <summary>
/// Exerises are written in a link below
/// 
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class LINQ8exe : IExe
    {
        /// <summary>
        /// 8. Write a program in C# Sharp to find the string which
        /// starts and ends with a specific character.
        /// The cities are : "ROME","LONDON","NAIROBI","CALIFORNIA",
        /// "ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS"
        /// Input starting character for the string : A
        /// Input ending character for the string : M
        /// Expected Output :
        /// The city starting with A and ending with M is : AMSTERDAM
        /// </summary>
        public LINQ8exe()
        {
            Console.WriteLine("\n----Results below are for exerise no.8----\n");

            exe_part();

            Console.WriteLine("-----End---------");

        }
        public void exe_part()
        {
            
            string[] cities = {"ROME","LONDON","NAIROBI","CALIFORNIA",
                              "ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS"};
            string ans = "Not found";
            var keyword_s = "A";
            var keyword_e = "M";

            foreach(var city in cities)
            {
                if (city.StartsWith(keyword_s))
                {
                    if (city.EndsWith(keyword_e))
                        ans = city;

                }
                
            }
            Console.WriteLine("The city started from {0} and ended with {1}", keyword_s, keyword_e);
            Console.WriteLine("That will be picked up from cities below.");
            Array.ForEach(cities, city => Console.Write(" {0},", city));
            Console.WriteLine("\nThe answer: {0}", ans);


            //var better_ans = cities.Where(city => city.StartsWith(keyword_s))
            //                       .Where(city => city.EndsWith(keyword_e));

            //Console.WriteLine("The city started from {0} and ended with {1}", keyword_s, keyword_e);
            //Console.WriteLine("That will be picked up from cities below.");
            //Array.ForEach(cities, city => Console.Write(" {0},", city));
            //Array.ForEach(better_ans, better_ans => Console.WriteLine(" {0}", better_ans));
            



        }
    }
}
