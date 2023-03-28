using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofNumbersinString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(findSum(Console.ReadLine()));
        }
        public static int findSum(string str)
        {
            String temp = "0";
            int sum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (char.IsDigit(ch))
                    temp += ch;
                else
                {
                    sum += int.Parse(temp);
                    temp = "0";
                }
            }
            return sum + int.Parse(temp);
        }
    }
}
