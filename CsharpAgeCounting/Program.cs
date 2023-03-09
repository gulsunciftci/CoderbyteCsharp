using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAgeCounting
{
    public class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("https://coderbyte.com/api/challenges/json/age-counting");
            WebResponse response = (HttpWebResponse)request.GetResponse();

            using (var dataStream = response.GetResponseStream())
            {
                var reader = new StreamReader(dataStream);
                var json = reader.ReadToEnd();

                var ageCount = GetAgeCount(json);

                Console.WriteLine(ageCount);
            }

            response.Close();
        }
        public static int GetAgeCount(string json)
        {
            json = json.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "");
            var content = json.Replace(@"{""data"":""", "").Replace("}", "");
            var contentArr = content.Split(',');
            var ageCounter = 0;

            foreach (var item in contentArr)
            {
                if (item.IndexOf("age=") > -1)
                {
                    var age = int.TryParse(item.Split('=').Last(), out var parseAge) ? parseAge : 0;
                    if (age >= 50) ageCounter++;
                }
            }

            return ageCounter;
            //https://dotnetfiddle.net/P4xosV
        }
    }
}
