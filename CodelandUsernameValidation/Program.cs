using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodelandUsernameValidation
{
    public class Program
    {
        static void Main(string[] args)
        {
            // keep this function call here
            Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
        }

        public static string CodelandUsernameValidation(string str)
        {

            // code goes here 
            var charPos = 0;
            if (str.Length > 4 & str.Length < 25)
            {

                if (Char.IsLetter(str[0]))
                {

                    if (str[str.Length - 1] != '_')
                    {

                        while (charPos < str.Length)
                        {

                            if (Char.IsLetterOrDigit(str[charPos]) || str[charPos] == '_')
                            {
                                charPos++;
                            }
                            else
                            {
                                return "false";
                            }
                        }
                        return "true";
                    }
                    else return "false";
                }
                else return "false";
            }
            else return "false";

        }
    }

}
