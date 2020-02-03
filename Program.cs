using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Exerises are written in a link below
/// 
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{

    public class LINQ11exe : IExe
    {

        /// <summary>
        /// 11. Write a program in C# Sharp to display the top n-th records.
        /// </summary>
        public void exe_part()
        {
            Console.WriteLine("\n\n----Results below are for exerise no.11---\n");
            var nums = new List<int>();

            Console.WriteLine("Enter a number you want to input data.");
            var n = Console.ReadLine();
            var n_tmp = Convert.ToInt32(n);

            int tmp;

            Console.WriteLine("Enter data.");
            for(var i = 0; i < n_tmp; i++)
            {
                n = Console.ReadLine();
                nums.Add(Convert.ToInt32(n));

            }

            nums.Sort();
            nums.Reverse();

            Console.WriteLine("How many top data do you want to display?");
            n = Console.ReadLine();
            var dis_num = Convert.ToInt32(n);

            Console.WriteLine("Data below are top {0} numbers.",dis_num);
            for (var i=0;i<dis_num;i++)
                Console.WriteLine(nums[i]);

        }
    }

    public delegate void execution();
    class Program
    {
        
        static void Main(string[] args)
        {
            
            var s = new LINQ1exe();
            var s2 = new LINQ2exe();
            var s3 = new LINQ3exe();
            var s4 = new LINQ4exe();
            var s4_2 = new LINQ4_2();
            //var s5 = new LINQ5exe();
            var s6 = new LINQ6exe();
            //var e1 = new exe1();
            var s7 = new LINQ7exe();
            var s8 = new LINQ8exe();
            var s9 = new LINQ9exe();
            //var s10 = new LINQ10exe();

            execution e;
            e =  new LINQ10exe().exe_part;
            //e += new LINQ11exe().exe_part;
            e = new LINQ12exe().exe_part;

            e();



        }
        
    }
}
