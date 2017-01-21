using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2.Домашни_любимци
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var FoodKg = int.Parse(Console.ReadLine());
            var FoodPerDayDogKg = double.Parse(Console.ReadLine());
            var FoodPerDayCatKg = double.Parse(Console.ReadLine());
            var FoodPerDayTurtleGrams = double.Parse(Console.ReadLine());
            var ResultFoodPerDay = FoodPerDayCatKg + FoodPerDayDogKg + FoodPerDayTurtleGrams / 1000;
            var ResultFoodAllneed = ResultFoodPerDay * days;

            if (FoodKg >= ResultFoodAllneed)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(FoodKg - ResultFoodAllneed));
            }
            else if (ResultFoodAllneed > FoodKg)
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(ResultFoodAllneed - FoodKg));
            }
        }
    }
}
