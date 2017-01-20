using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string result1 = Convert.ToString(num, 16);
            result1 = result1.ToUpper();
            string result2 = Convert.ToString(num, 2);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
