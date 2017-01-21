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
                Console.WriteLine("{0} can't fit in any type", number);
                return;
            }
            checkNumber = long.Parse(number);
            Console.WriteLine("{0} can fit in:", checkNumber);
            if (checkNumber <= sbyte.MaxValue && checkNumber >= sbyte.MinValue)
            {
                Console.WriteLine("* sbyte");
            }
            if (checkNumber <= byte.MaxValue && checkNumber >= byte.MinValue)
            {
                Console.WriteLine("* byte");
            }
            if (checkNumber <= short.MaxValue && checkNumber >= short.MinValue)
            {
                Console.WriteLine("* short");
            }
            if (checkNumber <= ushort.MaxValue && checkNumber >= ushort.MinValue)
            {
                Console.WriteLine("* ushort");
            }
            if (checkNumber <= int.MaxValue && checkNumber >= int.MinValue)
            {
                Console.WriteLine("* int");
            }
            if (checkNumber <= uint.MaxValue && checkNumber >= uint.MinValue)
            {
                Console.WriteLine("* uint");
            }
            Console.WriteLine("* long");
        }
    }
}