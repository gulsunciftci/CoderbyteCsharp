﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstFactorial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstFactorial(Convert.ToInt32(Console.ReadLine())));
        }
        public static int FirstFactorial(int num)
        {
            if (num == 0)
                return 1;
            else
                // recursive call
                return num * FirstFactorial(num - 1);

        }
    }
}
