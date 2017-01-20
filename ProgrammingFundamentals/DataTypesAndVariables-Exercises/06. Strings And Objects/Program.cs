using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            object result = text1 + ' ' + text2;
            string text3 = (string)result;

            Console.WriteLine(text3); 
        }
    }
}
