using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exOh
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
            int countX = 0;
            int countO = 0;
            foreach (char s in str)
            {
                if (char.ToLower(s) == 'x')
                {
                    countX++;
                }
                else if (char.ToLower(s) == 'o')
                {
                    countO++;
                }
                else
                {
                    return "false";
                }
            }
            if (countX == countO)
            
                return "true";
            
            else  
                return "false";
           
        }
    }
}
