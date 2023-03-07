using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BracketCombinations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BracketCombinations(Convert.ToInt32(Console.ReadLine())));
        }
        public static int catalan(int n)
        {
            var res = 0;

            if (n <= 1) { return 1; }

            for (int i = 0; i < n; i++)
                res += catalan(i) * catalan(n - i - 1);

            return res;
        }

        public static int BracketCombinations(int num)
        {
            return catalan(num);
        }
    }

}
