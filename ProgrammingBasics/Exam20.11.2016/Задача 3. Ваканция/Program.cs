using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3.Ваканция
{
    class Program
    {
        static void Main(string[] args)
        {
            var AdultPeople = int.Parse(Console.ReadLine());
            var SchoolPeople = int.Parse(Console.ReadLine());
            var Nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            var TransportPrice = 0.0;
            var PriceNights = Nights * 82.99;
            if (transport == "train")
            {
                TransportPrice = 2 * ((AdultPeople * 24.99) + (SchoolPeople * 14.99));
                if (AdultPeople + SchoolPeople > 49)
                {
                    TransportPrice = TransportPrice / 2;
                }
            }
            else if (transport == "bus")
            {
                TransportPrice = 2 * ((AdultPeople * 32.50) + (SchoolPeople * 28.50));
            }
            else if (transport == "boat")
            {
                TransportPrice = 2 * ((AdultPeople * 42.99) + (SchoolPeople * 39.99));
            }
            else if (transport == "airplane")
            {
                TransportPrice = 2 * ((AdultPeople * 70.00) + (SchoolPeople * 50.00));
            }
            var result = (TransportPrice + PriceNights) * 1.1;

            Console.WriteLine("{0:f2}", result);
        }
    }
}
