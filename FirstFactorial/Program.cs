using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstFactorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstFactorial(Convert.ToInt32(Console.ReadLine())));
        }
        public static int FirstFactorial(int num)
        {

            var fact = 1;
            for (int i = num; i >= 1; i--)
            {
                fact = fact * i;
            }
            // code goes here  
            return fact;

        }
    }
}
