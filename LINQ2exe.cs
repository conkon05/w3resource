using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Exerises are written in a link below
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class LINQ2exe : IExe
    {
        /// <summary>
        /// 2. Write a program in C# Sharp to find the +ve numbers
        /// from a list of numbers using two where conditions in LINQ Query.
        /// * +ve stand for possitive
        /// </summary>
        public LINQ2exe()
        {
            Console.WriteLine("\n----Results below are for exe2----\n");

            exe_part();

            Console.WriteLine("-----End---------");
        }

        public void exe_part()
        {
            var nums = new List<int>();
            for (var i = 1; i <= 11; i++)
                nums.Add(i);

            var ans = nums
                .Where(s => s > 0)
                .Where(s => s % 2 == 1);

            Console.WriteLine("Picked numbers below by using two 'where' conditions");
        }
    }
}
