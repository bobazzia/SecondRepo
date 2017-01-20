using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            if (text == "a" || text == "e" || text == "u" || text == "o" || text == "i")
            {
                Console.WriteLine("vowel");
            }
            else if (text=="1"|| text == "2" || text == "3" || text == "4" || text == "5" || text == "6" || text == "7" || text == "8" || text == "9" || text == "0")
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
