using System;
using System.Collections.Generic;
/// <summary>
/// Exerises are written in a link below
/// 
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class LINQ10exe : IExe
    {
        /// <summary>
        /// 10. Write a program in C# Sharp to Accept the members of a list through the keyboard
        /// and display the members more than a specific value. Go to the editor
        /// 
        //  Test Data :
        //  Input the number of members on the List : 5
        //  Member 0 : 10
        //  Member 1 : 48
        //  Member 2 : 52
        //  Member 3 : 94
        //  Member 4 : 63
        /// Input the value above you want to display the members of the List : 59
        /// </summary>
        
        public void exe_part()
        {
            Console.WriteLine("\n\n----Results below are for exerise no.10---\n");

            var nums = new List<int>();

            Console.WriteLine("Enter a number which you want to enter data:");
            var n = Console.ReadLine();
            var tmp = Convert.ToInt32(n);

            Console.WriteLine("Enter a threshold:");
            n = Console.ReadLine();
            var target = Convert.ToInt32(n);

            Console.WriteLine("Enter data:");
            for (var i = 0; i < tmp; i++)
            {
                var input = Console.ReadLine();
                var input_int = Convert.ToInt32(input);
                nums.Add(input_int);
            }

            var ans = nums.FindAll(num => num > target);

            Console.WriteLine("\n Inputed values are below:-");
            foreach (var  input in nums)
                Console.Write("{0} ",input);

            Console.WriteLine("\n The answer that numbers higher than {0} are below:-",target);
            foreach(var num in ans)
                Console.WriteLine(num);
        }
    }
}
