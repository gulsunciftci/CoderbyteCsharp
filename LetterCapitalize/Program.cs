using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCapitalize
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            List<string> str = inputString.Split(' ').ToList();
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < str.Count; i++)
            {
                str[i]= char.ToUpper(str[i][0]) + str[i].Substring(1, str[i].Length-1);
                sb.Append(str[i]+" ");
            }
            Console.WriteLine(sb);
            
        }
    }
}
