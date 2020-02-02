using System;
/// <summary>
/// Exerises are written in a link below
/// 
/// https://www.w3resource.com/csharp-exercises/linq/index.php
/// </summary>
namespace w3resource
{
    public class exe1 : IExe
    {
        public exe1()
        {
            Console.WriteLine("\n----Results below are for exerise no.1----\n");

            exe_part();

            Console.WriteLine("-----End---------");

        }

        public void exe_part()
        {
            string n;
            int tmp;
            do
            {
                n = Console.ReadLine();
                tmp = Convert.ToInt32(n);

            } while (tmp < 2 || tmp > 100);
            
            var ans = 0;
            for (var i = 1; i <= tmp; i++)
                ans += i;

            Console.WriteLine(ans);
                
            
            
        }
    }
}
