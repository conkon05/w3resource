using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Exerises are written in a link below
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class LINQ6exe : IExe
    {
        /// <summary>
        /// 6. Write a program in C# Sharp to display the name of
        /// the days of a week.
        /// </summary>
        public LINQ6exe()
        {
            Console.WriteLine("\n----Results below are for exerise no.6----\n");

            exe_part();

            Console.WriteLine("-----End---------");

        }
        public void exe_part()
        {

            //DateTime s = new DateTime();
            //for(var i = 0; i < 7; i++)
            //    Console.WriteLine(s.AddDays(i).DayOfWeek);

            var week = new List<string>(){ "Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday"};

            var daysOfweek = week.Select(w => new { WhatDayIsIt = w });
            foreach(var dow in daysOfweek)
                Console.WriteLine(dow.WhatDayIsIt);

        }
    }
}
