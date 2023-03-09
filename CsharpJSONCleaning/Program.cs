using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CsharpJSONCleaning
{
    public class Program
    {
        static void Main(string[] args)
        {
            WebRequest request = WebRequest.Create("https://coderbyte.com/api/challenges/json/json-cleaning");
            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string strResult = reader.ReadLine();

            while (strResult != null)
            {
                string[] regexstr = new string[]{
          "[\"][a-zA-Z0-9_]*[\"]:[[\"][nN]\\\\\\/[aA][\"]]*[,]",
          "[\"][a-zA-Z0-9_]*[\"]:[[\"]-[\"]]*[,]",
          "[\"][a-zA-Z0-9_]*[\"]:[[\"][\"]]*[,]",
          "[,]\"-\"|\"-\"[,]"
          };

                foreach (var regex in regexstr)
                {
                    strResult = Regex.Replace(strResult, regex, string.Empty);
                }

                Console.WriteLine(strResult);
                strResult = reader.ReadLine();
            }
            response.Close();
            //https://gist.github.com/komalsdg/e7a43e1e18241714227d99c839bdbadf
        }
    }
}
