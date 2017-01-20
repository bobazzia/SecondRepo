using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var meters = double.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());
            var minutes = double.Parse(Console.ReadLine());
            var seconds = double.Parse(Console.ReadLine());

            var metersPerSecond = meters / ((hours * 60 + minutes) * 60 + seconds);
            var kilometersPerHour = (meters / 1000) / (((hours * 60 * 60) + (minutes * 60) + seconds) / 3600);
            var milesPerHour = (meters / 1609) / (((hours * 60 * 60) + (minutes * 60) + seconds) / 3600);

            Console.WriteLine(Math.Round(metersPerSecond, 6));
            Console.WriteLine(Math.Round(kilometersPerHour, 6));
            Console.WriteLine("{0:f6}", milesPerHour);
        }
    }
}
