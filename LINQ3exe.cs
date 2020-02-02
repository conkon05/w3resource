using System;
using System.Collections.Generic;
/// <summary>
/// Exerises are written in a link below
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class LINQ3exe : IExe
    {
        /// <summary>
        /// 3. Write a program in C# Sharp to find the number of an array
        /// and the square of each number. 
        /// </summary>
        public LINQ3exe()
        {
            Console.WriteLine("\n----Results below are for exerise no.3----\n");

            exe_part();

            Console.WriteLine("-----End---------");

        }
        public void exe_part()
        {
            var rand = new Random();

            var nums = new List<int>();
            var squres = new List<int>();

            Func<int,int> calc_squre = s => s*s;

            for(var i = 0; i < 20; i++)
                nums.Add(rand.Next(0, 101));

            foreach(var i in nums)
            {
                if (i % 2 == 0)             
                    squres.Add(calc_squre(i));
                
            }
            foreach (var squre in squres)
                Console.WriteLine("Number = {0} , Squre = {1}", Math.Sqrt(squre), squre);
        }
    }
}
