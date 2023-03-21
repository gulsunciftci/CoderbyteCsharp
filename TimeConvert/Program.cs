using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConvert
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Time = int.Parse(Console.ReadLine());
            int hour = Time / 60;
            int minute = Time % 60;
            Console.WriteLine($"{ hour}:{minute }");
        }
    }
}
