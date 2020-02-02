using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Exerises are written in a link below
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class LINQ7exe : IExe
    {
        /// <summary>
        /// 7. Write a program in C# Sharp to display numbers,
        /// multiplication of number with frequency and frequency of a number of giving array.
        /// </summary>
        public LINQ7exe()
        {
            Console.WriteLine("\n----Results below are for exerise no.7----\n");

            exe_part();

            Console.WriteLine("-----End---------");
        }
        public void exe_part()
        {
            var nums = new List<int>() { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            var tmp = nums;
            var nums_distinct = tmp.Distinct();

            //foreach (var i in nums_distinct)
            //{
            //    var count = nums.Count(n => n == i);
            //    Console.WriteLine("{0},{1},{2}", i, i*count, count);
            //}

            //var m = from x in nums
            //        group x by x into y
            //        select y;

            var l = nums.GroupBy(n => n);
            /// Note: GroupBy()
            ///   Organize data by specified key.
            ///   If "5" are three times in the data, it wraps up "5"s into IGroping.

            foreach (var arrEle in l)
            {
                Console.WriteLine(arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
            }


        }
    }
}
