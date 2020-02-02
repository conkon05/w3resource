using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Exerises are written in a link below
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class LINQ1exe : IExe
    {
        public LINQ1exe()
        {
            Console.WriteLine("\n---Results below are for exe1---\n");

            exe_part();

            Console.WriteLine("-----End---------");
        }

        public void exe_part()
        {
            var nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var anss = nums.Where(n => n % 2 == 0);

            Console.WriteLine("LINQ exerise 1");
            foreach (var ans in anss)
            Console.WriteLine(ans);
        }

    }
}
