using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var SkumriaPrice = double.Parse(Console.ReadLine());
            var CacaPrice = double.Parse(Console.ReadLine());
            var PalamudKg = double.Parse(Console.ReadLine());
            var SafridKg = double.Parse(Console.ReadLine());
            var MidiKg = double.Parse(Console.ReadLine());

            var MidiPrice = MidiKg * 7.5;
            var SafridPricePerKg = CacaPrice * 1.8;
            var PalamudPricePerKg = SkumriaPrice * 1.6;
            var PalamudPrice = PalamudKg * PalamudPricePerKg;
            var SafridPrice = SafridKg * SafridPricePerKg;
            var result = SafridPrice + PalamudPrice + MidiPrice;

            Console.WriteLine("{0:f2}", result);
        }
    }
}
