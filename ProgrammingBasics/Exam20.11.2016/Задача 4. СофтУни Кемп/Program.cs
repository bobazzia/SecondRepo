using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4.СофтУни_Кемп
{
    class Program
    {
        static void Main(string[] args)
        {
            var groups = int.Parse(Console.ReadLine());
            var AllPeople = 0;
            var carPeople = 0;
            var busPeople = 0;
            var SmallBigbus = 0;
            var Bigbus = 0;
            var train = 0;

            for (int i = 1; i <= groups; i++)
            {
                var people = int.Parse(Console.ReadLine());
                if (people < 6)
                {
                    AllPeople = AllPeople + people;
                    carPeople = carPeople + people;
                }
                else if (people > 5 && people < 13)
                {
                    AllPeople = AllPeople + people;
                    busPeople = busPeople + people;
                }
                else if (people > 12 && people < 26)
                {
                    AllPeople = AllPeople + people;
                    SmallBigbus = SmallBigbus + people;
                }
                else if (people > 25 && people < 41)
                {
                    AllPeople = AllPeople + people;
                    Bigbus = Bigbus + people;
                }
                else if (people > 40)
                {
                    AllPeople = AllPeople + people;
                    train = train + people;
                }
            }
            Console.WriteLine("{0:f2}%", 1.0 * carPeople / AllPeople * 100);
            Console.WriteLine("{0:f2}%", 1.0 * busPeople / AllPeople * 100);
            Console.WriteLine("{0:f2}%", 1.0 * SmallBigbus / AllPeople * 100);
            Console.WriteLine("{0:f2}%", 1.0 * Bigbus / AllPeople * 100);
            Console.WriteLine("{0:f2}%", 1.0 * train / AllPeople * 100);
        }
    }
}
