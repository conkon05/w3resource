using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Exerises are written in a link below
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class LINQ4exe : IExe
    {
        /// <summary>
        /// 4. Write a program in C# Sharp to display the number
        /// and frequency of number from giving array. 
        /// </summary>
        public LINQ4exe()
        {

            Console.WriteLine("\n----Results below are for exerise no.4----\n");

            exe_part();

            Console.WriteLine("-----End---------");
        }
        public void exe_part()
        {
            var nums = new List<int>() { 55, 5, 5, 5, 3, 3, 32, 1, 1 };

            var tmp = nums.Distinct();
            foreach(var i in tmp)
            {
                Console.WriteLine("Number '{0}' appears {1}", i, nums.Count(s => s == i));
            }
        
            
        }
    }
}
