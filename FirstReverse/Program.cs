using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstReverse(Console.ReadLine()));
        }
        public static string FirstReverse(string str)
        {


            string sol =String.Empty;
            foreach (char c in str)
            {
                sol = sol+c;
                Console.WriteLine(sol);

            }



            return sol;

        }

    }
}
