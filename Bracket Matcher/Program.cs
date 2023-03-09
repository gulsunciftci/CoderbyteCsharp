using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BracketMatcher
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BracketMatcher(Console.ReadLine()));
        }
        public static string BracketMatcher(string str)
        {

            // code goes here  
            str = Regex.Replace(str, "[^()]", String.Empty);
            char[] a = str.ToCharArray();
            int numOpens = 0;
            foreach (char p in a)
            {
                if (p == '(')
                {
                    numOpens++;
                }
                if (p == ')')
                {
                    if (numOpens <= 0)
                    {
                        return "0";
                    }
                    else
                    {
                        numOpens--;
                    }
                }
            }

            if (numOpens > 0)
            {
                return "0";
            }

            return "1";
        }
    }
}
