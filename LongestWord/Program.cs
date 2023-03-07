using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LongestWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestWord(Console.ReadLine()));
        }
        public static string LongestWord(string sen)
        {

            Regex rgx = new Regex(@"[^\w\s]");
            sen = rgx.Replace(sen, "");
            string[] words = sen.Split(' ');

            return words.OrderByDescending(x => x.Length).First();
            //return Regex.Replace(sen, @"[^\w\s]", "").Split(' ').OrderByDescending(i => i.Length).First();
        }
    }

   
}

