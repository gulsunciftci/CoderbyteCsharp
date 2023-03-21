using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAdding
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(Convert.ToInt32(Console.ReadLine())));
        }

        public static int Sum(int n)
        {
           
            if (n == 1)
                return 1;
            else
                return n + Sum(n - 1);
        }
    }
}
