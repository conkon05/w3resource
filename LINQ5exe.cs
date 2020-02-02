using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Exerises are written in a link below
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class LINQ5exe : IExe
    {
        /// <summary>
        /// 5. Write a program in C# Sharp to display the characters
        /// and frequency of character from giving string. 
        /// </summary>
        public LINQ5exe()
        {
            Console.WriteLine("\n----Results below are for exerise no.5----\n");

            exe_part();

            Console.WriteLine("-----End---------");
        }
        public void exe_part()
        {
            var chars = new List<char>() { 'a', 'a', 'a', 'w', 'w', 'q', };
            var Isfinished = false;
            
            do
            {
                Console.WriteLine("Enter a letter you like.");
                var picked = Console.Read();
                chars.Add(Convert.ToChar(picked));

                Console.WriteLine("Did you finish?");
                Console.ReadLine();
                if (Console.ReadLine().Equals("yes"))
                    Isfinished = true;
                
            } while (!Isfinished);

            var tmp = chars.Distinct();

            foreach(var i in tmp)
                Console.WriteLine("Character: {0} Times: {1}",i,chars.Count(c=>c==i));
            
        }
    }
}
