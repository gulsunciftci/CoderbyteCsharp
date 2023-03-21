using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterChanges
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LetterChanges(Console.ReadLine()));
        }
        public static string LetterChanges(string str)
        {
            char[] strArr = str.ToCharArray();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < strArr.Length; i++)
            {
                if (char.IsLetter(strArr[i]) )
                {
                    
                    strArr[i]++;

                    if (!char.IsLetter(strArr[i]))
                    {
                        strArr[i] = 'A';
                    }

                    switch (Char.ToLower(strArr[i]))
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            strArr[i] = Char.ToUpper(strArr[i]);
                            break;
                        default:
                            break;
                    }
                }

                sb.Append(strArr[i]);
            }

            str = sb.ToString();
            return str;

        }
    }
}
