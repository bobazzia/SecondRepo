using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            long centuries = long.Parse(Console.ReadLine());
            long years = centuries * 100;
            double days = Math.Floor(centuries * 36524.2);
            long hours = (long)days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            long millisecond = seconds * 1000;
            BigInteger microseconds = millisecond * 1000;
            BigInteger nanoseconds = microseconds * 1000;

            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",centuries,years,days,hours,minutes,seconds,millisecond,microseconds,nanoseconds);
            
        }
    }
}
