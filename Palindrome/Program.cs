using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine().Split(' ');
            string s = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                string str1 = string.Empty;
                foreach (char c in str[i])
                {
                    str1=c+str1;
                }
                if (str[i] == str1.ToString())
                {
                    s = "true";
                    Console.WriteLine(s);
                    break;
                }
            }
            if (string.IsNullOrEmpty(s))
            {
                Console.WriteLine("false");
            }

        }
    }
}
