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
            var str = Console.ReadLine().Split(' ').ToList(); //sayıları yan yana yaz 
            Console.WriteLine(CheckNums(Convert.ToInt32(str[0]), Convert.ToInt32(str[1])));
            
        }
        public static string CheckNums(int num1,int num2)
        {

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

            //https://www.scribd.com/document/477224981/Problem-Solving-1#
            //https://github.com/Hardanish-Singh/CoderByte-Challenges-Solutions/tree/master/string%20manipulation
            //https://github.com/ratracegrad/coderbyte-Beginner/blob/master/Check%20Numss
        }
    }
}
