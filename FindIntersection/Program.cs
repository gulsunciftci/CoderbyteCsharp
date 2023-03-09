using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindIntersection
{
    public class Program
    {
        static void Main(string[] args)
        {

            string strings = " ";
            strings=Console.ReadLine();
            String[] strings1 = strings;
            Console.WriteLine(FindIntersection(strings.ToArray());
        }
        public static string FindIntersection(string[] strArr)
        {
            string resultString = string.Join(",", strArr[0].Split(',').Select(x=>x.Trim()).Intersect(strArr[1].Split(',').Select(x => x.Trim())));
            return string.IsNullOrEmpty(resultString) ? "false" : resultString;

        }
    }
}
