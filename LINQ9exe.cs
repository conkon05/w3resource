using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Exerises are written in a link below
/// 
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class LINQ9exe : IExe
    {
        /// <summary>
        /// 9. Write a program in C# Sharp to create a list of numbers 
        /// and display the numbers greater than 80 as output.
        /// 
        /// Test Data :
        /// The members of the list are :
        ///     55 200 740 76 230 482 95
        /// </summary>
        public LINQ9exe()
        {
            Console.WriteLine("\n----Results below are for exerise no.9----\n");

            exe_part();

            Console.WriteLine("-----End---------");
        }
        public void exe_part()
        {
            var nums = new List<int>() { 55, 200, 740, 76 ,230, 482, 95 };
            var target = 80;
            var Nums_higherthan = nums.Where(num => num > target);


            //Console.WriteLine("Numbers higher than {0} are below:-",target);
            //foreach (var n in Nums_higherthan)
            //{
            //    Console.WriteLine(" {0}", n);

            //}
            //Console.WriteLine();

            var better_ans = nums.FindAll(num => num > 80);// ? true : false);
            foreach(var n in better_ans)
                Console.WriteLine(n);
        }
    }
}
