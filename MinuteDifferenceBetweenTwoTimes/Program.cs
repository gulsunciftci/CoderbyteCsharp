using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinuteDifferenceBetweenTwoTimes
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            List<string> strings = str.Split('-').ToList();
            CultureInfo culture = new CultureInfo("en-US");
            int sum = 0;
            DateTime startTime = Convert.ToDateTime(strings[0], culture);
            DateTime endTime = Convert.ToDateTime(strings[1], culture);

            List<string> str1 = strings[0].Split(':').ToList();
            List<string> str2 = strings[1].Split(':').ToList();
            TimeSpan span;

            if ((strings[0][strings[0].Length - 2] == 'a' && strings[1][strings[1].Length - 2] == 'a') || (strings[0][strings[0].Length - 2] == 'p' && strings[1][strings[1].Length - 2] == 'p'))
            {
                if ((str1[0].Length == 2 && str2[0].Length == 2))
                {
                    if (int.Parse(str1[0]) > int.Parse(str2[0]))
                    {
                        span = startTime.Subtract(startTime);
                        sum = Convert.ToInt32(span.TotalMinutes);
                    }
                    else if (int.Parse(str1[0]) < int.Parse(str2[0]))
                    {
                        span = endTime.Subtract(startTime);
                        sum = 12*60 + Convert.ToInt32(span.TotalMinutes);
                    }
                }
                else if ((str1[0].Length == 2 && str2[0].Length == 1))
                {
                    span = endTime.Subtract(startTime);
                    sum = 24 * 60 + (Convert.ToInt32(span.TotalMinutes));
                }
                else if (str1[0].Length == 1 && str2[0].Length == 2)
                {
                    span =endTime.Subtract(startTime);
                    sum = (Convert.ToInt32(span.TotalMinutes));
                }
                else if (str1[0].Length == 1 && str2[0].Length == 1)
                {
                    if (int.Parse(str1[0]) > int.Parse(str2[0]))
                    {
                        span = startTime.Subtract(endTime);
                        sum = 24 * 60 - Convert.ToInt32(span.TotalMinutes);
                    }
                    else if (int.Parse(str1[0]) < int.Parse(str2[0]))
                    {
                        span = endTime.Subtract(startTime);
                        sum = Convert.ToInt32(span.TotalMinutes);
                    }
                }
            }
        
           else if (strings[0][strings[0].Length - 2] == 'p' && strings[1][strings[1].Length - 2] == 'a')
           {
                if (str1[0].Length == 1 && str2[0].Length == 1)
                {
                    span = startTime.Subtract(endTime);
                    sum = 12 * 60 - (Convert.ToInt32(span.TotalMinutes));
                }
                else
                {
                    span = startTime.Subtract(endTime);
                    sum = 12 * 60 - (Convert.ToInt32(span.TotalMinutes) - 12 * 60);
                }
           }
           else if (strings[0][strings[0].Length - 2] == 'a' && strings[1][strings[1].Length - 2] == 'p')
           {
                if (str1[0].Length == 1 && str2[0].Length == 1)
                {
                    span = endTime.Subtract(startTime);
                    sum = 12 * 60 + (Convert.ToInt32(span.TotalMinutes));
                }
                else
                {
                    span = endTime.Subtract(startTime);
                    sum = 12 * 60 + (Convert.ToInt32(span.TotalMinutes) - 12 * 60);
                }
                
           }
            
            Console.WriteLine(sum);

         }
    }
}

