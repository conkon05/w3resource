using System;
using System.Collections.Generic;
using System.Linq;
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
            e += new LINQ11exe().exe_part;

            e();



        }
        
    }
}
