using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEvens
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SimpleEvens(Console.ReadLine()));
        }
        public static string SimpleEvens(string num)
        {

            // code goes here
            
            for (int i = 0; i < num.Length; i++)
            {
                if ((num[i] % 2) != 0)
                {
                    return "false";
                }
            }

            return "true";

        }
    }
}
