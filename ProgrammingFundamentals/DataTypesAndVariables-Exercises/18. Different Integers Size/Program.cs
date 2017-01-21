using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            long checkNumber = 0;
            try
            {
                checkNumber = long.Parse(number);
            }
            catch (OverflowException)
            {
                Console.WriteLine($"{number} can't fit in any type");
                return;
            }
            checkNumber = long.Parse(number);
            Console.WriteLine($"{checkNumber} can fit in:");
            if (checkNumber <= 127 && checkNumber > -128)
            {
                Console.WriteLine("* sbyte");
            }
            if (checkNumber <= 255 && checkNumber >= 0)
            {
                Console.WriteLine("* byte");
            }
            if (checkNumber <= 32767 && checkNumber >= -32768)
            {
                Console.WriteLine("* short");
            }
            if (checkNumber <= 65535 && checkNumber >= 0)
            {
                Console.WriteLine("* short");
            }
            if (checkNumber <= 2147483647 && checkNumber >= -2147483648)
            {
                Console.WriteLine("* int");
            }
            if (checkNumber <= 4294967295 && checkNumber >= 0)
            {
                Console.WriteLine("* uint");
            }
            Console.WriteLine("* long");
        }
    }
}
