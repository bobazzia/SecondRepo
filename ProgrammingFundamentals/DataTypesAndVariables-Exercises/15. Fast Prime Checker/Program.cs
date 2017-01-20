using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int counter = 2; counter <= num; counter++)
            {
                bool checkPrimeNumber = true;
                for (int devider = 2; devider <= Math.Sqrt(counter); devider++)
                {
                    if (counter % devider == 0)
                    {
                        checkPrimeNumber = false;
                        break;
                    }
                }
                Console.WriteLine($"{counter} -> {checkPrimeNumber}");
            }
        }
    }
}
