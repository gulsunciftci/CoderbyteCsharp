using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCheck
{
    public class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            Console.WriteLine(Result(str));

        }

        public static string Result(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.ToLower(str[i]) == 'a' && (i + 4) < str.Length && char.ToLower(str[i + 4]) == 'b')
                {
                    return "true";

                }
                else if (char.ToLower(str[i]) == 'b' && (i + 4) < str.Length && char.ToLower(str[i + 4]) == 'a')
                {
                    return "true";

                }
            }
            return "false";

        }
    }
}
