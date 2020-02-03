using System;
using System.Linq;
/// <summary>
/// Exerises are written in a link below
/// 
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class LINQ12exe : IExe
    {
        /// <summary>
        /// 12. Write a program in C# Sharp to find the uppercase words in a string.
        /// </summary>
        public void exe_part()
        {
            Console.WriteLine("\n----Results below are for exerise no.12----\n");

            //var words = Console.ReadLine();
            //var tmp = words.Split(' ');

            //var words_uppercase = new List<string>();
            //foreach(var word in tmp)
            //{
            //    if (Char.IsUpper(word[0]))
            //        words_uppercase.Add(word);
            //}

            //Console.WriteLine("Uppercase words are :- ");
            //words_uppercase.ForEach(word => Console.WriteLine(word));

            /// Solution below introduced in the site
            var w = Console.ReadLine();
            var s = w.Split(' ')
                    .Where(wl => String.Equals(wl, wl.ToUpper(), StringComparison.Ordinal));
            Console.WriteLine("Uppercase words are :- ");
            s.ToList().ForEach(word => Console.WriteLine(word));
            


        }
    }
}
