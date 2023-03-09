using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CheckNums
{
    public class Program
    {
        static void Main(string[] args)
        {
            ////var str = Console.ReadLine().Split('&');
            //var s = Console.ReadLine().Split('&');
            //var num1 = Convert.ToInt32(s[0].Trim());
            //var num2 = Convert.ToInt32(s[1].Trim());
            //Console.WriteLine(CheckNums(num1,num2));
            var str = Console.ReadLine().Split(' ');
            Console.WriteLine(str.Count());
        }
        public static string CheckNums(int num1,int num2)
        {

            

            // code goes here  
            //var s = Console.ReadLine().Split('&');
            String res = "";
            if (num2 > num1)
            {
                res += "1";
            }
            else if (num2 < num1)
            {
                res += "0";
            }
            else if (num1 == num2)
            {
                res += "-1";
            }

            return res;
        }
    }
}
