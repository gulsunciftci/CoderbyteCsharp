using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(WordCount(Console.ReadLine()));
        }
        public static int WordCount(string str)
        {

            // code goes here  
            var s = str.Split(' ');
            return s.Count();

        }
    }
    
}
